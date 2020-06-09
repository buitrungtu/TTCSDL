using DAL;
using DTO.Sach;
using DTO.TheLoai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        TheLoaiAccess TLA = new TheLoaiAccess();
        public List<TheLoai> LayDanhSachTheLoai()
        {
            return TLA.LayDanhSachTheLoai();
        }
    }
}
