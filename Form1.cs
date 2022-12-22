using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertionSort
{
    public partial class Form1 : Form
    {
        int[] A = new int[100];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Nums_Click(object sender, EventArgs e)
        {

        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            ////int n = Convert.ToInt32(textBox1.Text);
            ////string T = Convert.ToString(textBox2.Text);
            ////int [] A = new int[n];
            ////for (int i = 0; i < n; i++)
            ////{
            ////    A[i] = Convert.ToInt32(T[i]);
            ////}



            //for (int j = 1; j <= n - 1; j++)
            //{
            //    int Key = A[j];
            //    int i = j - 1;
            //    while (i >= 0 && A[i] > Key)
            //    {
            //        A[i + 1] = A[i];
            //        i = i - 1;
            //    }
            //    A[i + 1] = Key;

            //}


            ////string output = " The " ;
            ////for (int i = 0; i < n; i++)
            ////{ 
            ////    output += A[i] + " ";
            ////}
            ////// textBox3.Text = A[i].ToString();
            ////MessageBox.Show(output);



            //string output = " The ";
            //for (int i = 0; i < n; i++)
            //{
            //    output += A[i] + " ";
            //}
            ////textBox3.Text = A[i].ToString();
            //MessageBox.Show(output);






        }

        private void Descending_Click(object sender, EventArgs e)
        {
            //A[n] =Int32.Parse(textBox1.Text);
            //label1.Text +=A[n] + " ";
            //n++;
            //textBox1.Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertNum_Click(object sender, EventArgs e)
        {
            A[n] = Int32.Parse(textBox1.Text);
            label1.Text += A[n] + " ";
            n++;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                int Key = A[j];
                int i = j - 1;
                while (i >= 0 && A[i] > Key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = Key;

            }

            string output = "The Ascending Order : \n ";
            for (int i = 0; i < n; i++)
            {
                output += A[i] + " ";
            }
            //textBox3.Text = A[i].ToString();
            MessageBox.Show(output);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                int Key = A[j];
                int i = j - 1;
                while (i >= 0 && A[i] < Key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = Key;

            }

            string output = "The Descending Order : \n";
            for (int i = 0; i < n; i++)
            {
                output += A[i] + " ";
            }
            //textBox3.Text = A[i].ToString();
            MessageBox.Show(output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
