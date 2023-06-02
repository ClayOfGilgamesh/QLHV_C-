using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DLL;

namespace WindowsFormsApp1
{
    public partial class KiLuat : Form
    {
        public KiLuat()
        {
            InitializeComponent();
        }
        void loadDS()
        {
            dgv_DSVIPHAM.DataSource= Chinhtri_BLL.Instance.Lay_DS_vipham_BLL(txt_TimKiem_HV.Text);
        }
        private void button_TK_Click(object sender, EventArgs e)
        {
            loadDS();
        }

        private void txt_TimKiem_HV_Enter(object sender, EventArgs e)
        {
            loadDS();
        }

       

        private void dgv_DSVIPHAM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) { return; }// neếu không có hành thì thôi
            DataGridViewRow row = dgv_DSVIPHAM.Rows[e.RowIndex];
            txt_mavipham.Text = row.Cells["mavipham"].Value.ToString();
            txt_MaHV.Text = row.Cells["MaHV"].Value.ToString();
            txt_hoten.Text = row.Cells["TenHV"].Value.ToString();
            txt_Lop.Text = row.Cells["Lop"].Value.ToString();
            txt_CapBac.Text = row.Cells["CapBac"].Value.ToString();
            txt_ViphamKL.Text = row.Cells["viphamkiluat"].Value.ToString();
            txt_thoigian.Text = row.Cells["thoigian"].Value.ToString();
            txt_mavipham.Text = row.Cells["mavipham"].Value.ToString();
            //có được cái mã hv 
            /// selec 
            /// 
        }

        List<TT_Basic_DTO> ku = new List<TT_Basic_DTO>();
        private void txt_MaHV_TextChanged(object sender, EventArgs e)
        {
            ku.Clear();
            ku = Chinhtri_BLL.Instance.Lay_DS_TT_basic_BLL(txt_MaHV.Text);
            if(ku != null && ku.Count > 0)
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

        private void button_sua_Click(object sender, EventArgs e)
        {
            if(txt_ViphamKL.Text=="" || txt_thoigian.Text=="" || txt_mavipham.Text=="")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được điền đầy đủ\n"+"Hoặc học viên không vi phạm");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là thông tin kỷ luật học viên này được sửa:\n";
                messs += "Mã Học Viên: " + txt_MaHV.Text + "\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Vi phạm: " + txt_ViphamKL.Text + "\n";
                messs += "Thời gian bắt đầu thi hành kỉ luật: " + Convert.ToDateTime(txt_thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo kỉ luật sửa mới", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Sua_kyluat_BLL(int.Parse(txt_mavipham.Text), int.Parse(txt_MaHV.Text),  txt_ViphamKL.Text, Convert.ToDateTime(txt_thoigian.Text).Date);
                    MessageBox.Show("Đã Sửa thành công!!");
                    loadDS();
                }
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (txt_ViphamKL.Text == "" || txt_thoigian.Text == "" || txt_CapBac.Text == "")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được điền đầy đủ");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là học viên này được thêm kỉ luật:\n";
                messs += "Mã Học Viên: " +txt_MaHV.Text+"\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Vi phạm: " + txt_ViphamKL.Text + "\n";
                messs += "Thời gian bắt đầu thi hành kỉ luật: " + Convert.ToDateTime(txt_thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo kỉ luật thêm mới", MessageBoxButtons.YesNoCancel);
                if(re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Them_kyluat_BLL(int.Parse(txt_MaHV.Text), txt_ViphamKL.Text, Convert.ToDateTime(txt_thoigian.Text).Date);
                    MessageBox.Show("Đã thêm thành công!!");
                    loadDS();
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (txt_ViphamKL.Text == "" || txt_thoigian.Text == "" || txt_mavipham.Text == "")
            {
                MessageBox.Show("Thông tin vi phạm học viên chưa được cung cấp đầy đủ");
            }
            else
            {
                string messs = "";
                messs += "Có chắc là học viên này được XÓA kỉ luật:\n";
                messs += "Mã Học Viên: " + txt_MaHV.Text + "\n";
                messs += "Tên Học Viên: " + txt_hoten.Text + "\n";
                messs += "Cấp bậc: " + txt_CapBac.Text + "\n";
                messs += "Lớp: " + txt_Lop.Text + "\n";
                messs += "Vi phạm: " + txt_ViphamKL.Text + "\n";
                messs += "Thời gian bắt đầu thi hành kỉ luật: " + Convert.ToDateTime(txt_thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo kỉ luật được xóa!!!", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    Chinhtri_BLL.Instance.Xoa_kyluat_BLL(int.Parse(txt_mavipham.Text));
                    MessageBox.Show("Đã XÓA thành công!!");
                    loadDS();
                }
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
