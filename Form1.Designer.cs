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
            this.button_ = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.textBox_total_weight = new System.Windows.Forms.TextBox();
            this.textBox_presure = new System.Windows.Forms.TextBox();
            this.button_stop_resume = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer_stopwartch = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_molec_count = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_ = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_)).BeginInit();
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
            this.button_add_molec.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_
            // 
            this.button_.Location = new System.Drawing.Point(661, 159);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(100, 23);
            this.button_.TabIndex = 6;
            this.button_.Text = "Забрати";
            this.button_.UseVisualStyleBackColor = true;
            this.button_.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(501, 456);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(108, 37);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(26, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 315);
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
            this.textBox_presure.Location = new System.Drawing.Point(239, 60);
            this.textBox_presure.Name = "textBox_presure";
            this.textBox_presure.ReadOnly = true;
            this.textBox_presure.Size = new System.Drawing.Size(100, 22);
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
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(6, 21);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = -5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 90);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // timer_stopwartch
            // 
            this.timer_stopwartch.Interval = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 14;
            this.button4.Text = "Почати/Зупини";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(100, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 44);
            this.button5.TabIndex = 15;
            this.button5.Text = "Скинути";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBar1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(555, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Секундомір";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(662, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Вихід";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_
            // 
            this.numericUpDown_.Location = new System.Drawing.Point(685, 207);
            this.numericUpDown_.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_.Name = "numericUpDown_";
            this.numericUpDown_.Size = new System.Drawing.Size(76, 22);
            this.numericUpDown_.TabIndex = 21;
            this.numericUpDown_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "с";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 551);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numericUpDown_molec_count);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_stop_resume);
            this.Controls.Add(this.textBox_presure);
            this.Controls.Add(this.textBox_total_weight);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_molec_count)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_)).EndInit();
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
        private System.Windows.Forms.Button button_;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.TextBox textBox_total_weight;
        private System.Windows.Forms.TextBox textBox_presure;
        private System.Windows.Forms.Button button_stop_resume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer_stopwartch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_molec_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

