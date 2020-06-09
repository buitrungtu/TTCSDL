using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
using System.Data.Common;
using DTO.TheLoai;

namespace QuanLyThuVien.Form_ThongKe
{
    public partial class fThongKe : UserControl
    {
        TheLoaiAccess tla = new TheLoaiAccess();
        public fThongKe()
        {
            InitializeComponent();
            LoadListTheLoai();
        }
        public void LoadListTheLoai()
        {
            List<TheLoai> list = tla.LayDanhSachTheLoai().ToList();
            foreach (var item in list)
            {
                LinkLabel linkLabel = new LinkLabel() { Text = item.TenTheLoai };
                linkLabel.Click += linkLabel_Click;
                flowLayout3.Controls.Add(linkLabel);
                flowLayout3.FlowDirection = FlowDirection.TopDown;
            }
        }
        private void linkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel x = (LinkLabel)sender;
            String tenTheLoai = x.Text;
            var list = new DauSachAccess().DanhSachDauSachTheoTheLoai(tenTheLoai);
            lvSachTheoTheLoai.Items.Clear();
            int i = 1;
            foreach(var item in list)
            {
                ListViewItem lvi = new ListViewItem(i+"");
                lvi.SubItems.Add(item.TenDauSach);
                lvi.SubItems.Add(item.Tap+"");
                lvi.SubItems.Add(item.TenTacGia);
                lvi.SubItems.Add(item.SoLuong+"");
                lvSachTheoTheLoai.Items.Add(lvi);
                i++;
            }
        }

        
    }
}