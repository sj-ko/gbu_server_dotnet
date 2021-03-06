﻿namespace GBU_Server_DotNet
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
            this.Configure_croparea = new System.Windows.Forms.PictureBox();
            this.Configure_groupBox1 = new System.Windows.Forms.GroupBox();
            this.Configure_groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Configure_UpDown_CropX = new System.Windows.Forms.NumericUpDown();
            this.Configure_UpDown_CropY = new System.Windows.Forms.NumericUpDown();
            this.Configure_UpDown_CropWidth = new System.Windows.Forms.NumericUpDown();
            this.Configure_UpDown_CropHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_croparea)).BeginInit();
            this.Configure_groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Configure_button_OK
            // 
            this.Configure_button_OK.Location = new System.Drawing.Point(294, 500);
            this.Configure_button_OK.Name = "Configure_button_OK";
            this.Configure_button_OK.Size = new System.Drawing.Size(75, 23);
            this.Configure_button_OK.TabIndex = 0;
            this.Configure_button_OK.Text = "OK";
            this.Configure_button_OK.UseVisualStyleBackColor = true;
            this.Configure_button_OK.Click += new System.EventHandler(this.Configure_button_OK_Click);
            // 
            // Configure_button_Cancel
            // 
            this.Configure_button_Cancel.Location = new System.Drawing.Point(385, 500);
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
            this.Configure_textbox_rtspurl.Size = new System.Drawing.Size(343, 21);
            this.Configure_textbox_rtspurl.TabIndex = 4;
            // 
            // Configure_textbox_camID
            // 
            this.Configure_textbox_camID.Location = new System.Drawing.Point(99, 75);
            this.Configure_textbox_camID.Name = "Configure_textbox_camID";
            this.Configure_textbox_camID.Size = new System.Drawing.Size(132, 21);
            this.Configure_textbox_camID.TabIndex = 5;
            // 
            // Configure_croparea
            // 
            this.Configure_croparea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Configure_croparea.Location = new System.Drawing.Point(31, 168);
            this.Configure_croparea.Name = "Configure_croparea";
            this.Configure_croparea.Size = new System.Drawing.Size(480, 270);
            this.Configure_croparea.TabIndex = 6;
            this.Configure_croparea.TabStop = false;
            this.Configure_croparea.Click += new System.EventHandler(this.Configure_croparea_Click);
            this.Configure_croparea.Paint += new System.Windows.Forms.PaintEventHandler(this.Configure_croparea_Paint);
            this.Configure_croparea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Configure_croparea_MouseDown);
            this.Configure_croparea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Configure_croparea_MouseMove);
            this.Configure_croparea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Configure_croparea_MouseUp);
            // 
            // Configure_groupBox1
            // 
            this.Configure_groupBox1.Location = new System.Drawing.Point(12, 12);
            this.Configure_groupBox1.Name = "Configure_groupBox1";
            this.Configure_groupBox1.Size = new System.Drawing.Size(525, 114);
            this.Configure_groupBox1.TabIndex = 7;
            this.Configure_groupBox1.TabStop = false;
            this.Configure_groupBox1.Text = "Camera Connection";
            // 
            // Configure_groupBox2
            // 
            this.Configure_groupBox2.Controls.Add(this.Configure_UpDown_CropHeight);
            this.Configure_groupBox2.Controls.Add(this.Configure_UpDown_CropWidth);
            this.Configure_groupBox2.Controls.Add(this.Configure_UpDown_CropY);
            this.Configure_groupBox2.Controls.Add(this.Configure_UpDown_CropX);
            this.Configure_groupBox2.Controls.Add(this.label6);
            this.Configure_groupBox2.Controls.Add(this.label5);
            this.Configure_groupBox2.Controls.Add(this.label4);
            this.Configure_groupBox2.Controls.Add(this.label3);
            this.Configure_groupBox2.Location = new System.Drawing.Point(12, 149);
            this.Configure_groupBox2.Name = "Configure_groupBox2";
            this.Configure_groupBox2.Size = new System.Drawing.Size(525, 332);
            this.Configure_groupBox2.TabIndex = 8;
            this.Configure_groupBox2.TabStop = false;
            this.Configure_groupBox2.Text = "Crop area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "CropX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "CropY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "CropWidth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "CropHeight";
            // 
            // Configure_UpDown_CropX
            // 
            this.Configure_UpDown_CropX.Location = new System.Drawing.Point(59, 302);
            this.Configure_UpDown_CropX.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.Configure_UpDown_CropX.Name = "Configure_UpDown_CropX";
            this.Configure_UpDown_CropX.Size = new System.Drawing.Size(55, 21);
            this.Configure_UpDown_CropX.TabIndex = 13;
            this.Configure_UpDown_CropX.ValueChanged += new System.EventHandler(this.Configure_UpDown_CropX_ValueChanged);
            // 
            // Configure_UpDown_CropY
            // 
            this.Configure_UpDown_CropY.Location = new System.Drawing.Point(173, 302);
            this.Configure_UpDown_CropY.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.Configure_UpDown_CropY.Name = "Configure_UpDown_CropY";
            this.Configure_UpDown_CropY.Size = new System.Drawing.Size(57, 21);
            this.Configure_UpDown_CropY.TabIndex = 14;
            this.Configure_UpDown_CropY.ValueChanged += new System.EventHandler(this.Configure_UpDown_CropY_ValueChanged);
            // 
            // Configure_UpDown_CropWidth
            // 
            this.Configure_UpDown_CropWidth.Location = new System.Drawing.Point(315, 302);
            this.Configure_UpDown_CropWidth.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.Configure_UpDown_CropWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Configure_UpDown_CropWidth.Name = "Configure_UpDown_CropWidth";
            this.Configure_UpDown_CropWidth.Size = new System.Drawing.Size(57, 21);
            this.Configure_UpDown_CropWidth.TabIndex = 15;
            this.Configure_UpDown_CropWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Configure_UpDown_CropWidth.ValueChanged += new System.EventHandler(this.Configure_UpDown_CropWidth_ValueChanged);
            // 
            // Configure_UpDown_CropHeight
            // 
            this.Configure_UpDown_CropHeight.Location = new System.Drawing.Point(461, 302);
            this.Configure_UpDown_CropHeight.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.Configure_UpDown_CropHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Configure_UpDown_CropHeight.Name = "Configure_UpDown_CropHeight";
            this.Configure_UpDown_CropHeight.Size = new System.Drawing.Size(57, 21);
            this.Configure_UpDown_CropHeight.TabIndex = 16;
            this.Configure_UpDown_CropHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Configure_UpDown_CropHeight.ValueChanged += new System.EventHandler(this.Configure_UpDown_CropHeight_ValueChanged);
            // 
            // ConfigureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 535);
            this.Controls.Add(this.Configure_croparea);
            this.Controls.Add(this.Configure_textbox_camID);
            this.Controls.Add(this.Configure_textbox_rtspurl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Configure_button_Cancel);
            this.Controls.Add(this.Configure_button_OK);
            this.Controls.Add(this.Configure_groupBox1);
            this.Controls.Add(this.Configure_groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigureWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.Configure_croparea)).EndInit();
            this.Configure_groupBox2.ResumeLayout(false);
            this.Configure_groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Configure_UpDown_CropHeight)).EndInit();
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
        private System.Windows.Forms.PictureBox Configure_croparea;
        private System.Windows.Forms.GroupBox Configure_groupBox1;
        private System.Windows.Forms.GroupBox Configure_groupBox2;
        private System.Windows.Forms.NumericUpDown Configure_UpDown_CropHeight;
        private System.Windows.Forms.NumericUpDown Configure_UpDown_CropWidth;
        private System.Windows.Forms.NumericUpDown Configure_UpDown_CropY;
        private System.Windows.Forms.NumericUpDown Configure_UpDown_CropX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}