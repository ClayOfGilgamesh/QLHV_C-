using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class HosoDang_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private string trangthaidang;
        private DateTime thoigiandang;

        public HosoDang_DTO(int mahv, string tenhv, string quanham, string tenLCN, string trangthaidang, DateTime thoigiandang)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.quanham = quanham;
            this.tenLCN = tenLCN;
            this.trangthaidang = trangthaidang;
            this.thoigiandang = thoigiandang;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }
        public string Trangthaidang { get => trangthaidang; set => trangthaidang = value; }
        public DateTime Thoigiandang { get => thoigiandang; set => thoigiandang = value; }

        public HosoDang_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();
            trangthaidang = v["Trangthaidang"].ToString();

            if (!string.IsNullOrEmpty(v["ThoiGian_Dang"].ToString()))
            {
                thoigiandang = Convert.ToDateTime(v["ThoiGian_Dang"].ToString());
            }
           

            //// Định dạng ngày tháng tương ứng với chuỗi "ThoiGian_Dang"
            //string dinhDangNgayThang = "yyyy-MM-dd"; // Định dạng tuỳ thuộc vào chuỗi thời gian
            //DateTime.TryParseExact(v["ThoiGian_Dang"].ToString(), dinhDangNgayThang, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoigiandang);
        }
        


    }
}
