using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhisicExperiments
{
    public partial class Form1 : Form
    {
        private int MAX_MOLEC_CAPACITY = 50;
        private int MAX_PRESURE = 10;

        private int MAX_TEMP = 3000;
        private int DEFAULT_TEMP = 300;
        private int MIN_TEMP = 0;

        private int MIN_AREA_WIDTH = 150;
        private int MAX_AREA_WIDTH = 450;

        private double Depth = 0.1;
        /// <summary>
        /// avogadro number
        /// </summary>
        private double N_A = 6.02e+23;
        /// <summary>
        /// universe gas constant
        /// </summary>
        private double R = 8.41;

        private Stack<Molecula> MoleculSteck;

        private double Volume;
        private double Tempreture;
        private double Total_Weight;
        private double Presure;

        //private Thread th;
        public Form1()
        {
            InitializeComponent();

            MoleculSteck = new Stack<Molecula>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Volume = panel1.Height * panel1.Width * Depth;
            Tempreture = DEFAULT_TEMP;
            Total_Weight = 0;
            Presure = 0;

            for (int i = 0; i < 10; i++)
            {
                RandomAddDebug();
            }
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            RandomAddDebug();

            draw();
            UIupdate();
        }

        private void RandomAddDebug()
        {
            Random rand = new Random();
            Molecula m = new Molecula(rand.Next(30, 420), rand.Next(30, 270));
            m.vectorX = rand.NextDouble() - 0.5;
            m.vectorY = rand.NextDouble()-0.5;
            MoleculSteck.Push(m);
        }

        //remove
        private void button2_Click(object sender, EventArgs e)
        {
            MoleculSteck.Pop();
            draw();
            UIupdate();
        }
        //clear
        private void button3_Click(object sender, EventArgs e)
        {
            MoleculSteck.Clear();
            draw();
            UIupdate();
        }

        private void draw()
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(bm);
            gr.Clear(Color.FromArgb(255, 255, 192));

            //Random rand = new Random();

            int heigh = panel1.Height;
            int width = panel1.Width;
            int x, y, new_x, new_y;
            int step = 20;

            Rectangle rect;
            foreach (Molecula mol in MoleculSteck)
            {
                x = mol.GetX();
                y = mol.GetY();

                if (mol.vectorX > 0)//move right
                {
                    double nextX = x + (step * mol.vectorX);
                    if (nextX < width - step)
                    {
                        new_x = (int)Math.Round(nextX);
                    }
                    else
                    {
                        mol.vectorX = -mol.vectorX;
                        new_x = (int)Math.Round(x + (step * mol.vectorX));
                    }
                }
                else if (mol.vectorX < 0)//move left
                {
                    double nextX = x + (5 * mol.vectorX);
                    if (nextX > 0 + step)
                    {
                        new_x = (int)Math.Round(nextX);
                    }
                    else
                    {
                        mol.vectorX = -mol.vectorX;
                        new_x = (int)Math.Round(x + (step * mol.vectorX));
                    }
                }
                else
                {
                    new_x = mol.GetX();
                }

                mol.SetLocation(new_x, mol.GetY());


                rect = new Rectangle(mol.GetX(), mol.GetY(), 10, 10);
                //mol.SetLocation(new Point(rand.Next(30, 420), rand.Next(30, 270)));
                gr.FillEllipse(Brushes.LightBlue, rect);
                //gr.FillEllipse(new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))), rect);
            }
            panel1.BackgroundImage = bm;
            //draw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UIupdate();

            Thread th = new Thread(draw);
            th.IsBackground = true;
            th.Start();
        }

        private void UIupdate()
        {
            textBox_count.Text = MoleculSteck.Count.ToString();
            textBox_total_weight.Text = Total_Weight.ToString();
            textBox_temp.Text = Tempreture.ToString();
            Presure = (MoleculSteck.Count * R * Tempreture) / (N_A * Volume);
            textBox_presure.Text = Presure.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //th.Suspend();
        }

        private void button_stop_resume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }


}


