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
        private int MAX_MOLEC_CAPACITY = 50000;

        private int MAX_PRESURE = 10;

        private int MAX_TEMPR = 3000;
        private int DEFAULT_TEMPR = 500;

        private int MIN_AREA_WIDTH = 150;
        private int MAX_AREA_WIDTH = 500;

        private double Depth = 0.1e-23;
        /// avogadro number
        private double N_A = 6.02e+23;
        /// universe gas constant
        private double R = 8.31;

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

            SetDefaults();
        }

        private void SetDefaults()
        {
            numericUpDown_temparature.Value = DEFAULT_TEMPR;

            SMolec.Clear();

            Volume = panel1.Height * panel1.Width * Depth;
            Tempreture = 0;
            Total_Weight = 0;
            Presure = 0;
            Stopwatch_time = 0;
            UpdateValues();

            //timer_main_area.Enabled = false;
            //timer_stopwartch.Enabled = false;
            for (int i = 0; i < 1; i++)
                AddMolec();
            RedrawArea();
        }



        // get value from temp new molecul
        private double GetTemperatureNewMolec()
        {
            return Convert.ToDouble(numericUpDown_temparature.Value);
        }

        // add new molec
        private void button_add_molec_Click(object sender, EventArgs e)
        {

        }

        private void AddMolec()
        {
            if (SMolec.Count < MAX_MOLEC_CAPACITY)
            {
                Random rand = new Random();

                double temperature = GetTemperatureNewMolec();
                Vector vector = new Vector(rand.NextDouble() - 0.5, rand.NextDouble() - 0.5);
                Point point = new Point(rand.Next(30, 420), rand.Next(30, 270));

                Molecula m = new Molecula(point, temperature, vector);
                SMolec.Push(m);
                
                RedrawArea();
            }
        }

        // remove
        private void button_remove_molec_Click(object sender, EventArgs e)
        {
            RemoveMolec();
        }

        private void RemoveMolec()
        {
            if (SMolec.Count != 0)
            {
                SMolec.Pop();
            }

            RedrawArea();
        }

        //clear
        private void button_clear_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }


        private void numericUpDown_molec_count_ValueChanged(object sender, EventArgs e)
        {
            //timer_main_area.Enabled = true;

            int current_count = SMolec.Count;
            decimal new_value = numericUpDown_molec_count.Value;

            if (new_value > current_count)
            {
                AddMolec();
            }
            else if (new_value < current_count)
            {
                RemoveMolec();
            }
        }

        private void button_next_step_Click(object sender, EventArgs e)
        {
            if (!timer_main_area.Enabled)
            {
                RedrawArea();
            }
        }

        // display molec
        // draw elips
        // move (calc new location) every molec
        private void RedrawArea()
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(bm);
            gr.Clear(Color.FromArgb(255, 255, 192));

            int heigh = panel1.Height;
            int width = panel1.Width;
            int new_x, new_y;
            int step = 20;

            Rectangle rect;

            try
            {
                foreach (Molecula m in SMolec)
                {
                    if (timer_main_area.Enabled)
                    {
                        Vector vec = m.GetVector();
                        Point loc = m.GetLocation();

                        new_x = (int)Math.Round(loc.X + (step * vec.X));
                        if ((new_x < 0 + step / 2) || (new_x > width - step / 2))
                        {
                            vec.X = -vec.X;
                        }


                        new_y = (int)Math.Round(loc.Y + (step * vec.Y));
                        if ((new_y < 0 + step / 2) || (new_y > heigh - step / 2))
                        {
                            vec.Y = -vec.Y;
                        }

                        m.SetLocation(new_x, new_y);
                    }

                    rect = new Rectangle(m.GetX(), m.GetY(), 10, 10);
                    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(133, 0, 133));
                    gr.FillEllipse(solidBrush, rect);
                    //gr.FillEllipse(new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))), rect);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                RedrawArea();
                return;
            }
            panel1.BackgroundImage = bm;
        }

        private void timer_main_area_Tick(object sender, EventArgs e)
        {
            if (SMolec.Count != 0)
            {
                Thread th = new Thread(RedrawArea);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                timer_main_area.Enabled = false;
            }
        }
        private void ChangeTextEnablesArea()
        {
            if (timer_main_area.Enabled)
            {
                button_stop_resume.Text = "Зупинити";
            }
            else
            {
                button_stop_resume.Text = "Продовжити";
            }
        }

        private void UpdateValues()
        {
            CalcValues();
            numericUpDown_molec_count.Text = FormatDouble(SMolec.Count); // кількість молекул
            textBox_temp.Text = FormatDouble(Tempreture); // температура
            textBox_presure.Text = FormatDouble(Presure); // тиск
        }

        private void CalcValues()
        {
            CalcAvaregeTemperature();
            CalcPresure();
        }

        private String FormatDouble(double value)
        {
            return String.Format("{0:0.00}", value);
        }

        private void CalcPresure()
        {
            double mole = SMolec.Count / N_A * 0.1e+25;
            textBox_mole.Text = FormatDouble(mole);

            Presure = SMolec.Count * 1.83e-23 * Tempreture / Volume;
            //Presure = (mole * R * Tempreture) / (Volume);
        }

        private void CalcAvaregeTemperature()
        {
            if (SMolec.Count != 0)
            {
                double calc = SMolec.Peek().GetTemperature();
                foreach (Molecula m in SMolec)
                {
                    calc = (calc + m.GetTemperature()) / 2;
                }
                Tempreture = calc;
            }
            else
            {
                Tempreture = 0;
            }
        }

        #region exit methods
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
        #endregion

        #region stopwatch
        private void button_stop_resume_stopwatch_Click(object sender, EventArgs e)
        {
            timer_stopwartch.Enabled = !timer_stopwartch.Enabled;
        }

        private void timer_stopwartch_Tick(object sender, EventArgs e)
        {
            Stopwatch_time++;
            textBox_stopwatch.Text = Convert.ToString(String.Format("{0,00}", Stopwatch_time / 100.0));
        }

        private void button_reset_stopwatch_Click(object sender, EventArgs e)
        {
            Stopwatch_time = 0;
            textBox_stopwatch.Text = "";
            timer_stopwartch.Enabled = false;
        }
        private void ChangeTextEnablesStopwatch()
        {
            if (timer_stopwartch.Enabled)
            {
                button_stop_resume_stopwatch.Text = "Зупинити";
            }
            else
            {
                button_stop_resume_stopwatch.Text = "Відновити";
            }
        }
        #endregion

        private void timer_ui_update_Tick(object sender, EventArgs e)
        {
            UpdateValues();
            ChangeTextEnablesStopwatch();
            ChangeTextEnablesArea();
        }
    }


}


