using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DLL
{
    public class Chinhtri_BLL
    {
        public static Chinhtri_BLL instance;
        public static Chinhtri_BLL Instance
        {
            get { if (instance == null) instance = new Chinhtri_BLL(); return instance; }
            private set { instance = value; }
        }
        //----------------------------------------------------------------------------
        //=================>kỉ luật

        public List<Viphamkiluat_DTO> Lay_DS_vipham_BLL(string key)
        {
            DataTable ku= ChinhTri_DAO.Instance.DS_Vipham_KyLuat_DAO(key);
            List<Viphamkiluat_DTO> vp = new List<Viphamkiluat_DTO>();
            if (ku != null)
            {
                foreach (DataRow dr in ku.Rows)
                {
                    Viphamkiluat_DTO i = new Viphamkiluat_DTO(dr);
                    vp.Add(i);
                }
            }
            return vp;
        }


        public List<TT_Basic_DTO> Lay_DS_TT_basic_BLL(string key)
        {
            
                DataTable ku = ChinhTri_DAO.Instance.DS_HV_Coban_DAO(key);
                List<TT_Basic_DTO> vp = new List<TT_Basic_DTO>();
                if (ku!=null)
                {
                    foreach (DataRow dr in ku.Rows)
                    {
                        TT_Basic_DTO i = new TT_Basic_DTO(dr);
                        vp.Add(i);
                    }
                }
                return vp;
        }

        //tthêm kỉ luật học viên 
        public int Them_kyluat_BLL(int mahv, string vipham, DateTime ngay)
        {
            ChinhTri_DAO.Instance.Them_kiluat_DAO(mahv, vipham, ngay);  
            return 1;
        }

        ////sửa kỉ luật học viên 
        ///

        public int Sua_kyluat_BLL(int makl,int mahv, string vipham, DateTime ngay)
        {
            ChinhTri_DAO.Instance.Sua_kiluat_DAO(makl,  mahv, vipham, ngay);
            return 1;
        }

        //xóa kỉ luật học viên 
        public int Xoa_kyluat_BLL(int key)
        {
            ChinhTri_DAO.Instance.Xoa_kiluat_DAO(key);
            return 1;
        }




        //=======================================================================>đảng
        //lấy danh sách đảng 
        public List<HosoDang_DTO> Lay_DS_Dang_BLL(string key, int k)
        {
            DataTable ku = ChinhTri_DAO.Instance.DS_HV_Dang_DAO(key,  k);
            List<HosoDang_DTO> vp = new List<HosoDang_DTO>();
            if (ku != null)
            {
                foreach (DataRow dr in ku.Rows)
                {
                    HosoDang_DTO i = new HosoDang_DTO(dr);
                    vp.Add(i);
                }
            }
            return vp;
        }

        //update đảng viên
        public int Capnhat_dang_BLL(int mahv, int tt_Dang, DateTime timee)
        {
            ChinhTri_DAO.Instance.Capnhat_Dang_DAO(mahv, tt_Dang, timee);
            return 1;
        }

        //-----------------------------khenthuong-------------------------------------->

        public List<Khenthuong_DTO> Lay_DS_HV_Khenthuong_BLL(string key)
        {
            DataTable ku = ChinhTri_DAO.Instance.DS_HV_Khenthuong_DAO(key);
            List<Khenthuong_DTO> vp = new List<Khenthuong_DTO>();
            if (ku != null)
            {
                foreach (DataRow dr in ku.Rows)
                {
                    Khenthuong_DTO i = new Khenthuong_DTO(dr);
                    vp.Add(i);
                }
            }
            return vp;
        }

        //thêm khen thưởng 
        public int Them_khenthuong_BLL(int mahv, string khenthuong, DateTime ngay)
        {
            ChinhTri_DAO.Instance.Them_Khenthuong_DAO(mahv, khenthuong, ngay);
            return 1;
        }

        //sửa khen thưởng
        public int Sua_khenthuong_BLL(int MaKT, int mahv, string khenthuong, DateTime ngay)
        {
            ChinhTri_DAO.Instance.Sua_Khenthuong_DAO(MaKT,mahv, khenthuong, ngay);
            return 1;
        }

        //xóa khen thưởng
        public int Xoa_khenthuong_BLL(int ID_KT)
        {
            ChinhTri_DAO.Instance.Xoa_Khenthuong_DAO(ID_KT);
            return 1;
        }

    }
}
