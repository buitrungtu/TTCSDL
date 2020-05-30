using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        // nhớ đổi chuỗi kết nối
        string strConn = "Data Source=DESKTOP-UE7MK69;Database=QuanLyThuVien;Integrated Security=True";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch
            {
                
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
