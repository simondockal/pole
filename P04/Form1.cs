using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
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
            listBox2.Items.Clear();
            if(textBox1.Text!="")
            {
                int pocet = Convert.ToInt32(textBox1.Text);
                Random rrr=new Random();
                int[] pole = new int[pocet];
                int max=int.MinValue;
                int pomocna;
                for(int i =0;i<pocet;i++)
                {
                    pole[i] = rrr.Next(1, 20);
                    listBox1.Items.Add(pole[i]);
                    if(pole[i] > max)
                    {
                        max = pole[i];
                    }
                }
                pole = pole.Distinct().ToArray();
                for(int i = 0;i<pole.Length;i++)
                {
                    if(pole[i]==max)
                    {
                        pomocna = pole[i];
                        pole[i]=pole[0];
                        pole[0] = pomocna;
                    }
                }
                pole=pole.Skip(1).ToArray();
                for(int i=0;i<pole.Length;i++)
                {
                    listBox2.Items.Add(pole[i]);
                }
            }
        }
    }
}
