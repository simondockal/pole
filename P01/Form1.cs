using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                listBox1.Items.Clear(); 
                listBox2.Items.Clear();
                int rozmer=Convert.ToInt32(textBox1.Text); 
                int[] pole = new int[rozmer];
                Random r=new Random();
                int rng;
                int max = int.MinValue;
                int min = int.MaxValue;
                int m_max = 0;
                int m_min=0;
                int max_pozice=0;
                int min_pozice=0;

                for (int i=0; i<pole.Length; i++)
                { 
                    rng = r.Next(0, 1000);
                    pole[i] = rng;
                    listBox1.Items.Add(pole[i].ToString());
                }
                for (int i=0; i<pole.Length; i++)
                {
                    if(pole[i]>max)
                    {
                        max = pole[i];
                        max_pozice = i;
                    }
                    if(pole[i]<min)
                    {
                        min = pole[i];
                        min_pozice = i;
                    }
                }
                pole[min_pozice]= max;
                pole[max_pozice] = min;
                double art = 0;
                int pocet = 0;

                double m_art=0;
                int m_pocet=0;
                for(int i=0; i<pole.Length; i++)
                {
                    if(i!=min_pozice&&i!=max_pozice)
                    {
                        art+=pole[i];
                        pocet++;
                    }

                    m_art += pole[i];
                    m_pocet++;

                    listBox2.Items.Add(pole[i].ToString());
                }

                label3.Text = pole.Max().ToString();
                label4.Text = pole.Min().ToString();

                if (pocet > 0)
                {
                    art /= pocet;
                    label1.Text = "Aritmeticky prumer pole bez max a min je " + art;
                }
                else
                {
                    label1.Text = "Aritmeticky prumer nelze vypocitat";
                }


                double odcet = pole.Max()+pole.Min();
                if (m_pocet>0)
                {
                    m_art -= odcet;
                    m_pocet -= 2;

                    m_art /= pocet;
                    label2.Text = "Aritmeticky prumer pole bez max a min je " + m_art;
                }
                else
                {
                    label2.Text = "Aritmeticky prumer nelze vypocitat";
                }


            }

        }
    }
}
