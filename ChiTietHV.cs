using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class ChiTietHV : Form
    {
        private string maHV;
        public ChiTietHV(string maHV)
        {

            InitializeComponent();
            this.maHV = maHV;
            if (maHV == "   ") { button_them.Visible = true; };
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void DGV_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DGV_NV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DGV_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button_them_Click(object sender, EventArgs e)
        {
           

        }

    }
}
