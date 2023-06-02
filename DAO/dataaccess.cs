using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class dataaccess
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=KUBAOH3P;Initial Catalog=ku;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }

        public static dataaccess instance;
        public static dataaccess Instance
        {
            get { if (instance == null) instance = new dataaccess(); return instance; }
            private set { instance = value; }
        }
        //----------------------------------------------------------------------------

        public DataTable TruyVan(string query, object[] thamtri = null)
        {
            DataTable BangDL = new DataTable();
            try
            {
                SqlConnection conn = Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (thamtri != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string s in listPara)
                    {
                        if (s.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(s, thamtri[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(BangDL);
                conn.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return BangDL;
        }
    }
}
