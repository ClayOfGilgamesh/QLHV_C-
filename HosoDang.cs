using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DLL;
using WindowsFormsApp1.DTO;
namespace WindowsFormsApp1
{
    public partial class HosoDang : Form
    {
        public HosoDang()
        {
            InitializeComponent();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_TK_Click(object sender, EventArgs e)
        {
            int k=cmb_DS_Dang.SelectedIndex;
            if (k == -1) k = 3;
            List<HosoDang_DTO> ku = Chinhtri_BLL.Instance.Lay_DS_Dang_BLL(txt_TimKiem_HV.Text, k);
           
            DGV_HoSoDang.DataSource = ku;
            //when HV.Dang = 0 then N'Chưa kết nạp'
            //when HV.Dang = 1 then N'Dự bị'
            //when HV.Dang = 2 then N'Chính thức'
        }

        private void DGV_HoSoDang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int countChecked = 0;
            // Lặp qua các hàng trong DataGridView
            foreach (DataGridViewRow x in DGV_HoSoDang.Rows)
            {
                // Kiểm tra giá trị của ô kiểm trong hàng hiện tại
                //bool isChecked = (bool)x.Cells[0].Value;
                bool isChecked = (bool)(x.Cells[0]?.Value ?? false);
                // Nếu ô kiểm được chọn, tăng biến đếm lên 1
                if (isChecked)
                {
                    countChecked++;
                }
            }
            if (countChecked == 0)
            {
                if (e.RowIndex == -1) { return; }// neếu không có hành thì thôi
                DataGridViewRow row = DGV_HoSoDang.Rows[e.RowIndex];

                txt_Ma.Text = row.Cells["MaHV"].Value.ToString();
                txt_hoten.Text = row.Cells["TenHV"].Value.ToString();
                txt_Lop.Text = row.Cells["Lop"].Value.ToString();
                txt_CapBac.Text = row.Cells["CapBac"].Value.ToString();

                if (row.Cells["thoigian"].Value.ToString() == "1/1/0001 12:00:00 AM")
                {
                    txt_thoigian.Text = DateTimePicker.MinimumDateTime.ToString();
                }
                else
                {
                    txt_thoigian.Text = row.Cells["thoigian"].Value.ToString();
                }


                string k = row.Cells["ttdang"].Value.ToString();
                int index = cmb_chucvuDang.Items.IndexOf(k);
                cmb_chucvuDang.SelectedIndex = index;
            }
            else
            {
                txt_Ma.Text = "";
                txt_hoten.Text = "";
                txt_Lop.Text = "";
                txt_CapBac.Text = "";
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            int countChecked = 0;
            // Lặp qua các hàng trong DataGridView
            foreach (DataGridViewRow x in DGV_HoSoDang.Rows)
            {
                // Kiểm tra giá trị của ô kiểm trong hàng hiện tại
                //bool isChecked = (bool)x.Cells[0].Value;
                bool isChecked = (bool)(x.Cells[0]?.Value ?? false);
                // Nếu ô kiểm được chọn, tăng biến đếm lên 1
                if (isChecked)
                {
                    countChecked++;
                }
            }
            if (countChecked==0)
            {
                MessageBox.Show("Thông tin đảng học viên chưa được cung cấp đủ\n");
            }
            else
            {
                string messs = "Thông tin đảng cần cập nhật là:\n";
                messs += "Tình trạng Đảng: " + cmb_chucvuDang.Text + "\n";
                if(cmb_chucvuDang.SelectedIndex!=0)
                    messs += "Thời gian chuyển trạng thái Đảng viên: " + Convert.ToDateTime(txt_thoigian.Text).Date + "\n";
                DialogResult re = MessageBox.Show(messs, "Thông báo cập nhật thông tin Đảng!!!", MessageBoxButtons.YesNoCancel);
                if (re == DialogResult.Yes)
                {
                    int ttdang=cmb_chucvuDang.SelectedIndex;
                    DateTime ku=Convert.ToDateTime(txt_thoigian.Text).Date;
                    foreach (DataGridViewRow x in DGV_HoSoDang.Rows)
                    {
                        // Kiểm tra giá trị của ô kiểm trong hàng hiện tại
                        //bool isChecked = (bool)x.Cells[0].Value;
                        bool isChecked = (bool)(x.Cells[0]?.Value ?? false);
                        // Nếu ô kiểm được chọn, tăng biến đếm lên 1
                        if (isChecked)
                        {
                            int mnhv=int.Parse(x.Cells["MaHV"].Value.ToString());
                            Chinhtri_BLL.Instance.Capnhat_dang_BLL(mnhv, ttdang, ku);
                        }
                    }
                    MessageBox.Show("Đã Sửa thành công!!");
                }
            }
        }
    }
}
