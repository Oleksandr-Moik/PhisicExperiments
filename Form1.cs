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

        private const int BIG_CHANGE = 100;
        private const int SMALL_CHANGE = 50;

        private double StopwatchTime;
        private Flask flask;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flask = flask1;

            numericUpDown_molec_count.Maximum = Flask.MAX_MOLECULES_CAPACITY;
            numericUpDown_temparature_new_molec.Maximum = Flask.MAX_TEAMPERATURE;
            Clear();
            
            flask.SetDeltaMoleculs(5);
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            numericUpDown_temparature_new_molec.Value = Flask.DEFAULT_TEAMPERATURE;
            flask.Clear();

            StopwatchTime = 0;
            DisplayNewProperties();
        }

        private void NumericUpDown_MoleculesCount_ValueChanged(object sender, EventArgs e)
        {
            int current_count = flask.GetMoleculesCount();
            decimal new_value = numericUpDown_molec_count.Value;
            flask.SetDeltaMoleculs(Convert.ToInt32(new_value - current_count));

            DisplayNewProperties();
        }
        private void Buttons_AddRemove_Click(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text;
            if (text.Equals("<") && numericUpDown_molec_count.Value >= SMALL_CHANGE)
            {
                numericUpDown_molec_count.Value -= SMALL_CHANGE;
            }
            else if (text.Equals("<<") && numericUpDown_molec_count.Value >= BIG_CHANGE)
            {
                numericUpDown_molec_count.Value -= BIG_CHANGE;
            }
            else if (text.Equals(">") && numericUpDown_molec_count.Value < numericUpDown_molec_count.Maximum - SMALL_CHANGE)
            {
                numericUpDown_molec_count.Value += SMALL_CHANGE;
            }
            else if (text.Equals(">>") && numericUpDown_molec_count.Value < numericUpDown_molec_count.Maximum - BIG_CHANGE)
            {
                numericUpDown_molec_count.Value += BIG_CHANGE;
            }
        }
        
        private void Button_UpdateStopResume_Click(object sender, EventArgs e)
        {
            if (flask.SwapUpdateTimer())
            {
                button_stop_resume_update.Text = STOP_STR;
            }
            else
            {
                button_stop_resume_update.Text = RESUME_STR;
            }
        }
        private void Timer_UpdateFiels_Tick(object sender, EventArgs e)
        {
            if (flask.GetTimerUpdateEnable())
            {
                button_stop_resume_update.Text = STOP_STR;
            }
            else
            {
                button_stop_resume_update.Text = RESUME_STR;
            }
            DisplayNewProperties();
        }
        private void DisplayNewProperties()
        {
            numericUpDown_molec_count.Value = flask.GetMoleculesCount();
            textBox_temp.Text = FormatDouble(flask.GetAverageTemperature());
            textBox_presure.Text = FormatDouble(flask.GetPressure());
            textBox_mole.Text = FormatDouble(flask.GetMoles());
        }
        private String FormatDouble(double value)
        {
            return String.Format(OUTPUT_DOUBLE_PATTERN, value);
        }

        private void TrackBar_TemperatureChange_Scroll(object sender, EventArgs e)
        {
            flask.SetTemperatureDelta(trackBar_temperature_increment.Value);
        }
        private void TrackBar_TemperatuereChange_MouseUp(object sender, MouseEventArgs e)
        {
            trackBar_temperature_increment.Value = 0;
            flask.SetTemperatureDelta(0);
        }
        private void NumericUpDown_TemparatureNewMolecules_ValueChanged(object sender, EventArgs e)
        {
            flask.SetTemperatureNewMolecules(Convert.ToInt32(numericUpDown_temparature_new_molec.Value));
        }

        private void Timer_Stopwatch_Tick(object sender, EventArgs e)
        {
            StopwatchTime++;
            textBox_stopwatch.Text = Convert.ToString(String.Format("{0,00}", StopwatchTime / 100.0));
        }
        private void Butto_StopwatchStopResume_Click(object sender, EventArgs e)
        {
            timer_stopwatch.Enabled = !timer_stopwatch.Enabled;
            if (timer_stopwatch.Enabled)
            {
                button_stop_resume_stopwatch.Text = STOP_STR;
            }
            else
            {
                button_stop_resume_stopwatch.Text = RESUME_STR;
            }
        }
        private void Button_StopwatchRestart_Click(object sender, EventArgs e)
        {
            StopwatchTime = 0;
            textBox_stopwatch.Text = "";
            timer_stopwatch.Enabled = false;
            button_stop_resume_stopwatch.Text = START_STR;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}