//#define TEST_PAINTEVENT

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using gx;
using cm;

namespace GBU_Server_DotNet
{
    public partial class MainForm : Form
    {
        public Camera camera;
        private MediaPlayer player;
        private ANPR anpr;
        private System.Threading.Timer timer;
        private AutoResetEvent timerEvent;

        public MainForm()
        {
            InitializeComponent();
        }

        ~MainForm()
        {
            Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Camera ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Data & Time", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Plate String", 100, HorizontalAlignment.Left);

            InitCamera();
            UpdateFormUIValue();
        }

        private void InitCamera()
        {
            camera = new Camera();
            camera.PropertyChanged += camera_PropertyChanged;
        }

        private void UpdateFormUIValue()
        {
            this.Text = "Gaenari ANPR" + " - Camera " + camera.camID;
        }

        private void camera_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateFormUIValue();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            anpr = new ANPR();
            anpr.camID = camera.camID;

            string path = camera.camURL;
            //string path = "C:\\업무문서\\ppt\\MicroModule 아키텍처.wmv";
            player = new MediaPlayer(".\\plugins");
           
            player.SetRenderWindow((int)this.panel1.Handle);
            player.PlayStream(path, 1920, 1080);
            //player.PlayFile(path);

#if TEST_PAINTEVENT
            panel1.Paint += panel1_Paint; // change to timer
#else
            //
            timerEvent = new AutoResetEvent(true);
            timer = new System.Threading.Timer(MediaTimerCallBack, null, 1000, 100);
            anpr.ANPRRunThread();
            anpr.ANPRDetected += anpr_ANPRDetected;
#endif
        }

        private void anpr_ANPRDetected(int channel, string plateStr)
        {
            Console.WriteLine("ANPR Detected channel " + channel + " Time is " + DateTime.Now);

            if (this.panel1.InvokeRequired)
            {
                this.panel1.BeginInvoke(new Action(() =>
                    {
                        string[] itemStr = { Convert.ToString(channel, 10), DateTime.Now.ToString(), plateStr };
                        ListViewItem item = new ListViewItem(itemStr);
                        listView1.Items.Add(item);

                        textBox_anpr.Text = plateStr;

                        Bitmap bmp = new Bitmap(this.anprResultThumbnail.Width, this.anprResultThumbnail.Height);
                        bmp = (Bitmap)ImageCapture.DrawToImage(this.panel1);
                        anprResultThumbnail.Image = bmp;
                        //bmp.Dispose();
                    }
                ));
            }

        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (player != null)
            {
                player.Stop();
            }

            timer.Change(Timeout.Infinite, Timeout.Infinite); // stop timer
            timer.Dispose();
            timer = null;

            anpr.ANPRStopThread();
            anpr.ANPRDetected -= anpr_ANPRDetected;
            anpr = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height);

            // In order to use DrawToBitmap, the image must have an INITIAL image. 
            // Not sure why. Perhaps it uses this initial image as a mask??? Dunno.
            /*using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Color.Yellow);
            }*/

            bmp = (Bitmap)ImageCapture.DrawToImage(this.panel1);
            anpr.getValidPlate2(bmp, bmp.Width, bmp.Height);

            //bmp.Save("c:\\save.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            bmp.Dispose();
        }

        private void MediaTimerCallBack(Object obj)
        {
            //Console.WriteLine("MediaTimerCallBack");
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height);

            if (this.panel1.InvokeRequired)
            {
                this.panel1.BeginInvoke(new Action(() =>
                    {
                        if (anpr != null)
                        {
                            bmp = (Bitmap)ImageCapture.DrawToImage(this.panel1);
                            anpr.pushMedia(bmp, bmp.Width, bmp.Height);
                            bmp.Dispose();
                        }
                    }
                ));
            }
            else
            {
                // do nothing
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureWindow configureWindow = new ConfigureWindow();
            configureWindow.Owner = this;
            configureWindow.Init();
            configureWindow.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GBU ANPR Service " + Application.ProductVersion + "\n" + "For Gaenari Gas Station"
                + "\n\n" + "(C) 2015 GBU Datalinks Co. Ltd.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            // Call FindItemWithText with the contents of the textbox.
            ListViewItem foundItem = listView1.FindItemWithText(textBox_search.Text, true, 0, true);
            if (foundItem != null)
            {
                listView1.TopItem = foundItem;
                Console.WriteLine("found " + foundItem.Index);
            }
        }

    }
}
