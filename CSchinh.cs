using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CSchinh : Form
    {
        public CSchinh()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)// fomr con trong form cha 
        {
            if (currentFormChild != null)
            {
                currentFormChild.FormClosed -= ChildFormClosedEventHandler; // Gỡ bỏ sự kiện FormClosed của form con hiện tại
                currentFormChild.Close();
                currentFormChild = null;
            }
            currentFormChild = childForm;
            currentFormChild.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Layout_CSchinh.Controls.Add(childForm);
            Layout_CSchinh.Tag = childForm;
            childForm.BringToFront();
            childForm.FormClosed += ChildFormClosedEventHandler; // Gán sự kiện FormClosed cho form con mới
            childForm.Show();
        }
        private void ChildFormClosedEventHandler(object sender, FormClosedEventArgs e)
        {
            currentFormChild = null; // Không có form con nào đang mở
        }
        private void Button_NV_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new ChiTietHV());
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
        }

    



        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        

        //nhần button sức khỏe 
        private void SucKhoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SucKhoe());
        }

        //nhấn button bảo hiểm y tế 
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoHiem_HV());
        }

        //nhấn button hồ sơ đảng 
        private void hồSơĐảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HosoDang());
        }

        //nhấn button khen thưởng 
        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhenThuong());
        }

        //nhấn button kỷ luật 
        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KiLuat());
        }
        ////nhấn button điều lệnh 
        private void điềuLệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DieuLenh());
        }

        //nhấn button quân số 
        private void quânSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hocvien_VangMat());
        }

        //nhấn button điểm
        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Diem_HV());
        }

        //nhấn button thể lực 
        private void thểLựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TheLuc_HV());
        }

        //nhấn button thống kê học tập 
        private void thốngKêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SucKhoe());
        }

        //nhấn button thống kê chính trị 
        private void thuChiKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SucKhoe());
        }

        private void pnDS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiTietHV("   "));
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiTietHV(tbMaHV.Text));
        }

        private void toolStripMenuI_HV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CSchinh());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
