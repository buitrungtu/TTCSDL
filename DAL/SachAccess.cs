using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SachAccess : DatabaseAccess
    {
        public List<Sach> LayToanBoMayTinh()
        {
            List<Sach> dsMT = new List<Sach>();
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
            }
            reader.Close();
            return dsMT;
        }
    }
}
