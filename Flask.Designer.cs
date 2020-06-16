namespace PhisicExperiments
{
    partial class Flask
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer_Update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timer_Update
            // 
            this.Timer_Update.Interval = 33;
            this.Timer_Update.Tick += new System.EventHandler(this.Timer_Update_Tick);
            // 
            // Flask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Flask";
            this.Size = new System.Drawing.Size(191, 157);
            this.Load += new System.EventHandler(this.Flask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Update;
    }
}
