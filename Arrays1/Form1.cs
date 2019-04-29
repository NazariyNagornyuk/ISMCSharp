using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            
            try {
                int arraysize = Convert.ToInt32(textBoxNumberOfElements.Text);
                double[] array = new double[arraysize];

                // я что-то не совсем въехал в датагридвью :-(
                
                // заполнение массива рандомными значениями 
                for (int i=0; i<array.Length; i++)
                {
                    Random rnd=new Random();
                    array[i] = Math.Round((rnd.NextDouble()*5-2),3);
                }
                //поиск суммы отрицательных
                double SumMinus = 0;
                for (int i=0;i<array.Length;i++)
                {
                    if(array[i]<0)
                    {
                        SumMinus += array[i];
                    }
                }
                textBoxSumMinus.Text = Convert.ToString(SumMinus);
                //поиск максимального  элемента и его индекса
                double MaxElement = double.MinValue;
                int MaxIndex=0;
                for (int i=0;i<array.Length;i++)
                {
                    if(array[i]>MaxElement)
                    {
                        MaxElement = array[i];
                        MaxIndex = i;
                    }
                }
                textBoxMax.Text = Convert.ToString(MaxElement);
                textBoxMaxIndex.Text = Convert.ToString(MaxIndex);
                //максимальный по модулю
                double MaxAbs = double.MinValue;
                for (int i=0;i<array.Length;i++)
                {
                    if(Math.Abs(array[i])>MaxElement)
                    {
                        MaxAbs = array[i];
                    }
                }
                textBoxMaxAbs.Text = Convert.ToString(MaxAbs);
                //сумма элементов положительных элементов
                int SumPlusIndex = 0;
                for (int i=0; i<array.Length; i++)
                {
                    if(array[i]>0)
                    {
                        SumPlusIndex += i;
                    }
                }
                textBoxSumPlusIndex.Text = Convert.ToString(SumPlusIndex);
                //количество целых элементов в массиве
                int NumberInt = 0;
                for (int i=0;i<array.Length;i++)
                {
                    if(array[i]%1==0)
                    {
                        NumberInt++;
                    }
                }
                textBoxNumberInt.Text = Convert.ToString(NumberInt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
