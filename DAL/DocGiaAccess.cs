using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.DocGia;

namespace DAL
{
    public class DocGiaAccess : DatabaseAccess
    {
        public List<DocGia> HienThiGiaoDienDocGia()
        {
            List<DocGia> listDocGia = new List<DocGia>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM dbo.hienthitoanbodocgia";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DocGia docGia = new DocGia();
                docGia.maDocGia = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                {
                    docGia.tenDocGia = reader.GetString(1);
                }
                else
                {
                    docGia.tenDocGia = "Chưa có thông tin";
                }
                if (!reader.IsDBNull(2))
                {
                    docGia.donVi = reader.GetString(2);
                }
                else
                {
                    docGia.donVi = "Chưa có thông tin";
                }
                if (!reader.IsDBNull(3))
                {
                    docGia.ngaySinh = reader.GetDateTime(3);
                }
                else
                {
                    docGia.ngaySinh = DateTime.Now;
                }
                if (!reader.IsDBNull(4))
                {
                    docGia.sdt = reader.GetInt32(4);
                }
                else
                {
                    docGia.sdt = 0;
                }
                if (!reader.IsDBNull(5))
                {
                    docGia.queQuan = reader.GetString(5);
                }
                else
                {
                    docGia.queQuan = "Chưa có thông tin";
                }
                listDocGia.Add(docGia);
            }
            reader.Close();
            return listDocGia;
        }
    }
}
