using System;
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
    class ANPR
    {
        struct PLATE_CANDIDATE
        {
	        int id; // reserved
	        int foundCount;
	        ulong firstfoundTime;
	        string plate_string;
        }

        List<PLATE_CANDIDATE> _list;

        // Creates the ANPR object
        private cmAnpr _anpr = new cmAnpr("default");
        // Creates the image object
        private gxImage _image = new gxImage("default");

        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _isANPRThreadRun;

        public ANPR()
        {
            initANPR(_anpr);
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

        public void ANPRThreadFunction()
        {
            
        }

        public int getValidPlates(cmAnpr anpr, gxImage image, List<string> list)
        {
	        int count = 0;

	        try {

		        // Finds the first plate and displays it
		        //QueryPerformanceCounter(&counter_before);
		        bool found = anpr.FindFirst(image);
		        //QueryPerformanceCounter(&counter_after);
		        //double anprTime = (double)(counter_after.QuadPart - counter_before.QuadPart) / freq.QuadPart;

                list.Clear();

		        while (found) {
			        string resultLoop = anpr.GetText();

                    if (isValidPlateString(resultLoop))
                    {
				        //printf( "[OK]%s\t", result );

                        list.Add(resultLoop);
				        count++;

			        }
			        else {
				        //printf( "[NG]%s\t", result );
			        }

			        // Finds other plates
			        found = anpr.FindNext();
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
