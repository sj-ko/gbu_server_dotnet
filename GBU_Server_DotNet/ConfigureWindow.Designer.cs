namespace GBU_Server_DotNet
{
    partial class ConfigureWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Configure_button_OK = new System.Windows.Forms.Button();
            this.Configure_button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Configure_textbox_rtspurl = new System.Windows.Forms.TextBox();
            this.Configure_textbox_camID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Configure_button_OK
            // 
            this.Configure_button_OK.Location = new System.Drawing.Point(135, 279);
            this.Configure_button_OK.Name = "Configure_button_OK";
            this.Configure_button_OK.Size = new System.Drawing.Size(75, 23);
            this.Configure_button_OK.TabIndex = 0;
            this.Configure_button_OK.Text = "OK";
            this.Configure_button_OK.UseVisualStyleBackColor = true;
            this.Configure_button_OK.Click += new System.EventHandler(this.Configure_button_OK_Click);
            // 
            // Configure_button_Cancel
            // 
            this.Configure_button_Cancel.Location = new System.Drawing.Point(228, 279);
            this.Configure_button_Cancel.Name = "Configure_button_Cancel";
            this.Configure_button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Configure_button_Cancel.TabIndex = 1;
            this.Configure_button_Cancel.Text = "Cancel";
            this.Configure_button_Cancel.UseVisualStyleBackColor = true;
            this.Configure_button_Cancel.Click += new System.EventHandler(this.Configure_button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "RTSP URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Camera ID";
            // 
            // Configure_textbox_rtspurl
            // 
            this.Configure_textbox_rtspurl.Location = new System.Drawing.Point(99, 48);
            this.Configure_textbox_rtspurl.Name = "Configure_textbox_rtspurl";
            this.Configure_textbox_rtspurl.Size = new System.Drawing.Size(183, 21);
            this.Configure_textbox_rtspurl.TabIndex = 4;
            // 
            // Configure_textbox_camID
            // 
            this.Configure_textbox_camID.Location = new System.Drawing.Point(99, 75);
            this.Configure_textbox_camID.Name = "Configure_textbox_camID";
            this.Configure_textbox_camID.Size = new System.Drawing.Size(183, 21);
            this.Configure_textbox_camID.TabIndex = 5;
            // 
            // ConfigureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 314);
            this.Controls.Add(this.Configure_textbox_camID);
            this.Controls.Add(this.Configure_textbox_rtspurl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Configure_button_Cancel);
            this.Controls.Add(this.Configure_button_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Configure_button_OK;
        private System.Windows.Forms.Button Configure_button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Configure_textbox_rtspurl;
        private System.Windows.Forms.TextBox Configure_textbox_camID;
    }
}