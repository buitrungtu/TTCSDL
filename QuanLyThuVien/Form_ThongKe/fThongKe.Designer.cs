namespace QuanLyThuVien.Form_ThongKe
{
    partial class fThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabThongKe = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayout3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lvSachTheoTheLoai = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabThongKe.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabThongKe.Controls.Add(this.metroTabPage1);
            this.tabThongKe.Controls.Add(this.metroTabPage2);
            this.tabThongKe.Controls.Add(this.metroTabPage3);
            this.tabThongKe.ItemSize = new System.Drawing.Size(364, 40);
            this.tabThongKe.Location = new System.Drawing.Point(3, 3);
            this.tabThongKe.Multiline = true;
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 2;
            this.tabThongKe.Size = new System.Drawing.Size(839, 564);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabThongKe.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "       Số lượng sách còn trong kho         ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "       Sách được mượn nhiều       ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.panel1);
            this.metroTabPage3.Controls.Add(this.flowLayout3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(831, 516);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "       Phân nhóm theo thể loại       ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvSachTheoTheLoai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 516);
            this.panel1.TabIndex = 3;
            // 
            // flowLayout3
            // 
            this.flowLayout3.Location = new System.Drawing.Point(3, 0);
            this.flowLayout3.Name = "flowLayout3";
            this.flowLayout3.Size = new System.Drawing.Size(142, 513);
            this.flowLayout3.TabIndex = 2;
            // 
            // lvSachTheoTheLoai
            // 
            this.lvSachTheoTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.lvSachTheoTheLoai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSachTheoTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSachTheoTheLoai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSachTheoTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.lvSachTheoTheLoai.FullRowSelect = true;
            this.lvSachTheoTheLoai.GridLines = true;
            this.lvSachTheoTheLoai.HideSelection = false;
            this.lvSachTheoTheLoai.Location = new System.Drawing.Point(0, 0);
            this.lvSachTheoTheLoai.Name = "lvSachTheoTheLoai";
            this.lvSachTheoTheLoai.Size = new System.Drawing.Size(685, 516);
            this.lvSachTheoTheLoai.TabIndex = 33;
            this.lvSachTheoTheLoai.UseCompatibleStateImageBehavior = false;
            this.lvSachTheoTheLoai.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đầu sách";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tập";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác giả";
            this.columnHeader4.Width = 179;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 133;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabThongKe);
            this.Name = "fThongKe";
            this.Size = new System.Drawing.Size(845, 570);
            this.tabThongKe.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabControl tabThongKe;
        private System.Windows.Forms.FlowLayoutPanel flowLayout3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvSachTheoTheLoai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
