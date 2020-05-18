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

        private const int MAX_MOLECULES_CAPACITY = 10000;
        private const int MAX_TEAMPERATURE = 13000;
        private const int DEFAULT_TEAMPERATURE = 300;
        private const int MAX_TEMPERATURE_COLOR = 4000;
        private const double Depth = 0.1e-23;

        private Stack<Molecule> StMolecules;
        private double Volume;
        private double AverageTemperature;
        private double StopwatchTime;
        private double TemperatureChangeDelta;
        private decimal CountForAddRemoveMolecules;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown_molec_count.Maximum = MAX_MOLECULES_CAPACITY;
            numericUpDown_temparature.Maximum = MAX_TEAMPERATURE;
            CountForAddRemoveMolecules = 5;

            DefaultValues();
        }

        private void DefaultValues()
        {
            timed_add_remove_molecules.Enabled = false;

            numericUpDown_temparature.Value = DEFAULT_TEAMPERATURE;

            StMolecules = new Stack<Molecule>();

            Volume = panel1.Height * panel1.Width * Depth;
            AverageTemperature = 0;
            StopwatchTime = 0;

            //timed_add_remove_molecules.Enabled = true;
            ch();
            DisplayNewProperties();
            DisplayMolecules();

            timer_main_area.Enabled = true;
        }

        private int MinusOrPlus()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
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
            decimal current_count = StMolecules.Count;
            decimal new_value = numericUpDown_molec_count.Value;
            CountForAddRemoveMolecules = new_value - current_count;

            ch();
            //timed_add_remove_molecules.Enabled = true;
        }

        private void timer_add_remove_molecules_Tick(object sender, EventArgs e)
        {
            if (CountForAddRemoveMolecules != 0)
            {

            }
            else
            {
                timed_add_remove_molecules.Enabled = false;
            }
            DisplayNewProperties();
        }

        private void ch()
        {
            while (CountForAddRemoveMolecules != 0)
            {
                if (CountForAddRemoveMolecules < 0)
                {
                    RemoveLastMolecule();
                    CountForAddRemoveMolecules++;
                }
                else
                {
                    AddNewMolecule();
                    CountForAddRemoveMolecules--;
                }
            }
            DisplayNewProperties();
        }

        private void Buttons_add_remove_Click(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text;
            int big = 15;
            int small = 1;
            if (text.Equals("<") && numericUpDown_molec_count.Value >= small)
            {
                numericUpDown_molec_count.Value -= small;
            }
            else if (text.Equals("<<") && numericUpDown_molec_count.Value >= big)
            {
                numericUpDown_molec_count.Value -= big;
            }
            else if (text.Equals(">") && numericUpDown_molec_count.Value < numericUpDown_molec_count.Maximum - small)
            {
                numericUpDown_molec_count.Value += small;
            }
            else if (text.Equals(">>") && numericUpDown_molec_count.Value < numericUpDown_molec_count.Maximum - big)
            {
                numericUpDown_molec_count.Value += big;
            }
        }


        private void AddNewMolecule()
        {
            if (StMolecules.Count < MAX_MOLECULES_CAPACITY)
            {
                Random rand1 = new Random(DateTime.Now.Millisecond);

                double vecX = rand1.NextDouble() + 1;
                double vecY = rand1.NextDouble() + 1;
                Vector vector = new Vector(vecX * MinusOrPlus(), vecY * MinusOrPlus());
                int borders = 30;

                Random rand2 = new Random((int)(DateTime.Now.Millisecond * rand1.NextDouble() * 10000));

                double temperature = Convert.ToDouble(numericUpDown_temparature.Value);

                Point point = new Point(rand1.Next(borders, panel1.Width - borders), rand2.Next(borders, panel1.Height - borders));

                Molecule m = new Molecule(point, temperature, vector);
                StMolecules.Push(m);

                DisplayMolecules();
            }
        }

        private void RemoveLastMolecule()
        {
            if (StMolecules.Count != 0)
            {
                StMolecules.Pop();
                DisplayMolecules();
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            DefaultValues();
        }

        private void timer_main_area_Tick(object sender, EventArgs e)
        {
            if (StMolecules.Count != 0)
            {
                if (AverageTemperature != 0)
                {
                    Thread th = new Thread(DisplayAndMoveMolecules);
                    th.IsBackground = true;
                    th.Start();
                    button_stop_resume.Text = STOP_STR;
                }
                IncreaseOrDecreaseTemperature();
                DisplayNewProperties();
            }
            else
            {
                timer_main_area.Enabled = false;
                button_stop_resume.Text = RESUME_STR;
            }
        }

        private void DisplayNewProperties()
        {
            AverageTemperature = GetAvarageTemperature();
            SetAllMoleculasAvarageTemperature();

            numericUpDown_molec_count.Value = StMolecules.Count;

            textBox_temp.Text = FormatDouble(AverageTemperature);
            textBox_presure.Text = FormatDouble(PhisicCalculating.CalculatePressure(StMolecules.Count, AverageTemperature, Volume));
            textBox_mole.Text = FormatDouble(PhisicCalculating.CalculateMoles(StMolecules.Count));

        }

        private void DisplayAndMoveMolecules()
        {
            MoveMolecules();
            DisplayMolecules();
        }

        private void DisplayMolecules()
        {
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            SolidBrush solidBrush = new SolidBrush(TemperatureToColor());
            //gr.Clear(Color.FromArgb(255, 255, 192));

            Rectangle rect;
            try
            {
                foreach (Molecule m in StMolecules)
                {
                    rect = new Rectangle(m.GetX(), m.GetY(), 10, 10);
                    gr.FillEllipse(solidBrush, rect);
                }
                panel1.BackgroundImage = bitmap;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                DisplayMolecules();
                return;
            }
        }

        private Color TemperatureToColor()
        {
            double halfmax = (MAX_TEMPERATURE_COLOR) / 2;
            if (0 <= AverageTemperature && AverageTemperature <= halfmax)
            {
                int r = 0;

                int g = (int)(255.0 / halfmax * AverageTemperature);
                int b = (int)(255.0 - (255.0 / halfmax * AverageTemperature));
                return Color.FromArgb(r, g, b);
            }
            else if (halfmax < AverageTemperature && AverageTemperature <= MAX_TEMPERATURE_COLOR)
            {
                int r = (int)(255.0 / (MAX_TEMPERATURE_COLOR - halfmax) * (AverageTemperature - halfmax));
                int g = (int)(255.0 - (255.0 / (MAX_TEMPERATURE_COLOR - halfmax) * (AverageTemperature - halfmax)));
                int b = 0;
                return Color.FromArgb(r, g, b);
            }
            else
            {
                return Color.FromArgb(255, 0, 0);
            }
        }

        private void MoveMolecules()
        {
            if (timer_main_area.Enabled)
            {
                try
                {
                    foreach (Molecule m in StMolecules)
                    {
                        m.SetLocation(NextMoleculeLocation(m));
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.StackTrace);
                    MoveMolecules();
                    return;
                }
            }
        }

        private Point NextMoleculeLocation(Molecule m)
        {
            int heigh = panel1.Height;
            int width = panel1.Width;
            double step = 200.0 * AverageTemperature / 1000.0;
            double current_step = step * (timer_main_area.Interval / 1000.0);

            Vector vec = m.GetVector();
            Point loc = m.GetLocation();

            int new_x = (int)Math.Round(loc.X + (current_step * vec.X));
            if ((new_x < 0 + current_step / 2) || (new_x > width - current_step / 2))
            {
                vec.X = -vec.X;
            }

            int new_y = (int)Math.Round(loc.Y + (current_step * vec.Y));
            if ((new_y < 0 + current_step / 2) || (new_y > heigh - current_step / 2))
            {
                vec.Y = -vec.Y;
            }

            return new Point(new_x, new_y);
        }

        private void SetAllMoleculasAvarageTemperature()
        {
            foreach (Molecule m in StMolecules)
                m.SetTemperature(AverageTemperature);
        }

        private void IncreaseOrDecreaseTemperature()
        {
            if (AverageTemperature <= MAX_TEAMPERATURE && AverageTemperature >= 0)
            {
                AverageTemperature += TemperatureChangeDelta;
            }
            if (AverageTemperature < 0) AverageTemperature = 0;
            SetAllMoleculasAvarageTemperature();
        }

        private double GetAvarageTemperature()
        {
            if (StMolecules.Count != 0)
            {
                double calc = 0;
                foreach (Molecule m in StMolecules)
                {
                    calc += m.GetTemperature();
                }
                calc /= StMolecules.Count;
                return calc;
            }
            else
            {
                return 0;
            }
        }

        private void trackBar_temperature_Scroll(object sender, EventArgs e)
        {
            TemperatureChangeDelta = trackBar_temperature.Value;
        }

        private void button_stop_resume_Click(object sender, EventArgs e)
        {
            timer_main_area.Enabled = !timer_main_area.Enabled;

            if (timer_main_area.Enabled)
            {
                button_stop_resume.Text = STOP_STR;
            }
            else
            {
                button_stop_resume.Text = RESUME_STR;
            }
        }

        private void trackBar_temperatuere_MouseUp(object sender, MouseEventArgs e)
        {
            trackBar_temperature.Value = 0;
            TemperatureChangeDelta = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_stop_resume_stopwatch_Click(object sender, EventArgs e)
        {
            timer_stopwartch.Enabled = !timer_stopwartch.Enabled;
            if (timer_stopwartch.Enabled)
            {
                button_stop_resume_stopwatch.Text = STOP_STR;
            }
            else
            {
                button_stop_resume_stopwatch.Text = RESUME_STR;
            }
        }

        private void timer_stopwartch_Tick(object sender, EventArgs e)
        {
            StopwatchTime++;
            textBox_stopwatch.Text = Convert.ToString(String.Format("{0,00}", StopwatchTime / 100.0));
        }

        private void button_reset_stopwatch_Click(object sender, EventArgs e)
        {
            StopwatchTime = 0;
            textBox_stopwatch.Text = "";
            timer_stopwartch.Enabled = false;
            button_stop_resume_stopwatch.Text = START_STR;
        }
    }
}

