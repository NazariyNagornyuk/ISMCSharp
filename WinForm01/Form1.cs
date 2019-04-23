using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            
            double a, b, x, y;
            a = Convert.ToDouble(TextBoxA.Text);
            b = Convert.ToDouble(TextBoxB.Text);
            x = Convert.ToDouble(TextBoxX.Text);
            y = 2.4 * (Math.Abs((Math.Pow(x, 2) + b) / a)) + (a - b) * Math.Pow((Math.Sin(a - b)), 2) + (Math.Pow(10, -2) * (x - b));
            
            TextBoxY.Text = Convert.ToString(y);
        }
    }
}
