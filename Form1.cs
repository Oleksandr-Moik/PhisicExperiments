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
        private const String OUTPUT_DOUBLE_PATTERN = "{0:0.00}";
        private const String RESUME_STR = "Відновити";
        private const String STOP_STR = "Зупинити";
        private const String START_STR = "Почати";

        private const int MAX_MOLEC_CAPACITY = 50000;
        private const int MAX_TEMPR = 3000;
        private const int DEFAULT_TEMPR = 300;

        private const double Depth = 0.1e-23;

        private Stack<Molecula> SMolec;

        private double Volume;
        private double AverageTemperature;

        private double Stopwatch_time;
        Bitmap bm;// = new Bitmap(panel1.Width, panel1.Height);

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
            timer_ui_update.Enabled = false;

            numericUpDown_temparature.Value = DEFAULT_TEMPR;

            SMolec.Clear();

            Volume = panel1.Height * panel1.Width * Depth;
            AverageTemperature = 0;
            Stopwatch_time = 0;

            for (int i = 0; i < 5; i++) AddMolec();
            
            DisplayNewProperties();
            RedrawArea();

            timer_ui_update.Enabled = true;
        }

        private int MinusOrPlus()
        {
            Random rand = new Random(2);
            if (rand.NextDouble() - 0.5 > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private String FormatDouble(double value)
        {
            return String.Format(OUTPUT_DOUBLE_PATTERN, value);
        }

        private void numericUpDown_molec_count_ValueChanged(object sender, EventArgs e)
        {
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
            DisplayNewProperties();
        }

        private void AddMolec()
        {
            if (SMolec.Count < MAX_MOLEC_CAPACITY)
            {
                Random rand = new Random();

                double temperature = Convert.ToDouble(numericUpDown_temparature.Value);

                double vecX = rand.NextDouble() - 0.5;
                Vector vector = new Vector(vecX * MinusOrPlus(), (1-vecX) * MinusOrPlus());
                int borders = 30;
                Point point = new Point(rand.Next(borders, panel1.Width- borders), rand.Next(borders, panel1.Height- borders));

                Molecula m = new Molecula(point, temperature, vector);
                SMolec.Push(m);

                RedrawArea();
            }
        }

        private void RemoveMolec()
        {
            if (SMolec.Count != 0)
            {
                SMolec.Pop();
                RedrawArea();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void RedrawArea()
        {
            bm = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(bm);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(133, 0, 133));
            //gr.Clear(Color.FromArgb(255, 255, 192));

            Rectangle rect;
            try
            {
                foreach (Molecula m in SMolec)
                {
                    if (timer_main_area.Enabled)
                    {
                        m.SetLocation(NextLocation(m));
                    }

                    rect = new Rectangle(m.GetX(), m.GetY(), 10, 10);
                    gr.FillEllipse(solidBrush, rect);
                }
                panel1.BackgroundImage = bm;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                RedrawArea();
                return;
            }
        }

        private Point NextLocation(Molecula m)
        {
            int heigh = panel1.Height;
            int width = panel1.Width;
            int step = 5;

            Vector vec = m.GetVector();
            Point loc = m.GetLocation();

            int new_x = (int)Math.Round(loc.X + (step * vec.X));
            if ((new_x < 0 + step / 2) || (new_x > width - step / 2))
            {
                vec.X = -vec.X;
            }

            int new_y = (int)Math.Round(loc.Y + (step * vec.Y));
            if ((new_y < 0 + step / 2) || (new_y > heigh - step / 2))
            {
                vec.Y = -vec.Y;
            }

            return new Point(new_x, new_y);
        }

        private void timer_main_area_Tick(object sender, EventArgs e)
        {
            if (SMolec.Count != 0)
            {
                Thread th = new Thread(RedrawArea);
                th.IsBackground = true;
                th.Start();
                button_stop_resume.Text = "Зупинити";
            }
            else
            {
                timer_main_area.Enabled = false;
                button_stop_resume.Text = "Продовжити";
            }
        }

        private void DisplayNewProperties()
        {
            AverageTemperature = CalcAvaregeTemperature();
            SetMolcTemperature();

            numericUpDown_molec_count.Text = FormatDouble(SMolec.Count); // кількість молекул
            textBox_temp.Text = FormatDouble(AverageTemperature); // температура
            textBox_presure.Text = FormatDouble(PhisicCalc.CalcPresure(SMolec.Count, AverageTemperature, Volume));
            textBox_mole.Text = FormatDouble(PhisicCalc.CalcMole(SMolec.Count));

        }

        private void SetMolcTemperature()
        {
            foreach(Molecula m in SMolec)
               m.SetTemperature(AverageTemperature);
        }

        private void ChanegeTemperature()
        {
            if(AverageTemperature<=MAX_TEMPR && AverageTemperature >= 0)
            {
                AverageTemperature += delta;
            }
            if (AverageTemperature < 0) AverageTemperature = 0;
            SetMolcTemperature();
        }

        

        private double CalcAvaregeTemperature()
        {
            if (SMolec.Count != 0)
            {
                double calc = 0;// SMolec.Peek().GetTemperature();
                foreach (Molecula m in SMolec)
                {
                    calc += m.GetTemperature();
                }
                calc = calc / SMolec.Count;
                return calc;
            }
            else
            {
                return 0;
            }
        }

        private void timer_ui_update_Tick(object sender, EventArgs e)
        {
            if (timer_main_area.Enabled)
            {
                ChanegeTemperature();
                DisplayNewProperties();
            }
        }
        double delta;
        private void trackBar_temperature_Scroll(object sender, EventArgs e)
        {
            delta = trackBar_temperature.Value;
        }

  

 

        #region exit methods
        private void button_stop_resume_Click(object sender, EventArgs e)
        {
            timer_main_area.Enabled = !timer_main_area.Enabled;

            if (timer_main_area.Enabled)
            {
                button_stop_resume.Text = "Зупинити";
            }
            else
            {
                button_stop_resume.Text = "Продовжити";
            }
        }

        private void trackBar_temperatuere_MouseUp(object sender, MouseEventArgs e)
        {
            trackBar_temperature.Value = 0;
            delta = 0;
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
            if (timer_stopwartch.Enabled)
            {
                button_stop_resume_stopwatch.Text = "Зупинити";
            }
            else
            {
                button_stop_resume_stopwatch.Text = "Відновити";
            }
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
            button_stop_resume_stopwatch.Text = "Відновити";
        }
        #endregion

        
    }


}


