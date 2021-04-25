using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double RPM;
        double Torque;
        double Angle;
        double Radius;
        double Distance;
        double Mass;
        double Acceleration;
        bool pressed;
        double gearRatio;
        double Velocity;
        double Decceleration;
        bool drawn = false;
        bool horizontal = false;
        bool vertical = false;
        bool angular = false;
        List<Label> Time=new List<Label>();
        List<Label> GearRatio=new List<Label>();

        public Form1()
        {
            InitializeComponent();
            pressed = false;
        }

        public double Convert(string a)
        {
            double x=0;
            bool comma = false;
            double prod = 1;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == ',' || a[i] == '.')
                    comma = true;
                else
                {
                    if (comma == false)
                    {
                        x = x * 10 + a[i] - '0';
                    }
                    else
                    {
                        prod *= 10;
                        x = x + (a[i] - '0')/prod;
                    }
                }
            }
            return x;
        }
        
        private float CalculateTime(double Velocity,double Acceleration)
        {
            float time = 20;
            if (horizontal)
            {
                if (Distance < (Velocity * Velocity) / (Acceleration * 2))
                {
                    time = (float)Math.Sqrt(Distance / Acceleration * 2);
                }
                else
                {
                    time = (float)Velocity / (float)Acceleration;
                    time += (float)(Distance - (Velocity * Velocity) / (Acceleration * 2)) / (float)Velocity;
                }
            }
            if (vertical)
            {
                Acceleration = Acceleration - Decceleration;
                if(Acceleration>0)
                    if (Distance < (Velocity * Velocity) / (Acceleration * 2))
                    {
                        time = (float)Math.Sqrt(Distance / Acceleration * 2);
                    }
                    else
                    {
                        time += (float)Velocity / (float)Acceleration;
                        time += (float)(Distance - (Velocity * Velocity) / (Acceleration * 2)) / (float)Velocity;
                    }
                
            }
            return time;
        }

        private void AddLabels(PaintEventArgs e, int originx, int originy, int width, int height)
        {
            
            for (int i = originy - height / 20; i >= originy - height; i -= (height / 20))
            {
                Label number = new Label();
                float count = (float)(i - originy) / height * 2 * (-1);
                number.Text = count.ToString();
                number.AutoSize = true;
                number.TextAlign = ContentAlignment.MiddleCenter;
                number.Width = 30;
                number.Location = new Point(originx - number.Width, i - 5);
                Time.Add(number);
                this.Controls.Add(Time[(int)(count*10+0.1)-1]);
            }
            int y = 0;
            for (int i = originx + width / 20; i <= originx + width; i = i + (width / 20))
            {
                Label number = new Label();
                float count = (float)(i - originx) / width * 5;
                number.Text = count.ToString();
                number.AutoSize = true;
                number.TextAlign = ContentAlignment.MiddleCenter;
                if (number.Text.Length != 1)
                    number.Width = (number.Text.Length - 1) * 9;
                else
                    number.Width = 10;
                number.Location = new Point(i - number.Width / 2, originy + 10);
                GearRatio.Add(number);
                this.Controls.Add(GearRatio[y++]);
            }
            drawn = true;
        }

        private void TurnToVertical()
        {
            float a = 0;
            for (int i = 0; i < Time.Count; i++)
            {
                a = (float)(i + 1) * (float)0.5;
                this.Controls.Remove(Time[i]);
                Time[i].Text = a.ToString();
                this.Controls.Add(Time[i]);
            }
        }


        private void TurnToHorizontal()
        {
            float a = 0;
            for (int i = 0; i < Time.Count; i++)
            {
                a = (float)(i + 1) * (float)0.1;
                this.Controls.Remove(Time[i]);
                Time[i].Text = a.ToString();
                this.Controls.Add(Time[i]);
            }
        }

        private void paintGrid(PaintEventArgs e,int originx,int originy,int width,int height)
        {
            Pen penAxis = new Pen(Color.Black, (float)1),penGrid= new Pen(Color.Gray, (float)0.1);
            if (drawn == false)
            {
                AddLabels(e,originx,originy,width,height);
            }
            for (int i = originx + width / 20; i <= originx + width; i =i+ (width / 20))
            {
                e.Graphics.DrawLine(penGrid, i, originy, i, originy - height);
                
            }
            for (int i = originy - height / 20; i >= originy - height; i -= (height / 20))
            {
                e.Graphics.DrawLine(penGrid, originx, i, originx + width, i);
                
            }
            e.Graphics.DrawLine(penAxis, originx, originy, originx, originy - height);
            e.Graphics.DrawLine(penAxis, originx, originy, originx + width, originy);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen=new Pen(Color.Red,(float)2);
            int originx=30, originy=700, width=600, height=600;
            paintGrid(e, originx, originy, width, height);

            
            Queue<PointF> puncte= new Queue<PointF>();
            double minVal = 10;
            double place = 0;
            bool first = true;
            if (pressed == true) {
                for (gearRatio = 0.001; gearRatio < 5; gearRatio += 0.001)
                {
                    float currentTime = CalculateTime(Velocity * gearRatio, Acceleration / gearRatio);
                    if (horizontal == true)
                    {
                        if (originy - currentTime * height / 2 > originy - height && currentTime > 0)
                        {
                            if (first == true)
                            {
                                puncte.Enqueue(new PointF((float)originx + (float)(gearRatio - 0.001) * width / 5, originy - height));
                                puncte.Enqueue(new PointF((float)originx + (float)gearRatio * width / 5, originy - currentTime * height / 2));
                                first = false;
                            }
                            else
                            {
                                puncte.Enqueue(new PointF((float)originx + (float)gearRatio * width / 5, originy - currentTime * height / 2));
                            }
                        }
                    }
                    else
                    {
                        if (vertical)
                        {
                            if (originy - currentTime * height / 10 > originy - height && currentTime > 0)
                            {
                                if (first == true)
                                {
                                    puncte.Enqueue(new PointF((float)originx + (float)(gearRatio - 0.001) * width / 5, originy - height));
                                    puncte.Enqueue(new PointF((float)originx + (float)gearRatio * width / 5, originy - currentTime * height / 10));
                                    first = false;
                                }
                                else
                                {
                                    puncte.Enqueue(new PointF((float)originx + (float)gearRatio * width / 5, originy - currentTime * height / 10));
                                }
                            }
                        }
                    }

                    if (minVal> currentTime)
                    {
                        minVal = currentTime;
                        place = gearRatio;
                    }
                }
                if(puncte.Count!=0)
                e.Graphics.DrawCurve(pen,puncte.ToArray()); 

                Min_Label.Text = "Best Gear Ratio for this is " + place.ToString();
                timeLabel.Text = "Time needed with best Gear Ratio is " + minVal.ToString(); 
            }

        }

        private void Radius_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateHorizontal_Button_Click(object sender, EventArgs e)
        {
            RPM = Convert(RPMH_Text.Text);
            Mass = Convert(MassH_Text.Text);
            Distance = Convert(DistanceH_Text.Text);
            Torque = Convert(TorqueH_Text.Text);
            Radius = Convert(RadiusH_Text.Text);
            Acceleration = Torque / Mass / Radius;
            Velocity = Radius * RPM * 3.14 / 30;
            TurnToHorizontal();
            pressed = true;
            horizontal = true;
            vertical = false;
            angular = false;
            this.Refresh();
        }

        private void CalculateVertical_Button_Click(object sender, EventArgs e)
        {
            RPM = Convert(RPMH_Text.Text);
            Mass = Convert(MassH_Text.Text);
            Distance = Convert(DistanceH_Text.Text);
            Torque = Convert(TorqueH_Text.Text);
            Radius = Convert(RadiusH_Text.Text);
            Acceleration = Torque / Mass / Radius;
            Decceleration = 9.806;
            Velocity = Radius * RPM * 3.14 / 30;
            pressed = true;
            TurnToVertical();
            horizontal = false;
            vertical = true;
            angular = false;
            this.Refresh();
        }
    }
}
