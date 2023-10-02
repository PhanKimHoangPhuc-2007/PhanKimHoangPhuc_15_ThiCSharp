using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanKimHoangPhuc_15_ThiCSharp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string hovaten = "Phan Kim Hoàng Phúc";
            string mssv = "1223360270";
            string monthi = "Lập trình Windows 2 - C#";

            lblInfo.Text = "Họ và tên: " + hovaten;
            lblInfo.Text += "\nMSSV: " + mssv;
            lblInfo.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\nMôn thi: " + monthi;
        }

        private void giảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiaiptbac2 frmgiaiptbac2 = new frmgiaiptbac2();
            frmgiaiptbac2.Show();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương Trình Tiện Ích", "Thông Tin");
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDinhDang frmDinhDang = new frmDinhDang();
            frmDinhDang.Show();
        }
    }
}
