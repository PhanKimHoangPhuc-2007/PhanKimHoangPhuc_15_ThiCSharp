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
    public partial class frmDinhDang : Form
    {
        public frmDinhDang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Text = txtnhapten.Text;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Red;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor= Color.Green;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Blue;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Black;
        }

        private void ckbbold_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void ckbitalic_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void ckbunderLine_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
