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
            this.red_circle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yellow_circle = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.redTimer = new System.Windows.Forms.Timer(this.components);
            this.yellowTimer = new System.Windows.Forms.Timer(this.components);
            this.greenTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.RedLight = new System.Windows.Forms.Button();
            this.GreenLight = new System.Windows.Forms.Button();
            this.YellowLight = new System.Windows.Forms.Button();
            this.label_red_light = new System.Windows.Forms.Label();
            this.text_red_light = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_yellow_light = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_green_light = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // RedLight
            // 
            this.RedLight.Font = new System.Drawing.Font("Lasco", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLight.Location = new System.Drawing.Point(409, 224);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(128, 45);
            this.RedLight.TabIndex = 3;
            this.RedLight.Text = "Red";
            this.RedLight.UseVisualStyleBackColor = true;
            this.RedLight.Click += new System.EventHandler(this.RedLight_Click);
            // 
            // GreenLight
            // 
            this.GreenLight.Font = new System.Drawing.Font("Lasco", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLight.Location = new System.Drawing.Point(679, 225);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(128, 45);
            this.GreenLight.TabIndex = 4;
            this.GreenLight.Text = "Green";
            this.GreenLight.UseVisualStyleBackColor = true;
            this.GreenLight.Click += new System.EventHandler(this.GreenLight_Click);
            // 
            // YellowLight
            // 
            this.YellowLight.Font = new System.Drawing.Font("Lasco", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLight.Location = new System.Drawing.Point(545, 224);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(128, 45);
            this.YellowLight.TabIndex = 4;
            this.YellowLight.Text = "Yellow";
            this.YellowLight.UseVisualStyleBackColor = true;
            this.YellowLight.Click += new System.EventHandler(this.YellowLight_Click);
            // 
            // label_red_light
            // 
            this.label_red_light.AutoSize = true;
            this.label_red_light.Location = new System.Drawing.Point(405, 345);
            this.label_red_light.Name = "label_red_light";
            this.label_red_light.Size = new System.Drawing.Size(109, 13);
            this.label_red_light.TabIndex = 5;
            this.label_red_light.Text = "Enter time for red light";
            // 
            // text_red_light
            // 
            this.text_red_light.Location = new System.Drawing.Point(408, 375);
            this.text_red_light.Name = "text_red_light";
            this.text_red_light.Size = new System.Drawing.Size(100, 20);
            this.text_red_light.TabIndex = 6;
            this.text_red_light.TextChanged += new System.EventHandler(this.text_red_light_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter time for yellow light";
            // 
            // text_yellow_light
            // 
            this.text_yellow_light.Location = new System.Drawing.Point(532, 375);
            this.text_yellow_light.Name = "text_yellow_light";
            this.text_yellow_light.Size = new System.Drawing.Size(100, 20);
            this.text_yellow_light.TabIndex = 8;
            this.text_yellow_light.TextChanged += new System.EventHandler(this.text_yellow_light_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter time for green light";
            // 
            // text_green_light
            // 
            this.text_green_light.Location = new System.Drawing.Point(658, 375);
            this.text_green_light.Name = "text_green_light";
            this.text_green_light.Size = new System.Drawing.Size(100, 20);
            this.text_green_light.TabIndex = 8;
            this.text_green_light.TextChanged += new System.EventHandler(this.text_green_light_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Before writing some text click on button \"Stop\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_yellow_light);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_green_light);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_red_light);
            this.Controls.Add(this.label_red_light);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.panelwithtraffic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelwithtraffic.ResumeLayout(false);
            this.red_circle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button RedLight;
        private System.Windows.Forms.Button GreenLight;
        private System.Windows.Forms.Button YellowLight;
        private System.Windows.Forms.Label label_red_light;
        private System.Windows.Forms.TextBox text_red_light;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_yellow_light;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_green_light;
        private System.Windows.Forms.Label label3;
    }
}

