namespace GBU_Server_DotNet
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.anprResultThumbnail = new System.Windows.Forms.PictureBox();
            this.textBox_anpr = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anprResultThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraListToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cameraListToolStripMenuItem
            // 
            this.cameraListToolStripMenuItem.Name = "cameraListToolStripMenuItem";
            this.cameraListToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cameraListToolStripMenuItem.Text = "Camera List";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.configureToolStripMenuItem.Text = "Options";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 295);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(12, 344);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(82, 23);
            this.Btn_Connect.TabIndex = 2;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Location = new System.Drawing.Point(111, 344);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(87, 23);
            this.Btn_Disconnect.TabIndex = 3;
            this.Btn_Disconnect.Text = "Disconnect";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.Btn_Disconnect_Click);
            // 
            // anprResultThumbnail
            // 
            this.anprResultThumbnail.Location = new System.Drawing.Point(471, 43);
            this.anprResultThumbnail.Name = "anprResultThumbnail";
            this.anprResultThumbnail.Size = new System.Drawing.Size(294, 234);
            this.anprResultThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anprResultThumbnail.TabIndex = 4;
            this.anprResultThumbnail.TabStop = false;
            // 
            // textBox_anpr
            // 
            this.textBox_anpr.Enabled = false;
            this.textBox_anpr.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_anpr.Location = new System.Drawing.Point(588, 283);
            this.textBox_anpr.Name = "textBox_anpr";
            this.textBox_anpr.Size = new System.Drawing.Size(177, 35);
            this.textBox_anpr.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 398);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 130);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(665, 371);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 21);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_anpr);
            this.Controls.Add(this.anprResultThumbnail);
            this.Controls.Add(this.Btn_Disconnect);
            this.Controls.Add(this.Btn_Connect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gaenari ANPR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anprResultThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.PictureBox anprResultThumbnail;
        private System.Windows.Forms.TextBox textBox_anpr;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
    }
}

