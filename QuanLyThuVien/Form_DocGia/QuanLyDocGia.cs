using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO.DocGia;

namespace QuanLyThuVien.Form_DocGia
{
    public partial class QuanLyDocGia : UserControl
    {
        private DocGiaBLL docGiaBLL;
        public QuanLyDocGia()
        {
            InitializeComponent();
            docGiaBLL = new DocGiaBLL();
            
        }
        private void QuanLyDocGiaLoad(object sender, EventArgs e)
        {
            HienThiDocGia();
        }
        private void HienThiDocGia()
        {
           
            List<DocGia> listDocGia = new List<DocGia>();
            listDocGia = docGiaBLL.LayToanBoSach();
            listViewDocGia.Items.Clear();
            foreach (DocGia docGia in listDocGia)
            {
                ListViewItem listViewItem = new ListViewItem(docGia.maDocGia + "");
                listViewItem.SubItems.Add(docGia.tenDocGia);
                listViewItem.SubItems.Add(docGia.donVi);
                listViewItem.SubItems.Add(docGia.ngaySinh +"");
                listViewItem.SubItems.Add(docGia.sdt +"");
                listViewItem.SubItems.Add(docGia.queQuan);

                listViewDocGia.Items.Add(listViewItem);
                listViewItem.Tag = docGia;
            }
        }

    }
}
