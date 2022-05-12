using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasec8
{
    
    public partial class Form1 : Form
    {
        double Func(double i, double j)
        {
            double f = 10 * Math.Pow(-1, i + j) + i + j / 10;
            return f;
        }
        double[,] filtrD(double[,] arr)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int M = Convert.ToInt32(textBoxM.Text);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] != Math.Round(arr[i, j]))
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            return arr;
        }
        double[,] filtrI(double[,] arr)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int M = Convert.ToInt32(textBoxM.Text);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] == Math.Round(arr[i, j]))
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            return arr;
        }
        double[,] filtrO(double[,] arr)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int M = Convert.ToInt32(textBoxM.Text);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            return arr;
        }
        double[,] filtrP(double[,] arr)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int M = Convert.ToInt32(textBoxM.Text);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] > 0)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            return arr;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void TextV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBarN_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxN.Text = hScrollBarN.Value.ToString();
        }

        private void hScrollBarM_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxM.Text = hScrollBarM.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxN.Text);
            int M = Convert.ToInt32(textBoxM.Text);
            dataGridVivod.Rows.Clear();
            dataGridVivod.Columns.Clear();
            textBoxV.Text = "";
            double[,] array = new double[N, M];
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    array[i,j] = Func(i, j);
                }
            }
            if (checkBoxDoub.Checked == true || checkBoxInt.Checked == true || checkBoxOtric.Checked == true || checkBoxPoloj.Checked == true)
            {
                if(checkBoxDoub.Checked == true)
                {
                    array = filtrD(array);
                }
                if (checkBoxInt.Checked == true)
                {
                    array = filtrI(array);
                }
                if (checkBoxOtric.Checked == true)
                {
                    array = filtrO(array);
                }
                if (checkBoxPoloj.Checked == true)
                {
                    array = filtrP(array);
                }
            }
            if(radioButtonText.Checked == true)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        textBoxV.Text += array[i, j] + "  ";
                    }
                    textBoxV.Text += Environment.NewLine;
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    dataGridVivod.Columns.Add(i.ToString(), i.ToString());
                }
                for (int j = 0; j < M; j++)
                {
                    dataGridVivod.Rows.Add("0");
                }
                
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        dataGridVivod.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
