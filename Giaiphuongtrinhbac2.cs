using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanKimHoangPhuc_15_ThiCSharp
{
    public partial class frmgiaiptbac2 : Form
    {
        public frmgiaiptbac2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int intA, intB, intC;
            double x1, x2, delta;
            intA = Convert.ToInt32(txta.Text);
            intB = Convert.ToInt32(txtb.Text);
            intC = Convert.ToInt32(txtc.Text);
            if (intA == 0)
            {
                if (intB == 0)
                {
                    if (intC == 0)
                    {
                        lblKETQUA.Text = "Phương Trình Có Vô Số Nghiệm";
                    }
                    else
                    {
                        lblKETQUA.Text = "Phương Trình Vô Nghiệm";
                    }
                }
                else
                {
                    x1 = (double)-intC / intB;
                    lblKETQUA.Text = "Phương Trình Có Nghiệm Duy Nhất";
                    lblKETQUA.Text += "" + x1;
                }

            }
            else
            {
                delta = Math.Pow(intB, 2) - 4 * intA * intC;
                lblKETQUA.Text = delta.ToString();
                if (delta < 0)
                {
                    lblKETQUA.Text = "Phương Trình Có Vô Số Nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -intB / (2 * intA);
                    lblKETQUA.Text = "Phương Trình Vô Nghiệm";
                }
                else
                {
                    x1 = (-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (-intB - Math.Sqrt(delta)) / (2 * intA);
                    lblKETQUA.Text = "Phương Trình Có Hai Nghiệm Phân Biệt";
                    lblKETQUA.Text += "" + (x1);
                    lblKETQUA.Text += "" + (x2);
                }
            }
        }
    }
}