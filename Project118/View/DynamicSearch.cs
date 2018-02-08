using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project118.View
{
    public partial class DynamicSearch : Form
    {
        public DynamicSearch()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Controller.DataAccess dataAccess = new Controller.DataAccess();
            dataAccess.Connect();
            dataAccess.DynamciSearch(txtSearch.Text, dataGridView1);
            dataAccess.Disconnect();
        }

        private void ShowAll()
        {
            Controller.DataAccess dataAccess = new Controller.DataAccess();
            dataAccess.Connect();
            dataAccess.DynamciSearch(string.Empty, dataGridView1);
            dataAccess.Disconnect();
        }

        private void DynamicSearch_Load(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
