using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class ChinhTri_DAO
    {
        public static ChinhTri_DAO instance;
        public static ChinhTri_DAO Instance
        {
            get { if (instance == null) instance = new ChinhTri_DAO(); return instance; }
            private set { instance = value; }
        }
        //----------------------------------------------------------------------------
        //==>kiluat
        public DataTable DS_Vipham_KyLuat_DAO(string key)
        {
            object[] thamtri = { key };
            DataTable ku = dataaccess.Instance.TruyVan("EXEC Lay_DS_ViPham_KiLuat @tukhoa ",thamtri);
            return ku;
        }

        public DataTable DS_HV_Coban_DAO(string key)
        {
            object[] thamtri = { key };
            DataTable ku = dataaccess.Instance.TruyVan("EXEC LayTT_Coban_HV @id ", thamtri);
            return ku;
        }

        //thêm kĩ luật
        public int Them_kiluat_DAO(int MAHV, string vipham, DateTime ku)
        {
            object[] thamtri = { MAHV,vipham,ku };
            dataaccess.Instance.TruyVan("EXEC Them_viphamkiluat @id , @vipham , @thoigian ", thamtri);
            return 1;
        }

        //sửa kĩ luật
        public int Sua_kiluat_DAO(int MAvipham, int mahv, string vipham, DateTime ku)
        {
            object[] thamtri = { MAvipham, mahv, vipham, ku };
            dataaccess.Instance.TruyVan("EXEC Sua_viphamkiluat @id , @mahv , @vipham , @thoigian ", thamtri);
            return 1;
        }

        //xóa kĩ luật
        public int Xoa_kiluat_DAO(int key)
        {
            object[] thamtri = { key};
            dataaccess.Instance.TruyVan("EXEC Xoa_viphamkyluat @id  ", thamtri);
            return 1;
        }

        //--------------------------khenthuong-------------------------------->


        public DataTable DS_HV_Khenthuong_DAO(string key)
        {
            object[] thamtri = { key };
            DataTable ku = dataaccess.Instance.TruyVan("EXEC Lay_DS_Khenthuong @tukhoa ", thamtri);
            return ku;
        }
        //thêm khen thưởng
        public int Them_Khenthuong_DAO(int maHV, string khenthuong, DateTime ngay)
        {
            object[] thamtri = { maHV,khenthuong,ngay };
            dataaccess.Instance.TruyVan("EXEC Them_khenthuong @maHV , @tenkt , @ngay  ", thamtri);
            return 1;
        }

        //sửa khen thương
        public int Sua_Khenthuong_DAO(int maKT, int mahv,string khenthuong, DateTime thoigian)
        {
            object[] thamtri = { maKT,mahv, khenthuong,thoigian };
            dataaccess.Instance.TruyVan("EXEC Sua_Khenthuong @makt , @mahv , @khenthuong , @thoigian  ", thamtri);
            return 1;
        }

        //Xóa khen thưởng
        public int Xoa_Khenthuong_DAO(int id)
        {
            object[] thamtri = { id };
            dataaccess.Instance.TruyVan("EXEC Xoa_khenthuong @id ", thamtri);
            return 1;
        }


        //================================đảng======================================>

        //lấy danh sách đảng
        public DataTable DS_HV_Dang_DAO(string key, int nut)
        {
            object[] thamtri = { key,nut };
            DataTable ku = dataaccess.Instance.TruyVan("EXEC Lay_DS_HosoDang @tukhoa , @nut", thamtri);
            return ku;
        }

        //update đảng
        public int Capnhat_Dang_DAO(int mahv , int TTDang , DateTime timee)
        {
            object[] thamtri = { mahv,TTDang,timee };
            dataaccess.Instance.TruyVan("EXEC Sua_HosoDang @maHV , @TT_dang , @thoigian ", thamtri);
            return 1;
        }



    }
}
