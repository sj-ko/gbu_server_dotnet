﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using gx;
using cm;

namespace GBU_Server_DotNet
{
    static class Constants
    {
        public const int CANDIDATE_REMOVE_TIME = 60000; // ms
        public const int CANDIDATE_COUNT_FOR_PASS = 3;
        public const int MAX_IMAGE_BUFFER = 50;
    }

    class ANPR
    {
        public struct PLATE_CANDIDATE
        {
            public int id; // reserved
            public int foundCount;
            public int firstfoundTime;
            public string plate_string;
        }

        public struct GBUVideoFrame
        {
            public Byte[] frame;
            public int camindex;
        };

        List<PLATE_CANDIDATE> _list;
        GBUVideoFrame[] _imageBuffer = new GBUVideoFrame[Constants.MAX_IMAGE_BUFFER];
        int _imageBufferCount = 0;
        int _imageBufferEmptyIndex = 0;

        // Creates the ANPR object
        private cmAnpr _anpr = new cmAnpr("default");
        // Creates the image object
        private gxImage _image = new gxImage("default");

        Thread ANPRThread;
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _isANPRThreadRun = false;

        public ANPR()
        {
            initANPR(_anpr);

            ANPRThread = new Thread(ANPRThreadFunction);
        }

        ~ANPR()
        {
            ANPRStopThread();
        }

        private void initANPR(cmAnpr anpr)
        {
            anpr.SetProperty("anprname", "cmanpr-7.2.7.68:kor");
            anpr.SetProperty("size_min", "8"); // Default 6
            anpr.SetProperty("size_max", "40"); // Default 93

            anpr.SetProperty("nchar_min", "7"); // Default 8
            anpr.SetProperty("nchar_max", "9"); // Default 9

            anpr.SetProperty("slope", "-5"); // Default -22
            anpr.SetProperty("slope_min", "-20"); // Default -22
            anpr.SetProperty("slope_max", "10"); // Default 34

            anpr.SetProperty("slant", "0"); // Default 10
            anpr.SetProperty("slant_min", "-10"); // Default -55
            anpr.SetProperty("slant_max", "10"); // Default 27
        }

        public void ANPRRunThread()
        {
            _isANPRThreadRun = true;
            if (ANPRThread != null)
            {
                ANPRThread.Start();
            }
        }

        public void ANPRStopThread()
        {
            _isANPRThreadRun = false;
            if (ANPRThread != null)
            {
                ANPRThread.Join();
            }
        }

        public void ANPRThreadFunction()
        {
            List<string> anpr_result = new List<string>();
            List<PLATE_CANDIDATE> plate_candidates = new List<PLATE_CANDIDATE>();
            GBUVideoFrame frame = new GBUVideoFrame();
            gxImage targetImage;

            while (_isANPRThreadRun)
            {

                if (popMedia(ref frame))
                {
                    anpr_result.Clear();

                    _image.LoadFromMem(frame.frame, (int)GX_PIXELFORMATS.GX_RGB);

                    if (getValidPlates(_image, anpr_result) > 0)
                    {

                        // Remove old results
                        int currentTime = Environment.TickCount;
                        for (int i = plate_candidates.Count - 1; i >= 0; i--)
                        {
                            if (plate_candidates[i].firstfoundTime > Constants.CANDIDATE_REMOVE_TIME)
                            {
                                plate_candidates.RemoveAt(i);
                            }
                        }

                        // Check duplicate
                        for (int i = 0; i < anpr_result.Count; i++)
                        {
                            bool isNew = true;

                            for (int j = 0; j < plate_candidates.Count; j++)
                            {
                                //if (_tcsnccmp(anpr_result[i].c_str(), plate_candidates[j].plate_string, _tcslen(anpr_result[i].c_str())) == 0)  {
                                if (anpr_result[i].Equals(plate_candidates[j].plate_string))
                                {
                                    isNew = false;

                                    PLATE_CANDIDATE modified;
                                    modified.firstfoundTime = plate_candidates[j].firstfoundTime;
                                    modified.foundCount = plate_candidates[j].foundCount + 1;
                                    modified.id = plate_candidates[j].id;
                                    modified.plate_string = plate_candidates[j].plate_string;
                                    plate_candidates.RemoveAt(j);
                                    plate_candidates.Add(modified);

                                    if (plate_candidates[j].foundCount == Constants.CANDIDATE_COUNT_FOR_PASS)
                                    {
                                        // Announce Event
                                        //SetLog(cropregion, plate_candidates[j].plate_string, TEXT("msg"));

                                        //wchar_t eventlog[1024];
                                        //wsprintf(eventlog, TEXT("%s\t"), plate_candidates[j].plate_string);
                                        //OutputDebugString(eventlog);
                                        Console.WriteLine("Detected candidate : " + plate_candidates[j].plate_string);
                                    }
                                    break;
                                }
                            }

                            if (isNew)
                            {
                                currentTime = Environment.TickCount;
                                PLATE_CANDIDATE newItem;
                                newItem.firstfoundTime = currentTime;
                                newItem.foundCount = 1;
                                newItem.plate_string = anpr_result[i];
                                newItem.id = 0;

                                plate_candidates.Add(newItem);
                            }
                        }
                    }


                }

                // end of thread cycle
                Thread.Sleep(1);
            }
        }

        public int getValidPlates(gxImage image, List<string> list)
        {
	        int count = 0;

	        try {

		        // Finds the first plate and displays it
		        //QueryPerformanceCounter(&counter_before);
		        bool found = _anpr.FindFirst(image);
		        //QueryPerformanceCounter(&counter_after);
		        //double anprTime = (double)(counter_after.QuadPart - counter_before.QuadPart) / freq.QuadPart;

                list.Clear();

		        while (found) {
			        string resultLoop = _anpr.GetText();

                    if (isValidPlateString(resultLoop))
                    {
                        Console.WriteLine("[OK]" + resultLoop);

                        list.Add(resultLoop);
				        count++;

			        }
			        else {
                        Console.WriteLine("[NG]" + resultLoop);
			        }

			        // Finds other plates
			        found = _anpr.FindNext();
		        }
		        //printf("\n");
		        //printf("\nMemLoad:%lf\tAnpr:%lf\n", loadTime, anprTime);
	        }
	        catch (gxException e) {
		        System.Diagnostics.Debug.WriteLine("Get Plates Failed : " + e.ToString());
	        }

	        return count;
        }

        // for test
        public void getValidPlate2(Bitmap anprImage, int width, int height)
        {
            byte[] anprByteArray = imageToByteArray(anprImage);

            Console.WriteLine("image size " + anprByteArray.Length);

            bool ret = _image.LoadFromMem(anprByteArray, (int)GX_PIXELFORMATS.GX_RGB);

            Console.WriteLine("Load ANPR Image " + ret);

            // Finds the first plate and displays it
            if (_anpr.FindFirst(_image))
            {
                Console.WriteLine("Result: '{0}'", _anpr.GetText());
                Console.WriteLine("Type: '{0}'", _anpr.GetType());
            }
            else
            {
                Console.WriteLine("No plate found");
            }
        }

        public void pushMedia(Bitmap anprImage, int width, int height)
        {
            if (_imageBufferCount >= Constants.MAX_IMAGE_BUFFER)
            {
                Console.WriteLine("Media Buffer Overflow!");
                return;
            }
            
            byte[] anprByteArray = imageToByteArray(anprImage);
            _imageBuffer[_imageBufferEmptyIndex++].frame = anprByteArray;
            //Console.WriteLine("image size " + anprByteArray.Length);

            if (_imageBufferEmptyIndex >= Constants.MAX_IMAGE_BUFFER)
            {
                _imageBufferEmptyIndex = 0;
            }
            _imageBufferCount++;

        }

        public bool popMedia(ref GBUVideoFrame frame)
        {
            if (_imageBufferCount > 0)
            {
                int frontindex = _imageBufferEmptyIndex - _imageBufferCount;
                if (frontindex < 0)
                {
                    frontindex += Constants.MAX_IMAGE_BUFFER;
                }
                frame.frame = _imageBuffer[frontindex].frame;

                _imageBufferCount--;

                return true;
            }
            else
            {
                return false;
            }
        }

        bool isValidPlateString(string plateValue)
        {
	        if (plateValue[0] < 0 || Char.IsDigit(plateValue[0]) == false) {
		        // Check Old (Loca-12-Kr-1234)
                if (plateValue[2] < 0 || Char.IsDigit(plateValue[2]) == false) return false;
                if (plateValue[3] < 0 || Char.IsDigit(plateValue[3]) == false) return false;
                if (plateValue[5] < 0 || Char.IsDigit(plateValue[5]) == false) return false;
                if (plateValue[6] < 0 || Char.IsDigit(plateValue[6]) == false) return false;
                if (plateValue[7] < 0 || Char.IsDigit(plateValue[7]) == false) return false;
                if (plateValue[8] < 0 || Char.IsDigit(plateValue[8]) == false) return false;
	        }
	        else {
		        // 2006 yr. (12-Kr-1234)
                if (plateValue[1] < 0 || Char.IsDigit(plateValue[1]) == false) return false;
                if (plateValue[3] < 0 || Char.IsDigit(plateValue[3]) == false) return false;
                if (plateValue[4] < 0 || Char.IsDigit(plateValue[4]) == false) return false;
                if (plateValue[5] < 0 || Char.IsDigit(plateValue[5]) == false) return false;
                if (plateValue[6] < 0 || Char.IsDigit(plateValue[6]) == false) return false;
	        }

	        return true;
        }

        private byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}
