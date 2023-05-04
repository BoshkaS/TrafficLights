namespace TrafficLights
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelwithtraffic = new System.Windows.Forms.Panel();
            this.green_circle = new System.Windows.Forms.Panel();
            this.yellow_circle = new System.Windows.Forms.Panel();
            this.red_circle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.redTimer = new System.Windows.Forms.Timer(this.components);
            this.yellowTimer = new System.Windows.Forms.Timer(this.components);
            this.greenTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelwithtraffic.SuspendLayout();
            this.red_circle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelwithtraffic
            // 
            this.panelwithtraffic.Controls.Add(this.green_circle);
            this.panelwithtraffic.Controls.Add(this.red_circle);
            this.panelwithtraffic.Controls.Add(this.yellow_circle);
            this.panelwithtraffic.Location = new System.Drawing.Point(155, 85);
            this.panelwithtraffic.Name = "panelwithtraffic";
            this.panelwithtraffic.Size = new System.Drawing.Size(174, 281);
            this.panelwithtraffic.TabIndex = 0;
            this.panelwithtraffic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelwithtraffic_Paint);
            // 
            // green_circle
            // 
            this.green_circle.BackColor = System.Drawing.Color.Transparent;
            this.green_circle.Location = new System.Drawing.Point(48, 186);
            this.green_circle.Name = "green_circle";
            this.green_circle.Size = new System.Drawing.Size(100, 65);
            this.green_circle.TabIndex = 1;
            this.green_circle.Visible = false;
            this.green_circle.Paint += new System.Windows.Forms.PaintEventHandler(this.green_circle_Paint);
            // 
            // yellow_circle
            // 
            this.yellow_circle.BackColor = System.Drawing.Color.Transparent;
            this.yellow_circle.Location = new System.Drawing.Point(48, 119);
            this.yellow_circle.Name = "yellow_circle";
            this.yellow_circle.Size = new System.Drawing.Size(100, 65);
            this.yellow_circle.TabIndex = 0;
            this.yellow_circle.Visible = false;
            this.yellow_circle.Paint += new System.Windows.Forms.PaintEventHandler(this.yellow_circle_Paint);
            // 
            // red_circle
            // 
            this.red_circle.BackColor = System.Drawing.Color.Transparent;
            this.red_circle.Controls.Add(this.panel1);
            this.red_circle.Location = new System.Drawing.Point(48, 51);
            this.red_circle.Name = "red_circle";
            this.red_circle.Size = new System.Drawing.Size(100, 66);
            this.red_circle.TabIndex = 0;
            this.red_circle.Visible = false;
            this.red_circle.Paint += new System.Windows.Forms.PaintEventHandler(this.red_circle_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 113);
            this.panel1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Lasco", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(450, 51);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(198, 45);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // redTimer
            // 
            this.redTimer.Tick += new System.EventHandler(this.redTimer_Tick);
            // 
            // yellowTimer
            // 
            this.yellowTimer.Tick += new System.EventHandler(this.yellowTimer_Tick_toGreen);
            // 
            // greenTimer
            // 
            this.greenTimer.Tick += new System.EventHandler(this.greenTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lasco", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.panelwithtraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelwithtraffic.ResumeLayout(false);
            this.red_circle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelwithtraffic;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel red_circle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel yellow_circle;
        private System.Windows.Forms.Panel green_circle;
        private System.Windows.Forms.Timer redTimer;
        private System.Windows.Forms.Timer yellowTimer;
        private System.Windows.Forms.Timer greenTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

