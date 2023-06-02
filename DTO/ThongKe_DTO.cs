using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public  class ThongKe_DTO
    {
    }

    //-------------ĐIỂM--------------
    public class ThongKe_Diem_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private int ky;
        private int nam;
        private float diem;

        public ThongKe_Diem_DTO(int mahv, string tenhv, string quanham, string tenLCN, int ky, int nam, float diem)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.quanham = quanham;
            this.tenLCN = tenLCN;
            this.ky = ky;
            this.nam = nam;
            this.diem = diem;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }
        public int Ky { get => ky; set => ky = value; }
        public int Nam { get => nam; set => nam = value; }
        public float Diem { get => diem; set => diem = value; }

        public ThongKe_Diem_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();
            ky = int.Parse(v["Ky"].ToString());
            nam = int.Parse(v["Nam"].ToString());
            diem = float.Parse(v["Diem"].ToString());
        }
    }

    //-------------THỂ LỰC--------------
    public class ThongKe_TheLuc_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private int dot;
        private int nam;
        private string ketqua;

        public ThongKe_TheLuc_DTO(int mahv, string tenhv, string quanham, string tenLCN, int dot, int nam, string ketqua)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.quanham = quanham;
            this.tenLCN = tenLCN;
            this.dot = dot;
            this.nam = nam;
            this.ketqua = ketqua;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }
        public int Dot { get => dot; set => dot = value; }
        public int Nam { get => nam; set => nam = value; }
        public string Ketqua { get => ketqua; set => ketqua = value; }

        public ThongKe_TheLuc_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();
            dot= int.Parse(v["Dot"].ToString());
            nam= int.Parse(v["Nam"].ToString());
            ketqua= v["KetQua"].ToString();
        }
    }

    //---------------------------ĐIỀU LỆNH--------
    public class ThongKe_DieuLenh_DTO
    {

    }

    //-------------------ĐẢNG----------------------
    public class ThongKe_Dang_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private string trangthaidang;
        private DateTime thoigiandang;

        public ThongKe_Dang_DTO(int mahv, string tenhv, string quanham, string tenLCN, string trangthaidang, DateTime thoigiandang)
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

        public ThongKe_Dang_DTO(DataRow v)
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
        }
    }
}
