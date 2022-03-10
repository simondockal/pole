using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
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
            Random rr = new Random();
            int[] polea;
            int[] polem;
            if (textBox1.Text!=""&&textBox2.Text!="")
            {
                int n = Convert.ToInt32(textBox1.Text);
                polea = new int[n];
                for(int i=0;i<polea.Length;i++)
                { 
                    polea[i] = rr.Next(3,11);
                    listBox1.Items.Add(polea[i]);
                }

                int m = Convert.ToInt32(textBox2.Text);
                polem = new int[m];
                for (int i = 0; i < polem.Length; i++)
                {
                    polem[i] = rr.Next(3, 11);
                    listBox2.Items.Add(polem[i]);
                }
                int[] polec = polea.Concat(polem).ToArray();
                for(int i=0;i<polec.Length;i++)
                {
                    listBox3.Items.Add(polec[i]);
                }
                int[] poled = polea.Union(polem).ToArray();
                for(int i=0;i<poled.Length;i++)
                {
                    listBox4.Items.Add(poled[i]);
                }
                int[] polee = polea.Intersect(polem).ToArray();
                for(int i=0;i<polee.Length;i++)
                {
                    listBox5.Items.Add(polee[i]);
                }
                
            }

        
        }
    }
}
