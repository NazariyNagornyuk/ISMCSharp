using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                

                int arraysize = Convert.ToInt32(textBoxNumberOfElements.Text);
                double[] array = new double[arraysize];

                // тут же всё равно одномерный массив, я сделаю через лист-бокс

                // заполнение массива рандомными значениями 
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    
                    array[i] = Math.Round((rnd.NextDouble() * 50 - 20), 3);
                }

                // listbox где будут перечислены элементы массива
                listBoxArray.Items.Clear();
                for(int i=0; i<array.Length;i++)
                {
                    listBoxArray.Items.Insert(i, "array["+i+"]= "+array[i]);
                }
                // произведение элементов после минимального
                double Min = double.MaxValue;
                int MinIndex=0;
                for (int i=0;i<array.Length;i++)
                {
                    if (array[i]<Min)
                    {
                        Min = array[i];
                        MinIndex = i;
                    }
                }
                double ProductAfterMin=0;
                for (int y=MinIndex;y<array.Length;y++)
                {
                    ProductAfterMin *= array[y];
                }
                textBoxProductAfterMin.Text = Convert.ToString(ProductAfterMin);
                //суму елементів масиву, що розташовані між першим від'ємним та другим додатним елементами
                int FirstMinusIndex = 0;
                for (int i=0;i<array.Length;i++)
                {
                    if(array[i]<0)
                    {
                        FirstMinusIndex = i;
                        break;
                    }
                }
                //...

                //суму елементів масиву, які розташовані між першим і останнім нульовими елементами


                //добуток елементів масиву, що розташовані між максимальним за модулем і мінімальним за модулем елементами.
                int MaxAbsIndex=0;
                int MinAbsIndex=0;
                double MaxAbs = double.MinValue;
                double MinAbs = double.MaxValue;
                for (int i=0; i<array.Length; i++)
                {
                    if (Math.Abs(array[i])>MaxAbs)
                    {
                        MaxAbs = Math.Abs(array[i]);
                        MaxAbsIndex = i;
                    }
                }
                for (int i=0; i<array.Length; i++)
                {
                    if (Math.Abs(array[i]) < MinAbs)
                    {
                        MinAbs = Math.Abs(array[i]);
                        MinAbsIndex = i;
                    }
                }
                double dobutok=1;
                if (MinAbsIndex<MaxAbsIndex)
                {
                    for (int i=MinAbsIndex; i==MaxAbsIndex; i++)
                    {
                        dobutok *= array[i];
                    }
                }
                else if (MinAbsIndex>MaxAbsIndex)
                {
                    for (int i=MaxAbsIndex; i==MinAbsIndex; i++)
                    {
                        dobutok *= array[i];
                    }
                }
                textBoxProductBetweenMaxAndMinAbs.Text = Convert.ToString(dobutok);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
