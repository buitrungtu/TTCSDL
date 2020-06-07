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
        public List<DocGia> LayToanBoSach()
        {
            List < DocGia > docGias = DGA.HienThiGiaoDienDocGia();
            foreach (DocGia docGia in docGias) {
                Console.WriteLine("MDG " + docGia.maDocGia + "TenDocGia " + docGia.tenDocGia);
            }

            return DGA.HienThiGiaoDienDocGia();
        }
    }
}
