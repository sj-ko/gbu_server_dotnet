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
    public partial class Form1 : Form
    {
        MediaPlayer player;
        ANPR anpr;


        public Form1()
        {
            InitializeComponent();
            anpr = new ANPR();
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            string path = "rtsp://admin:admin@192.168.0.62/media/video1";
            //string path = "C:\\업무문서\\ppt\\MicroModule 아키텍처.wmv";
            player = new MediaPlayer(".\\plugins");
           
            player.SetRenderWindow((int)this.panel1.Handle);
            player.PlayStream(path, 1920, 1080);
            //player.PlayFile(path);

            panel1.Paint += panel1_Paint;
        }

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height);

            // In order to use DrawToBitmap, the image must have an INITIAL image. 
            // Not sure why. Perhaps it uses this initial image as a mask??? Dunno.
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Color.Yellow);
            }

            bmp = (Bitmap)ImageCapture.DrawToImage(this.panel1);
            anpr.getValidPlate2(bmp, bmp.Width, bmp.Height);

            //bmp.Save("c:\\save.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            bmp.Dispose();
        }

    }
}
