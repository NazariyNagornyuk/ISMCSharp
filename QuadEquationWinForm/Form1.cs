using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2, x;
            LabelX.Visible = true;
            TextBoxX.Visible = true;
            LabelX1.Visible = true;
            TextBoxX1.Visible = true;
            LabelX2.Visible = true;
            TextBoxX2.Visible = true;
            
            a = Convert.ToDouble(TextBoxA.Text);
            b = Convert.ToDouble(TextBoxB.Text);
            c = Convert.ToDouble(TextBoxC.Text);
            d = (Math.Pow(b, 2)) - (4 * a * c);
            if (d < 0)
            {
                LabelX.Visible = false;
                TextBoxX.Visible = false;
                LabelX1.Visible = false;
                TextBoxX1.Visible = false;
                LabelX2.Visible = false;
                TextBoxX2.Visible = false;

                MessageBox.Show("There are no solutions!");
            }
            else if (d == 0)
            {
                LabelX1.Visible = false;
                TextBoxX1.Visible = false;
                LabelX2.Visible = false;
                TextBoxX2.Visible = false;
                x = (-b) / (2 * a);
                TextBoxX.Text = Convert.ToString(x);
            }
            else if (d > 0)
            {
                x1 = (-b + (Math.Sqrt(d))) / (2 * a);
                x2 = (-b - (Math.Sqrt(d))) / (2 * a);
                LabelX.Visible = false;
                TextBoxX.Visible = false;
                TextBoxX1.Text = Convert.ToString(x1);
                TextBoxX2.Text = Convert.ToString(x2);
            }
            
        }
    }
}
