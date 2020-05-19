using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PhisicExperiments
{
    public partial class Flask : UserControl
    {
     
        public static decimal MAX_MOLECULES_CAPACITY = 20000;
        public static int MAX_TEAMPERATURE = 6000;
        public static int DEFAULT_TEAMPERATURE = 300;
        public static int MAX_TEMPERATURE_COLOR = 3000;
        public static double Depth = 0.1e-23;

        private Stack<Molecule> StMolecules;
        private double AverageTemperature;
        private double TemperatureChangeDelta;
        private double TemperatureNewMolecules;
        private int CountForAddRemoveMolecules;

        public Flask()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            StMolecules = new Stack<Molecule>();

            ChangeMoleculesCount();
            DisplayMolecules();
            Timer_Update.Enabled = true;
        }

        public int GetMoleculesCount()
        {
            return StMolecules.Count;
        }
       
        public double GetVolume()
        {
            return Height * Width * Depth;
        }
        public double GetPressure()
        {
            return PhisicCalculating.CalculatePressure(GetMoleculesCount(), GetAverageTemperature(), GetVolume());
        }
        public double GetMoles()
        {
            return PhisicCalculating.CalculateMoles(GetMoleculesCount());
        }
        public double GetAverageTemperature()
        {
            CalculateAverageTemperature();
            return AverageTemperature;
        }
        
        public void SetTemperatureNewMolecules(double temperature)
        {
            TemperatureNewMolecules = temperature;
        }
        public void SetTemperatureDelta(double delta)
        {
            TemperatureChangeDelta = delta;
        }
        
        private void CalculateAverageTemperature() {
            if (GetMoleculesCount() != 0)
            {
                double calc = 0;
                foreach (Molecule m in StMolecules)
                {
                    calc += m.GetTemperature();
                }
                calc /= GetMoleculesCount();
                AverageTemperature = calc;
            }
            else
            {
                AverageTemperature = 0;
            }
        }

        public void SetDeltaMoleculs(int delta)
        {
            CountForAddRemoveMolecules = delta;
            ChangeMoleculesCount();
        }
        public void ChangeMoleculesCount()
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
                DisplayMolecules();
            }
        }
        private void AddNewMolecule()
        {
            if (StMolecules.Count < MAX_MOLECULES_CAPACITY)
            {
                Random rand1 = new Random(DateTime.Now.Millisecond);

                double vecX = rand1.NextDouble() + 1;
                double vecY = rand1.NextDouble() + 1;
                Vector vector = new Vector(vecX * RandomMinusOrPlus(), vecY * RandomMinusOrPlus());
                int borders = 20;

                Random rand2 = new Random((int)(DateTime.Now.Millisecond * rand1.NextDouble() * 10000));

                Point point = new Point(rand1.Next(borders, Width - borders), rand2.Next(borders, Height - borders));

                Molecule m = new Molecule(point, TemperatureNewMolecules, vector);
                StMolecules.Push(m);
            }
        }
        private int RandomMinusOrPlus()
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
        private void RemoveLastMolecule()
        {
            if (StMolecules.Count != 0)
                StMolecules.Pop();
        }
        
        private void Timer_Update_Tick(object sender, EventArgs e)
        {
            if (StMolecules.Count != 0)
            {
                CalculateAverageTemperature();

                IncreaseOrDecreaseTemperature();
                MoveMolecules();
                DisplayMolecules();
            }
            else
            {
                Timer_Update.Enabled = false;
            }
        }
        public bool GetTimerUpdateEnable()
        {
            return Timer_Update.Enabled;
        }
        public bool SwapUpdateTimer()
        {
            Timer_Update.Enabled = !Timer_Update.Enabled;
            return Timer_Update.Enabled;
        }

        public void DisplayMolecules()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
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
                BackgroundImage = bitmap;
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
        
        public void MoveMolecules()
        {
            if (Timer_Update.Enabled)
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
            double step = 200.0 * AverageTemperature / 1000.0;
            double current_step = step * (Timer_Update.Interval / 1000.0);

            Vector vec = m.GetVector();
            Point loc = m.GetLocation();

            int new_x = (int)Math.Round(loc.X + (current_step * vec.X));
            if ((new_x < 0 + current_step / 2) || (new_x > Width - current_step / 2))
            {
                vec.X = -vec.X;
            }

            int new_y = (int)Math.Round(loc.Y + (current_step * vec.Y));
            if ((new_y < 0 + current_step / 2) || (new_y > Height - current_step / 2))
            {
                vec.Y = -vec.Y;
            }

            return new Point(new_x, new_y);
        }
        
        public void IncreaseOrDecreaseTemperature()
        {
            if (AverageTemperature <= MAX_TEAMPERATURE && AverageTemperature > 0)
            {
                AverageTemperature += TemperatureChangeDelta;
            }
            if (AverageTemperature < 0) AverageTemperature = 0;
            SetAllMoleculesAvarageTemperature();
        }
        public void SetAllMoleculesAvarageTemperature()
        {
            foreach (Molecule m in StMolecules)
                m.SetTemperature(AverageTemperature);
        }
    }
}
