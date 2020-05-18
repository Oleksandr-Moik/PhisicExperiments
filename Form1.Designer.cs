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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.textBox_mole = new System.Windows.Forms.TextBox();
            this.textBox_presure = new System.Windows.Forms.TextBox();
            this.button_stop_resume_update = new System.Windows.Forms.Button();
            this.trackBar_temperature_increment = new System.Windows.Forms.TrackBar();
            this.timer_stopwatch = new System.Windows.Forms.Timer(this.components);
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
            this.numericUpDown_temparature_new_molec = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_molecules_delta = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_updata_fiels = new System.Windows.Forms.Timer(this.components);
            this.flask1 = new PhisicExperiments.Flask();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temperature_increment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temparature_new_molec)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
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
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість речовини";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість молекул";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(54, 99);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(96, 26);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flask1);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 314);
            this.panel1.TabIndex = 8;
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(10, 44);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.ReadOnly = true;
            this.textBox_temp.Size = new System.Drawing.Size(100, 22);
            this.textBox_temp.TabIndex = 9;
            this.textBox_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_mole
            // 
            this.textBox_mole.Location = new System.Drawing.Point(159, 44);
            this.textBox_mole.Name = "textBox_mole";
            this.textBox_mole.ReadOnly = true;
            this.textBox_mole.Size = new System.Drawing.Size(100, 22);
            this.textBox_mole.TabIndex = 10;
            this.textBox_mole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_presure
            // 
            this.textBox_presure.Location = new System.Drawing.Point(334, 44);
            this.textBox_presure.Name = "textBox_presure";
            this.textBox_presure.ReadOnly = true;
            this.textBox_presure.Size = new System.Drawing.Size(100, 22);
            this.textBox_presure.TabIndex = 11;
            this.textBox_presure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_stop_resume_updata
            // 
            this.button_stop_resume_update.Location = new System.Drawing.Point(10, 22);
            this.button_stop_resume_update.Name = "button_stop_resume_updata";
            this.button_stop_resume_update.Size = new System.Drawing.Size(110, 36);
            this.button_stop_resume_update.TabIndex = 0;
            this.button_stop_resume_update.Text = "Зупинити";
            this.button_stop_resume_update.UseVisualStyleBackColor = true;
            this.button_stop_resume_update.Click += new System.EventHandler(this.button_stop_resume_update_Click);
            // 
            // trackBar_temperature
            // 
            this.trackBar_temperature_increment.LargeChange = 2;
            this.trackBar_temperature_increment.Location = new System.Drawing.Point(6, 21);
            this.trackBar_temperature_increment.Maximum = 5;
            this.trackBar_temperature_increment.Minimum = -5;
            this.trackBar_temperature_increment.Name = "trackBar_temperature";
            this.trackBar_temperature_increment.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_temperature_increment.Size = new System.Drawing.Size(45, 90);
            this.trackBar_temperature_increment.TabIndex = 13;
            this.trackBar_temperature_increment.Scroll += new System.EventHandler(this.trackBar_temperature_increment_Scroll);
            this.trackBar_temperature_increment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_temperatuere_MouseUp);
            // 
            // timer_stopwartch
            // 
            this.timer_stopwatch.Interval = 10;
            this.timer_stopwatch.Tick += new System.EventHandler(this.timer_stopwartch_Tick);
            // 
            // button_stop_resume_stopwatch
            // 
            this.button_stop_resume_stopwatch.Location = new System.Drawing.Point(6, 49);
            this.button_stop_resume_stopwatch.Name = "button_stop_resume_stopwatch";
            this.button_stop_resume_stopwatch.Size = new System.Drawing.Size(104, 35);
            this.button_stop_resume_stopwatch.TabIndex = 14;
            this.button_stop_resume_stopwatch.Text = "Почати";
            this.button_stop_resume_stopwatch.UseVisualStyleBackColor = true;
            this.button_stop_resume_stopwatch.Click += new System.EventHandler(this.button_stop_resume_stopwatch_Click);
            // 
            // button_reset_stopwatch
            // 
            this.button_reset_stopwatch.Location = new System.Drawing.Point(116, 49);
            this.button_reset_stopwatch.Name = "button_reset_stopwatch";
            this.button_reset_stopwatch.Size = new System.Drawing.Size(110, 35);
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
            this.groupBox1.Controls.Add(this.trackBar_temperature_increment);
            this.groupBox1.Location = new System.Drawing.Point(541, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 119);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Температура";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(37, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Охолодити";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(37, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(37, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Нагріти";
            // 
            // numericUpDown_molec_count
            // 
            this.numericUpDown_molec_count.Location = new System.Drawing.Point(25, 34);
            this.numericUpDown_molec_count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_molec_count.Name = "numericUpDown_molec_count";
            this.numericUpDown_molec_count.ReadOnly = true;
            this.numericUpDown_molec_count.Size = new System.Drawing.Size(96, 22);
            this.numericUpDown_molec_count.TabIndex = 17;
            this.numericUpDown_molec_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_molec_count.ValueChanged += new System.EventHandler(this.numericUpDown_molec_count_ValueChanged);
            // 
            // textBox_stopwatch
            // 
            this.textBox_stopwatch.Location = new System.Drawing.Point(6, 21);
            this.textBox_stopwatch.Name = "textBox_stopwatch";
            this.textBox_stopwatch.ReadOnly = true;
            this.textBox_stopwatch.Size = new System.Drawing.Size(82, 22);
            this.textBox_stopwatch.TabIndex = 18;
            this.textBox_stopwatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button_reset_stopwatch);
            this.groupBox2.Controls.Add(this.textBox_stopwatch);
            this.groupBox2.Controls.Add(this.button_stop_resume_stopwatch);
            this.groupBox2.Location = new System.Drawing.Point(12, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 93);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Секундомір";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "с";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(582, 443);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(93, 45);
            this.button_exit.TabIndex = 20;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // numericUpDown_temparature
            // 
            this.numericUpDown_temparature_new_molec.Location = new System.Drawing.Point(57, 168);
            this.numericUpDown_temparature_new_molec.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_temparature_new_molec.Name = "numericUpDown_temparature";
            this.numericUpDown_temparature_new_molec.Size = new System.Drawing.Size(92, 22);
            this.numericUpDown_temparature_new_molec.TabIndex = 21;
            this.numericUpDown_temparature_new_molec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_temparature_new_molec.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_temparature_new_molec.ValueChanged += new System.EventHandler(this.numericUpDown_temparature_new_molec_ValueChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(27, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "Температура нових молекул";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "К";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "атм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "моль";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_temp);
            this.groupBox3.Controls.Add(this.textBox_mole);
            this.groupBox3.Controls.Add(this.textBox_presure);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 81);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Показники";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_stop_resume_update);
            this.groupBox4.Location = new System.Drawing.Point(555, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 70);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Рух молекул";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_molecules_delta);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.numericUpDown_molec_count);
            this.groupBox5.Controls.Add(this.button_clear);
            this.groupBox5.Controls.Add(this.numericUpDown_temparature_new_molec);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(518, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 200);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Молекули";
            // 
            // label_molecules_delta
            // 
            this.label_molecules_delta.AutoSize = true;
            this.label_molecules_delta.Location = new System.Drawing.Point(127, 36);
            this.label_molecules_delta.Name = "label_molecules_delta";
            this.label_molecules_delta.Size = new System.Drawing.Size(16, 16);
            this.label_molecules_delta.TabIndex = 27;
            this.label_molecules_delta.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 26);
            this.button4.TabIndex = 26;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Buttons_add_remove_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 26);
            this.button3.TabIndex = 25;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Buttons_add_remove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 26);
            this.button2.TabIndex = 24;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Buttons_add_remove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Buttons_add_remove_Click);
            // 
            // timer_updata_fiels
            // 
            this.timer_updata_fiels.Enabled = true;
            this.timer_updata_fiels.Interval = 30;
            this.timer_updata_fiels.Tick += new System.EventHandler(this.timer_update_fiels_Tick);
            // 
            // flask1
            // 
            this.flask1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flask1.BackgroundImage")));
            this.flask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flask1.Location = new System.Drawing.Point(0, 0);
            this.flask1.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.flask1.Name = "flask1";
            this.flask1.Size = new System.Drawing.Size(498, 312);
            this.flask1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 524);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Газові ізопроцеси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_temperature_increment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_temparature_new_molec)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.TextBox textBox_mole;
        private System.Windows.Forms.TextBox textBox_presure;
        private System.Windows.Forms.Button button_stop_resume_update;
        private System.Windows.Forms.TrackBar trackBar_temperature_increment;
        private System.Windows.Forms.Timer timer_stopwatch;
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
        private System.Windows.Forms.NumericUpDown numericUpDown_temparature_new_molec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_molecules_delta;
        private Flask flask1;
        private System.Windows.Forms.Timer timer_updata_fiels;
    }
}

