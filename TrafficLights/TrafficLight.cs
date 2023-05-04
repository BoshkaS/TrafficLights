using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Windows.Forms;


namespace TrafficLights
{
    public class TrafficLight
    {
        public Colors Color { get; set; }

        public Timer RedTimer { get; set; }

        public Timer YellowTimer { get; set; }

        public Timer GreenTimer { get; set; }

        public Panel RedLight { get; set; }

        public Panel YellowLight { get; set; }

        public Panel GreenLight { get; set; }

        public TrafficLight(Colors color, Timer red, Timer yellow, Timer green, Panel redLight, Panel yellowLight, Panel greenLight)
        {
            Color = color;
            RedTimer = red;
            YellowTimer = yellow;
            GreenTimer = green;
            RedLight = redLight;
            YellowLight = yellowLight;
            GreenLight = greenLight;
        }

        public void Start()
        {
            switch (Color)
            {
                case Colors.Red:
                    RedLight.Visible = true;
                    RedTimer.Start();
                    break;
                case Colors.Yellow:
                    YellowLight.Visible = true;
                    YellowTimer.Start();
                    break;
                case Colors.Green:
                    GreenLight.Visible = true;
                    GreenTimer.Start();
                    break;
            }

        }

        public void Stop()
        {
            switch(Color)
            {
                case Colors.Red:
                    RedTimer.Stop();
                    break;
                case Colors.Yellow:
                    YellowTimer.Stop();
                    break;
                case Colors.Green:
                    GreenTimer.Stop();
                    break;
            }
        }

        public void ManualColorSwitch(Colors color)
        {
            
            Stop();
            ChangeColor(color);
            switch (color)
            {
                case Colors.Red:
                    RedLight.Visible = true;
                    break;
                case Colors.Yellow:
                    YellowLight.Visible = true;
                    break;
                case Colors.Green:
                    GreenLight.Visible = true;
                    break;
            }
        }

        public void ChangeColor(Colors color)
        {
            Color = color;
        }
        
    }
}
