using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Khenthuong_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private int makhenthuong;
        private string khenthuong;
        private DateTime thoigian;

        public Khenthuong_DTO(int mahv, string tenhv, string quanham, string tenLCN, int makhenthuong, string khenthuong, DateTime thoigian)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.quanham = quanham;
            this.tenLCN = tenLCN;
            this.makhenthuong = makhenthuong;
            this.khenthuong = khenthuong;
            this.thoigian = thoigian;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }
        public int Makhenthuong { get => makhenthuong; set => makhenthuong = value; }
        public string Khenthuong { get => khenthuong; set => khenthuong = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }

        public Khenthuong_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();
            makhenthuong = int.Parse(v["Ma"].ToString());
            khenthuong = v["LoaiKhenThuong"].ToString();
            thoigian = Convert.ToDateTime(v["ThoiGian"].ToString());
            

        }
    }
}
