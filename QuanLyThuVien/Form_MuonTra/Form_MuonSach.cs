using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_MuonTra
{
    public partial class Form_MuonSach : Form
    {
        public Form_MuonSach()
        {
            InitializeComponent();
        }

        private void Form_MuonSach_Load(object sender, EventArgs e)
        {
            lbNgayHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
