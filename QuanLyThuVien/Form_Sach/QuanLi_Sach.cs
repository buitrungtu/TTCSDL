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
        SachBLL SBLL = new SachBLL();
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

        
        private void btnTimKiemNangCao_Click(object sender, EventArgs e)
        {
            DauSach temp = new DauSach();
            temp.TenDauSach = txbTenSach.Text;
            temp.TacGia = txbTacGia.Text;
            temp.TheLoai = txbTheLoai.Text;
            temp.NhaXuatBan = txbNhaXB.Text;
            temp.NgonNgu = txbNgonNgu.Text;

            lvSach.Items.Clear();
            List<Sach> tts = SBLL.TimKiemSachChiTiet(temp);
            foreach (Sach s in tts)
            {
                ListViewItem lvi = new ListViewItem(s.MaSach + "");
                lvi.SubItems.Add(s.TenDauSach);
                if (s.Tap == 0) lvi.SubItems.Add("Chưa có thông tin");
                else lvi.SubItems.Add(s.Tap.ToString());
                if (s.LanTaiBan == 0) lvi.SubItems.Add("Chưa có thông tin");
                else lvi.SubItems.Add(s.LanTaiBan.ToString());
                lvi.SubItems.Add(s.ViTri);
                lvi.SubItems.Add(s.TacGia);
                lvi.SubItems.Add(s.TheLoai);
                lvi.SubItems.Add(s.NgonNgu);
                lvi.SubItems.Add(s.NXB);
                lvSach.Items.Add(lvi);
                lvi.Tag = s;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lvSach.Items.Clear();
            List<Sach> tts = SBLL.TimKiemSach(txbTimKiem.Text);
            foreach (Sach s in tts)
            {
                ListViewItem lvi = new ListViewItem(s.MaSach + "");
                lvi.SubItems.Add(s.TenDauSach);
                if (s.Tap == 0) lvi.SubItems.Add("Chưa có thông tin");
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
    }
}
