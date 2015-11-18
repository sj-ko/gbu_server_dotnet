using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBU_Server_DotNet
{
    public partial class ConfigureWindow : Form
    {
        public ConfigureWindow()
        {
            InitializeComponent();
        }

        public void Init()
        {
            Form1 form = (Form1)this.Owner;
            Configure_textbox_camID.Text = Convert.ToString(form.camera.camID, 10);
            Configure_textbox_rtspurl.Text = form.camera.camURL;
        }

        private void Configure_button_OK_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.camera.camID = Convert.ToInt32(Configure_textbox_camID.Text, 10);
            form.camera.camURL = Configure_textbox_rtspurl.Text;
            this.Close();
        }

        private void Configure_button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
