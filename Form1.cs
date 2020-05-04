using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexclash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            CenterD(sender, e);
            OneFromC(sender, e);
            TwoFromC(sender, e);
            ThreeFromC(sender, e);
            Edges(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        public void OneFromC(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Pen borders = new Pen(Brushes.Black, 6);
            var r = 45;
            double mins = r * Math.Sqrt(3);
            double minimins = mins / 2;
            float x_0 = 423 - r - (float)minimins + (float)12.5;
            float y_0 = 640 - (float)minimins;
            var shape = new PointF[6];
            
            
            for (int i = 1; i <= 14; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }
                switch (i)
                {
                    case 1:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.MidnightBlue, shape);
                        break;

                    case 2:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 3:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 4:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 5:
                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 6:
                    case 13:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        x_0 += 3 * r + 7;
                        y_0 = 640 - (float)minimins + (float)mins;
                        break;

                    case 14:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        break;

                    

                }

                
                y_0 -= (float)mins;
            }
        }



            public void CenterD(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Pen borders = new Pen(Brushes.Black, 6);
            float x_0 = 423;
            float y_0 = 640;
            var shape = new PointF[6];
            var r = 45;
            for (int i = 1; i <= 8; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }
                switch (i)
                {
                    case 1:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.Blue, shape);
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.MidnightBlue, shape);
                        break;

                    case 3:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        break;

                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.Red, shape);
                        break;

                }

                double mins = r * Math.Sqrt(3);
                y_0 -= (float)mins;
            }
        }


        public void TwoFromC(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Pen borders = new Pen(Brushes.Black, 6);
            var r = 45;
            double mins = r * Math.Sqrt(3);
            double minimins = mins / 2;
            float x_0 = 423 - 2*(r + (float)minimins - (float)12.5);
            float y_0 = 640 - 2*(float)minimins;
            var shape = new PointF[6];


            for (int i = 1; i <= 12; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }
                switch (i)
                {
                    case 1:
                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 2:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 3:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 4:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 5:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        x_0 += 2*(3 * r + 7);
                        y_0 = 640 - (float)0.5*((float)minimins - (float)mins) - 18;
                        break;

                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;



                }


                y_0 -= (float)mins;
            }
        }


        public void ThreeFromC(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Pen borders = new Pen(Brushes.Black, 6);
            var r = 45;
            double mins = r * Math.Sqrt(3);
            double minimins = mins / 2;
            float x_0 = 423 - 3 * (r + (float)minimins - (float)12.5);
            float y_0 = 640 - 3 * (float)minimins;
            var shape = new PointF[6];


            for (int i = 1; i <= 10; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }
                switch (i)
                {
                    case 1:
                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        break;

                    case 2:
                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;

                    case 3:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 4:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        break;


                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        x_0 += 3 * (3 * r + 7);
                        y_0 = 640 - (float)0.5 * ((float)minimins - (float)mins) - 18 - (float)minimins;
                        break;

                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        break;



                }


                y_0 -= (float)mins;
            }
        }

        public void Edges(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Pen borders = new Pen(Brushes.Black, 6);
            var r = 45;
            double mins = r * Math.Sqrt(3);
            double minimins = mins / 2;
            float x_0 = 423 - 4 * (r + (float)minimins - (float)12.5);
            float y_0 = 640 - 4 * (float)minimins;
            y_0 -= (float)mins;
            var shape = new PointF[6];
            for (int i = 1; i <= 4; i++)
            {
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }

                switch (i)
                {
                    case 1:
                    case 3:
                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        x_0 += 4 * (3 * r + 7);
                        y_0 = 640 - (float)0.5 * ((float)minimins - (float)mins) - 18 - 4*(float)minimins;
                        break;


                }
                y_0 -= (float)mins;
            }
        }

    }
}

