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
        private Database dbManager = new Database();

        public struct PLATE_FOUND
        {
            public int id;
            public int cam;
            public DateTime dateTime;
            public string plateStr;
            public Image snapshot;
        };

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
            DataTable result = new DataTable();

            Search_listView1.Items.Clear();
            dbManager.SearchPlate(search_textBox_search.Text, ref result);

            foreach (DataRow dr in result.Rows)
            {
                string[] itemStr = { Convert.ToString(dr["camId"]), Convert.ToDateTime(dr["dateTime"]).ToString(), Convert.ToString(dr["plate"]) };
                ListViewItem item = new ListViewItem(itemStr);
                Search_listView1.Items.Add(item);
            }

        }

        private void search_textBox_search_TextChanged(object sender, EventArgs e)
        {
            // to be added...
        }



    }
}
