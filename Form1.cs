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

        private int MAX_TEMPR = 3000;
        private int DEFAULT_TEMPR = 300;

        private int MIN_AREA_WIDTH = 150;
        private int MAX_AREA_WIDTH = 500;

        private double Depth = 0.1;
        /// <summary>
        /// avogadro number
        /// </summary>
        private double N_A = 6.02e+23;
        /// <summary>
        /// universe gas constant
        /// </summary>
        private double R = 8.41;

        private Stack<Molecula> SMolec;

        private double Volume;
        private double Tempreture;
        private double Total_Weight;
        private double Presure;

        private double Stopwatch_time;


        public Form1()
        {
            InitializeComponent();

            SMolec = new Stack<Molecula>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_molec_count.Maximum = MAX_MOLEC_CAPACITY;
            numericUpDown_temparature.Maximum = MAX_TEMPR;

            Volume = panel1.Height * panel1.Width * Depth;
            Tempreture = DEFAULT_TEMPR;
            Total_Weight = 0;
            Presure = 0;

            for (int i = 0; i < 10; i++)

            {
                AddMolecul();
            }
        }

        //add
        private void button_add_molec_Click(object sender, EventArgs e)
        {
            AddMolecul();

            RedrawArea();
            UIupdate();
        }

        private void AddMolecul()
        {
            Random rand = new Random();
            Molecula m = new Molecula(rand.Next(30, 420), rand.Next(30, 270));
            m.vectorX = rand.NextDouble() - 0.5;
            m.vectorY = rand.NextDouble()-0.5;
            SMolec.Push(m);
        }

        //remove
        private void button_remove_molec_Click(object sender, EventArgs e)
        {
            SMolec.Pop();
            RedrawArea();
            UIupdate();
        }


        //clear
        private void button_clear_Click(object sender, EventArgs e)
        {
            SMolec.Clear();
            RedrawArea();
            UIupdate();
        }

        private void RedrawArea()
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(bm);
            gr.Clear(Color.FromArgb(255, 255, 192));

            int heigh = panel1.Height;
            int width = panel1.Width;
            int x, y, new_x, new_y;
            int step = 20;

            Rectangle rect;
            foreach (Molecula m in SMolec)
            {
                x = m.GetX();
                new_x = (int)Math.Round(x + (step * m.vectorX));
                if ((new_x < 0 + step / 2)||(new_x > width - step/2))
                {
                    m.vectorX = -m.vectorX;
                }

                y = m.GetY();
                new_y = (int)Math.Round(y + (step * m.vectorY));
                if ((new_y < 0 + step / 2) || (new_y > heigh - step / 2))
                {
                    m.vectorY = -m.vectorY;
                }

                m.SetLocation(new_x,new_y);


                rect = new Rectangle(m.GetX(), m.GetY(), 10, 10);
                gr.FillEllipse(Brushes.LightBlue, rect);
                //gr.FillEllipse(new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))), rect);
            }
            panel1.BackgroundImage = bm;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UIupdate();

            if (SMolec.Count != 0)
            {
                Thread th = new Thread(RedrawArea);
                th.IsBackground = true;
                th.Start();
            }
        }

        private void UIupdate()
        {
            numericUpDown_molec_count.Text = SMolec.Count.ToString(); // кількість молекул
            textBox_total_weight.Text = Total_Weight.ToString(); // загальна маса
            textBox_temp.Text = Tempreture.ToString(); // температура
            Presure = (SMolec.Count * R * Tempreture) / (N_A * Volume); // 
            textBox_presure.Text = Presure.ToString();
        }

        private void button_stop_resume_Click(object sender, EventArgs e)
        {
            timer_main_area.Enabled = !timer_main_area.Enabled;
        }

        private void trackBar_temperatuere_MouseUp(object sender, MouseEventArgs e)
        {
            trackBar_temperature.Value = 0;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}


