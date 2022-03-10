using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                int n = Convert.ToInt32(textBox1.Text);
                int[] pole = new int[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    pole[i] = r.Next(1, 10);

                }
                Array.Sort(pole);
                //2,2,2,3,5,5,6,6
                int min = pole[0];
                int max = pole[pole.Length-1];
                int pdmax = Array.IndexOf(pole, max);
                int dmax = pole[pdmax - 1];
                int pdmin = Array.LastIndexOf(pole, min);
                int dmin = pole[pdmin + 1];
                


                if (radioButton2.Checked)
                {
                    Array.Reverse(pole);
                }
                for (int i = 0; i < pole.Length; i++)
                {
                    listBox1.Items.Add(pole[i].ToString());
                }
                label1.Text = "Druhý největší prvek je " + dmax + " a druhý nejmenší je " + dmin;
            }
        }
    }
}
