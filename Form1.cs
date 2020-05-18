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

        private void Clear()
        {
            numericUpDown_temparature_new_molec.Value = Flask.DEFAULT_TEAMPERATURE;
            flask.Clear();
            
            StopwatchTime = 0;
            DisplayNewProperties();
        }

        private String FormatDouble(double value)
        {
            return String.Format(OUTPUT_DOUBLE_PATTERN, value);
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
        private void numericUpDown_molec_count_ValueChanged(object sender, EventArgs e)
        {
            int current_count = flask.GetCountMolecules();
            decimal new_value = numericUpDown_molec_count.Value;
            flask.SetDeltaMoleculs(Convert.ToInt32(new_value - current_count));

            DisplayNewProperties();
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DisplayNewProperties()
        {
            numericUpDown_molec_count.Value = flask.GetCountMolecules();
            textBox_temp.Text = FormatDouble(flask.GetAverageTemperature());
            textBox_presure.Text = FormatDouble(flask.GetPressure());
            textBox_mole.Text = FormatDouble(flask.GetMoles());
        }

        private void trackBar_temperature_increment_Scroll(object sender, EventArgs e)
        {
            flask.SetTemperatureDelta(trackBar_temperature_increment.Value);
        }
        private void trackBar_temperatuere_MouseUp(object sender, MouseEventArgs e)
        {
            trackBar_temperature_increment.Value = 0;
            flask.SetTemperatureDelta(0);
        }

        private void button_stop_resume_update_Click(object sender, EventArgs e)
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
        private void numericUpDown_temparature_new_molec_ValueChanged(object sender, EventArgs e)
        {
            flask.SetTemperatureNewMolecules(Convert.ToInt32(numericUpDown_temparature_new_molec.Value));
        }

        private void timer_update_fiels_Tick(object sender, EventArgs e)
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_stop_resume_stopwatch_Click(object sender, EventArgs e)
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
        private void timer_stopwartch_Tick(object sender, EventArgs e)
        {
            StopwatchTime++;
            textBox_stopwatch.Text = Convert.ToString(String.Format("{0,00}", StopwatchTime / 100.0));
        }
        private void button_reset_stopwatch_Click(object sender, EventArgs e)
        {
            StopwatchTime = 0;
            textBox_stopwatch.Text = "";
            timer_stopwatch.Enabled = false;
            button_stop_resume_stopwatch.Text = START_STR;
        }

    }
}