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
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        public void Init()
        {
            MainForm form = (MainForm)this.Owner;

            Search_listView1.View = View.Details;
            Search_listView1.FullRowSelect = true;
            Search_listView1.GridLines = true;

            Search_listView1.Columns.Add("Camera ID", 90, HorizontalAlignment.Left);
            Search_listView1.Columns.Add("Data & Time", 140, HorizontalAlignment.Left);
            Search_listView1.Columns.Add("Plate String", 100, HorizontalAlignment.Left);
        }

        private void Search_button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_button_search_Click(object sender, EventArgs e)
        {
            MainForm form = (MainForm)this.Owner;

            Search_listView1.BeginUpdate();


            if (search_textBox_search.Text != "")
            {
                for (int i = form.listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = form.listView1.Items[i];
                    if (item.SubItems[2].Text.Contains(search_textBox_search.Text))
                    {
                        //item.BackColor = SystemColors.Highlight;
                        //item.ForeColor = SystemColors.HighlightText;
                        Search_listView1.Items.Add(item);
                    }
                }

            }

            Search_listView1.EndUpdate();
        }

        private void search_textBox_search_TextChanged(object sender, EventArgs e)
        {
            // to be added...
        }



    }
}
