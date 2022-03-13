using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            listBox3.Items.Clear();
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                int b = Convert.ToInt32(textBox2.Text);
                int pocet=Convert.ToInt32(textBox1.Text);
                int[] pole=new int[pocet];
                int [] mensi=new int[pocet];
                int[]vetsi=new int[pocet];
                int min=0;
                int max=0;
                Random r = new Random();
                for(int i = 0; i < pocet; i++)
                {
                    pole[i]=r.Next(0,20);
                }
                Array.Sort(pole);
                for(int i = 0; i < pole.Length; i++)
                {
                    mensi[i] = pole[i];
                    vetsi[i] = pole[i];
                    listBox1.Items.Add(pole[i]);
                    if(pole[i]<=b)
                    {
                        min++;
                    }
                }
                label1.Text=min.ToString();
                mensi=mensi.Take(min).ToArray();
                vetsi=vetsi.Skip(min).ToArray();
                
                for (int i = 0; i < vetsi.Length; i++)
                {
                    listBox2.Items.Add(vetsi[i]);
                }
                for (int i = 0; i < mensi.Length; i++)
                {
                    listBox3.Items.Add(mensi[i]);
                }
            }
        }
    }
}
