using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Viphamkiluat_DTO
    {
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;
        private int mavipham;
        private string viphamkyluat;
        private DateTime thoigian;

        public Viphamkiluat_DTO(int mahv, string tenhv, string quanham, string tenLCN, int mavp,string viphamkyluat, DateTime thoigian)
        {
            this.Mahv = mahv;
            this.Tenhv = tenhv;
            this.Quanham = quanham;
            this.TenLCN = tenLCN;
            this.mavipham = mavp;
            this.Viphamkyluat = viphamkyluat;
            this.Thoigian = thoigian;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }
        public string Viphamkyluat { get => viphamkyluat; set => viphamkyluat = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
        public int Mavipham { get => mavipham; set => mavipham = value; }

        public Viphamkiluat_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();
            viphamkyluat = v["ViPhamKyLuat"].ToString();
            thoigian =Convert.ToDateTime( v["ThoiGian"].ToString());
            mavipham = int.Parse(v["Ma"].ToString());

        }
    }

    public class TT_Basic_DTO
    {
        //HV.MaHV,HV.TenHV, HV.QuanHam,LCN.TenLCN
        private int mahv;
        private string tenhv;
        private string quanham;
        private string tenLCN;

        public TT_Basic_DTO(int mahv, string tenhv, string quanham, string tenLCN)
        {
            this.mahv = mahv;
            this.tenhv = tenhv;
            this.quanham = quanham;
            this.tenLCN = tenLCN;
        }

        public int Mahv { get => mahv; set => mahv = value; }
        public string Tenhv { get => tenhv; set => tenhv = value; }
        public string Quanham { get => quanham; set => quanham = value; }
        public string TenLCN { get => tenLCN; set => tenLCN = value; }

        public TT_Basic_DTO(DataRow v)
        {
            mahv = int.Parse(v["MaHV"].ToString());
            tenhv = v["TenHV"].ToString();
            quanham = v["QuanHam"].ToString();
            tenLCN = v["TenLCN"].ToString();

        }
    }

}
