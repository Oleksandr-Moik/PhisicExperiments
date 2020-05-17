namespace PhisicExperiments
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_main_area = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_add_molec = new System.Windows.Forms.Button();
            this.button_remove_molec = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.textBox_total_weight = new System.Windows.Forms.TextBox();
            this.textBox_presure = new System.Windows.Forms.TextBox();
            this.button_stop_resume = new System.Windows.Forms.Button();
            this.trackBar_temperature = new System.Windows.Forms.TrackBar();
            this.timer_stopwartch = new System.Windows.Forms.Timer(this.components);
            this.button_stop_resume_stopwatch = new System.Windows.Forms.Button();
            this.button_reset_stopwatch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_molec_count = new System.Windows.Forms.NumericUpDown();
            this.textBox_stopwatch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.numericUpDown_temparature = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temperature)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temparature)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem,
            this.toolStripSeparator1,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // timer_main_area
            // 
            this.timer_main_area.Enabled = true;
            this.timer_main_area.Interval = 300;
            this.timer_main_area.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "total weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість молекул";
            // 
            // button_add_molec
            // 
            this.button_add_molec.Location = new System.Drawing.Point(661, 130);
            this.button_add_molec.Name = "button_add_molec";
            this.button_add_molec.Size = new System.Drawing.Size(100, 23);
            this.button_add_molec.TabIndex = 5;
            this.button_add_molec.Text = "Додати";
            this.button_add_molec.UseVisualStyleBackColor = true;
            this.button_add_molec.Click += new System.EventHandler(this.button_add_molec_Click);
            // 
            // button_remove_molec
            // 
            this.button_remove_molec.Location = new System.Drawing.Point(661, 159);
            this.button_remove_molec.Name = "button_remove_molec";
            this.button_remove_molec.Size = new System.Drawing.Size(100, 23);
            this.button_remove_molec.TabIndex = 6;
            this.button_remove_molec.Text = "Забрати";
            this.button_remove_molec.UseVisualStyleBackColor = true;
            this.button_remove_molec.Click += new System.EventHandler(this.button_remove_molec_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(472, 439);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(108, 37);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 8;
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(26, 60);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.ReadOnly = true;
            this.textBox_temp.Size = new System.Drawing.Size(100, 22);
            this.textBox_temp.TabIndex = 9;
            this.textBox_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_total_weight
            // 
            this.textBox_total_weight.Location = new System.Drawing.Point(593, 63);
            this.textBox_total_weight.Name = "textBox_total_weight";
            this.textBox_total_weight.ReadOnly = true;
            this.textBox_total_weight.Size = new System.Drawing.Size(100, 22);
            this.textBox_total_weight.TabIndex = 10;
            // 
            // textBox_presure
            // 
            this.textBox_presure.Location = new System.Drawing.Point(285, 38);
            this.textBox_presure.Name = "textBox_presure";
            this.textBox_presure.ReadOnly = true;
            this.textBox_presure.Size = new System.Drawing.Size(253, 22);
            this.textBox_presure.TabIndex = 11;
            this.textBox_presure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_stop_resume
            // 
            this.button_stop_resume.Location = new System.Drawing.Point(26, 421);
            this.button_stop_resume.Name = "button_stop_resume";
            this.button_stop_resume.Size = new System.Drawing.Size(110, 52);
            this.button_stop_resume.TabIndex = 0;
            this.button_stop_resume.Text = "Продовжити/Зупинити";
            this.button_stop_resume.UseVisualStyleBackColor = true;
            this.button_stop_resume.Click += new System.EventHandler(this.button_stop_resume_Click);
            // 
            // trackBar_temperature
            // 
            this.trackBar_temperature.LargeChange = 2;
            this.trackBar_temperature.Location = new System.Drawing.Point(6, 21);
            this.trackBar_temperature.Maximum = 5;
            this.trackBar_temperature.Minimum = -5;
            this.trackBar_temperature.Name = "trackBar_temperature";
            this.trackBar_temperature.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_temperature.Size = new System.Drawing.Size(45, 90);
            this.trackBar_temperature.TabIndex = 13;
            this.trackBar_temperature.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_temperatuere_MouseUp);
            // 
            // timer_stopwartch
            // 
            this.timer_stopwartch.Interval = 10;
            this.timer_stopwartch.Tick += new System.EventHandler(this.timer_stopwartch_Tick);
            // 
            // button_stop_resume_stopwatch
            // 
            this.button_stop_resume_stopwatch.Location = new System.Drawing.Point(19, 62);
            this.button_stop_resume_stopwatch.Name = "button_stop_resume_stopwatch";
            this.button_stop_resume_stopwatch.Size = new System.Drawing.Size(75, 44);
            this.button_stop_resume_stopwatch.TabIndex = 14;
            this.button_stop_resume_stopwatch.Text = "Почати/Зупини";
            this.button_stop_resume_stopwatch.UseVisualStyleBackColor = true;
            this.button_stop_resume_stopwatch.Click += new System.EventHandler(this.button_stop_resume_stopwatch_Click);
            // 
            // button_reset_stopwatch
            // 
            this.button_reset_stopwatch.Location = new System.Drawing.Point(100, 62);
            this.button_reset_stopwatch.Name = "button_reset_stopwatch";
            this.button_reset_stopwatch.Size = new System.Drawing.Size(94, 44);
            this.button_reset_stopwatch.TabIndex = 15;
            this.button_reset_stopwatch.Text = "Скинути";
            this.button_reset_stopwatch.UseVisualStyleBackColor = true;
            this.button_reset_stopwatch.Click += new System.EventHandler(this.button_reset_stopwatch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBar_temperature);
            this.groupBox1.Location = new System.Drawing.Point(276, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Температура";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Охолодити";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Нагріти";
            // 
            // numericUpDown_molec_count
            // 
            this.numericUpDown_molec_count.Location = new System.Drawing.Point(555, 131);
            this.numericUpDown_molec_count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_molec_count.Name = "numericUpDown_molec_count";
            this.numericUpDown_molec_count.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_molec_count.TabIndex = 17;
            this.numericUpDown_molec_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_stopwatch
            // 
            this.textBox_stopwatch.Location = new System.Drawing.Point(19, 36);
            this.textBox_stopwatch.Name = "textBox_stopwatch";
            this.textBox_stopwatch.ReadOnly = true;
            this.textBox_stopwatch.Size = new System.Drawing.Size(106, 22);
            this.textBox_stopwatch.TabIndex = 18;
            this.textBox_stopwatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button_reset_stopwatch);
            this.groupBox2.Controls.Add(this.textBox_stopwatch);
            this.groupBox2.Controls.Add(this.button_stop_resume_stopwatch);
            this.groupBox2.Location = new System.Drawing.Point(555, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Секундомір";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "с";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(662, 497);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(93, 45);
            this.button_exit.TabIndex = 20;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // numericUpDown_temparature
            // 
            this.numericUpDown_temparature.Location = new System.Drawing.Point(685, 207);
            this.numericUpDown_temparature.Name = "numericUpDown_temparature";
            this.numericUpDown_temparature.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown_temparature.TabIndex = 21;
            this.numericUpDown_temparature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(552, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 41);
            this.label8.TabIndex = 22;
            this.label8.Text = "Температура нових молекул";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "К";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Па";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 551);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_temparature);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown_molec_count);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_stop_resume);
            this.Controls.Add(this.textBox_presure);
            this.Controls.Add(this.textBox_total_weight);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_remove_molec);
            this.Controls.Add(this.button_add_molec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Газові ізопроцеси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temperature)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temparature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.Timer timer_main_area;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_add_molec;
        private System.Windows.Forms.Button button_remove_molec;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.TextBox textBox_total_weight;
        private System.Windows.Forms.TextBox textBox_presure;
        private System.Windows.Forms.Button button_stop_resume;
        private System.Windows.Forms.TrackBar trackBar_temperature;
        private System.Windows.Forms.Timer timer_stopwartch;
        private System.Windows.Forms.Button button_stop_resume_stopwatch;
        private System.Windows.Forms.Button button_reset_stopwatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_molec_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_stopwatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.NumericUpDown numericUpDown_temparature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

