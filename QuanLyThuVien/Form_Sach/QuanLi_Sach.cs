using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_Sach
{
    public partial class QuanLi_Sach : UserControl
    {
        public QuanLi_Sach()
        {
            InitializeComponent();
            pnTimKiemNangCao.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pnTimKiemNangCao.Visible == true)
            {
                pnTimKiemNangCao.Visible = false;
            }
            else
            {
                pnTimKiemNangCao.Visible = true;
            }
        }
    }
}
