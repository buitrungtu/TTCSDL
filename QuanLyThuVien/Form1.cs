using QuanLyThuVien.Form_MuonTra;
using QuanLyThuVien.Form_Sach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        int PanelWith;
        bool ThuNhoMenu;
        public Form1()
        {
            InitializeComponent();
            PanelWith = panelLeft.Width;
            ThuNhoMenu = false;
            PanelWith = panelLeft.Width;
            ThuNhoMenu = false;
            QuanLi_Sach temp = new QuanLi_Sach();
            AddControlsToPanel(temp);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSach);
            QuanLi_Sach temp = new QuanLi_Sach();
            AddControlsToPanel(temp);
        }


        

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMuonTra_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnMuonTra);
            QuanLi_MuonTra temp = new QuanLi_MuonTra();
            AddControlsToPanel(temp);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {            
                if (ThuNhoMenu)
                {
                    panelLeft.Width += 12;
                    if (panelLeft.Width >= PanelWith)
                    {
                        timer1.Stop();
                        ThuNhoMenu = false;
                        this.Refresh();
                    }
                }
                else
                {
                    panelLeft.Width -= 12;
                    if (panelLeft.Width <= 83)
                    {
                        timer1.Stop();
                        ThuNhoMenu = true;
                        this.Refresh();
                    }
                }            
        }

        private void btnDocGia_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnDocGia);
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btnThongKe);
        }

        
    }
}
