using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        public TrafficLight TrafficLight { get; set; }

        public Form1()
        {
            InitializeComponent();
            redTimer.Interval = 1000;
            yellowTimer.Interval = 1000;
            greenTimer.Interval = 1000;
            TrafficLight = new TrafficLight(Colors.Red, redTimer, yellowTimer, greenTimer, red_circle, yellow_circle, green_circle);
        }

        private void panelwithtraffic_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush graybrush = new SolidBrush(Color.Gray);
            Graphics g = e.Graphics;
            g.FillRectangle(graybrush, 50, 50, 100, 207);
            SolidBrush blackredbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#400000"));
            SolidBrush blackyellowbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#403700"));
            SolidBrush blackgreenbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#0a4000"));
            g.FillEllipse(blackredbrush, 70, 60, 55, 55);
            g.FillEllipse(blackyellowbrush, 70, 125, 55, 55);
            g.FillEllipse(blackgreenbrush, 70, 190, 55, 55);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            TrafficLight.Start();
        }

        private void red_circle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush redbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#d60000"));
            g.FillEllipse(redbrush, 22, 9, 55, 55);
        }

        private void yellow_circle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush yellowbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#d6d600"));
            g.FillEllipse(yellowbrush, 22, 6, 55, 55);
        }

        private void green_circle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush greenbrush = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#20d600"));
            g.FillEllipse(greenbrush, 22, 4, 55, 55);
        }

        private void yellowTimer_Tick_toRed(object sender, EventArgs e)
        {
            TrafficLight.ChangeColor(Colors.Red);
            yellow_circle.Visible = false;
            yellowTimer.Stop();
            red_circle.Visible = true;
            redTimer.Start();
            yellowTimer.Tick -= yellowTimer_Tick_toRed;
            yellowTimer.Tick += yellowTimer_Tick_toGreen;
            
        }

        private void greenTimer_Tick(object sender, EventArgs e)
        {
            TrafficLight.ChangeColor(Colors.Yellow);
            green_circle.Visible = false;
            greenTimer.Stop();
            yellow_circle.Visible = true;
            yellowTimer.Start();
        }

        private void redTimer_Tick(object sender, EventArgs e)
        {

            TrafficLight.ChangeColor(Colors.Yellow);
            red_circle.Visible = false;
            redTimer.Stop();
            yellow_circle.Visible = true;
            yellowTimer.Start();
            
        }

        private void yellowTimer_Tick_toGreen(object sender, EventArgs e)
        {
            TrafficLight.ChangeColor(Colors.Green);
            yellow_circle.Visible = false;
            yellowTimer.Stop();
            green_circle.Visible = true;
            greenTimer.Start();
            yellowTimer.Tick -= yellowTimer_Tick_toGreen;
            yellowTimer.Tick += yellowTimer_Tick_toRed;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            TrafficLight.Stop();
        }
    }
}
