using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO.Sach;

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
        void HienThiSach()
        {                    
            SachBLL SBLL = new SachBLL();
            List<Sach> LS = new List<Sach>();
            LS = SBLL.LayToanBoSach();                        
            lvSach.Items.Clear();
            foreach (Sach s in LS)
            {
                ListViewItem lvi = new ListViewItem(s.MaSach + "");
                lvi.SubItems.Add(s.TenDauSach);
                if(s.Tap == 0) lvi.SubItems.Add("Chưa có thông tin");
                else lvi.SubItems.Add(s.Tap + "");
                if (s.LanTaiBan == 0) lvi.SubItems.Add("Chưa có thông tin");
                else lvi.SubItems.Add(s.LanTaiBan + "");
                lvi.SubItems.Add(s.ViTri);
                lvi.SubItems.Add(s.TacGia);
                lvi.SubItems.Add(s.TheLoai);
                lvi.SubItems.Add(s.NgonNgu);
                lvi.SubItems.Add(s.NXB);
                lvSach.Items.Add(lvi);
                lvi.Tag = s;
            }
        }

        private void QuanLi_Sach_Load(object sender, EventArgs e)
        {
            HienThiSach();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            using(ThemSach themsach = new ThemSach())
            {
                themsach.ShowDialog();
                HienThiSach();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe();
            thongke.Show();
        }

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvSach.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSach.SelectedItems[0];
                Sach s = lvi.Tag as Sach;
                ThongTinChiTietSach temp = new ThongTinChiTietSach();
                temp.MaSach = s.MaSach;
                temp.Show();
                
            }
            
        }
    }
}
