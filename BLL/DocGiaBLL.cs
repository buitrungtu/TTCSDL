using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.DocGia;
using DAL;

namespace BLL
{
    public class DocGiaBLL
    {
        DocGiaAccess DGA = new DocGiaAccess();
        public List<DocGia> LayToanBoDocGia()
        {
            
            return DGA.HienThiGiaoDienDocGia();
        }

        public List<DocGia> TimKiemDocGia(string textSearch)
        {
            return DGA.TimKiemDocGia(textSearch);
        }
        public DocGia ThongTinChiTietDocGia(int maDocGia)
        {
           
            return DGA.ThongTinChiTietDocGia(maDocGia);
        }

        public List<SachDangMuon> HienThiListSachDangMuon(int maDocGia)
        {
            return DGA.HienThiListSachDangMuon(maDocGia);
        }
        public bool TraSach(int maMuonTra)
        {
            return DGA.TraSach(maMuonTra);
        }
    }
}
