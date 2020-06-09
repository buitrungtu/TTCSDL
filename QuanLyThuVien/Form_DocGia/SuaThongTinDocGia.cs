using DTO.DocGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_DocGia
{
    public partial class SuaThongTinDocGia : Form
    {
        public DocGia docGia { get; set; }
        public SuaThongTinDocGia(DocGia docGiaSetView)
        {
            InitializeComponent();
            docGia = docGiaSetView;
            lbSuaMaDocGia.Text = docGia.maDocGia.ToString();
            txtBoxSuaTenDocGia.Text = docGia.tenDocGia;
            txtBoxDonVi.Text = docGia.donVi;
            txtBoxNgaySinh.Text = docGia.ngaySinh.ToString();
            txtBoxSdt.Text = docGia.sdt.ToString();
            txtBoxQuequan.Text = docGia.queQuan;

        }

        private void huySua(object sender, EventArgs e)
        {
            Close();
        }

        private void luuThongTinDocGia(object sender, EventArgs e)
        {

        }
    }
}
