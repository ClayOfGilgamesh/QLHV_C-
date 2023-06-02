using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class Thongke_DAO
    {
        public static Thongke_DAO instance;
        public static Thongke_DAO Instance
        {
            get { if (instance == null) instance = new Thongke_DAO(); return instance; }
            private set { instance = value; }
        }
        //----------------------------------------------------------------------------
        
        //-------------------ĐẢNG----------------------
        public DataTable DS_thongke_Dang(string tukhoa, int ttDang, DateTime thoigian, int maDD)
        {
            object[] thamtri = { tukhoa,ttDang,thoigian,maDD};
            DataTable ku = dataaccess.Instance.TruyVan("EXEC Lay_DS_Thongke_Dang @tukhoa , @ttDang , @thoigian , @maDD", thamtri);
            return ku;
        }


        //---------------------------ĐIỀU LỆNH--------

        //-------------THỂ LỰC--------------

    }
   
}
