using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class KhenThuong : Form
    {
        public KhenThuong()
        {
            InitializeComponent();
        }

        private void dgv_khenthuong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) { return; }// neếu không có hành thì thôi
            DataGridViewRow row = dgv_khenthuong.Rows[e.RowIndex];
            txt_makhenthuong.Text = row.Cells["makhenthuong"].Value.ToString();
            txt_Ma.Text = row.Cells["MaHV"].Value.ToString();
            txt_hoten.Text = row.Cells["TenHV"].Value.ToString();
            txt_Lop.Text = row.Cells["Lop"].Value.ToString();
            txt_CapBac.Text = row.Cells["CapBac"].Value.ToString();
            txt_tenkhenthuong.Text = row.Cells["tenkhenthuong"].Value.ToString();
            txt_Thoigian.Text = row.Cells["thoigian"].Value.ToString();
            txt_makhenthuong.Text = row.Cells["makhenthuong"].Value.ToString();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (txt_CapBac.Text == "" || txt_Thoigian.Text == "" || txt_tenkhenthuong.Text=="")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được điền đầy đủ\n" + "Hoặc học viên không vi phạm");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là thông tin khen thưởng học viên này được thêm:\n";
                messs += "Mã Học Viên: " + txt_Ma.Text + "\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Tên khen thưởng: " + txt_tenkhenthuong.Text + "\n";
                messs += "Ngày quyết định khen thưởng:"  + Convert.ToDateTime(txt_Thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo khen thưởng học viên thêm mới", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Them_khenthuong_BLL(int.Parse(txt_Ma.Text),txt_tenkhenthuong.Text, Convert.ToDateTime(txt_Thoigian.Text).Date);
                    MessageBox.Show("Đã Thêm thành công!!");
                    button_TK_Click(sender, e);
                }
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (txt_CapBac.Text == "" || txt_Thoigian.Text == "" || txt_tenkhenthuong.Text == "" || txt_makhenthuong.Text=="")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được điền đầy đủ\n" + "Hoặc học viên không vi phạm");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là thông tin khen thưởng học viên này được sửa:\n";
                messs += "Mã Học Viên: " + txt_Ma.Text + "\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Tên khen thưởng: " + txt_tenkhenthuong.Text + "\n";
                messs += "Ngày quyết định khen thưởng:" + Convert.ToDateTime(txt_Thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo khen thưởng học viên sửa mới", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Sua_khenthuong_BLL(int.Parse(txt_makhenthuong.Text),int.Parse(txt_Ma.Text), txt_tenkhenthuong.Text, Convert.ToDateTime(txt_Thoigian.Text).Date);
                    MessageBox.Show("Đã Sửa thành công!!");
                    button_TK_Click(sender, e);
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (txt_CapBac.Text == "" || txt_Thoigian.Text == "" || txt_tenkhenthuong.Text == "" || txt_makhenthuong.Text == "")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được điền đầy đủ\n" + "Hoặc học viên không vi phạm");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là thông tin khen thưởng học viên này được XÓA:\n";
                messs += "Mã Học Viên: " + txt_Ma.Text + "\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Tên khen thưởng: " + txt_tenkhenthuong.Text + "\n";
                messs += "Ngày quyết định khen thưởng:" + Convert.ToDateTime(txt_Thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo khen thưởng học viên xóa", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Xoa_khenthuong_BLL(int.Parse(txt_makhenthuong.Text));
                    MessageBox.Show("Đã XÓA thành công!!");
                    button_TK_Click(sender, e);
                }
            }
        }
        private void button_TK_Click(object sender, EventArgs e)
        {
            dgv_khenthuong.DataSource = Chinhtri_BLL.Instance.Lay_DS_HV_Khenthuong_BLL(txt_TimKiem_HV.Text);
        }
        List<TT_Basic_DTO> ku=new List<TT_Basic_DTO>();
        private void txt_Ma_TextChanged(object sender, EventArgs e)
        {
            ku.Clear();
            ku = Chinhtri_BLL.Instance.Lay_DS_TT_basic_BLL(txt_Ma.Text);
            if (ku != null && ku.Count > 0)
            {
                txt_hoten.Text = ku[0].Tenhv.ToString();
                txt_CapBac.Text = ku[0].Quanham.ToString();
                txt_Lop.Text = ku[0].TenLCN.ToString();
            }
            else
            {
                txt_hoten.Text = "";
                txt_CapBac.Text = "";
                txt_Lop.Text = "";
            }
        }
    }
}
