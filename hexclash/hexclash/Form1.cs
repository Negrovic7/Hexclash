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

        List<Tile> tiles = new List<Tile>();

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
            int inputL = tiles.Count;
            
            for (int i = 1; i <= 14; i++)
            {
                float x_c = 0;
                float y_c = 0;
                Tile t = new Tile(inputL + i, "blank");
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                    x_c += (shape[a].X / 6);
                    y_c += (shape[a].Y / 6);
                }
                t.Shape = shape;
                PointF centar = new PointF(x_c, y_c);
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.MidnightBlue, shape);
                        t.Colour = "Dark Blue";
                        break;

                    case 2:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 3:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 4:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 5:
                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 6:
                    case 13:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        x_0 += 3 * r + 7;
                        y_0 = 640 - (float)minimins + (float)mins;
                        break;

                    case 14:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        break;

                    

                }

                tiles.Add(t);
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
                float x_c = 0;
                float y_c = 0;
                Tile t = new Tile(i, "blank");
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                    x_c += (shape[a].X / 6);
                    y_c += (shape[a].Y / 6);
                }
                t.Shape = shape;
                PointF centar = new PointF(x_c, y_c);
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.Blue, shape);
                        t.Colour = "Blue";
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.MidnightBlue, shape);
                        t.Colour = "Dark Blue";
                        break;

                    case 3:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        break;

                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.Red, shape);
                        t.Colour = "Red";
                        break;

                }
                tiles.Add(t);
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
            int inputL = tiles.Count;

            for (int i = 1; i <= 12; i++)
            {
                float x_c = 0;
                float y_c = 0;
                Tile t = new Tile(inputL + i, "blank");
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                    x_c += (shape[a].X / 6);
                    y_c += (shape[a].Y / 6);

                }
                t.Shape = shape;
                PointF centar = new PointF(x_c, y_c);
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 2:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 3:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 4:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 5:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        x_0 += 2*(3 * r + 7);
                        y_0 = 640 - (float)0.5*((float)minimins - (float)mins) - 18;
                        break;

                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;



                }

                tiles.Add(t);
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
            int inputL = tiles.Count;

            for (int i = 1; i <= 10; i++)
            {
                float x_c = 0;
                float y_c = 0;
                Tile t = new Tile(inputL + i, "blank");
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                    x_c += (shape[a].X / 6);
                    y_c += (shape[a].Y / 6);
                }
                t.Shape = shape;
                PointF centar = new PointF(x_c, y_c);
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        t.Colour = "Purple";
                        break;

                    case 2:
                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;

                    case 3:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        break;

                    case 4:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        break;


                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        t.Colour = "Purple";
                        x_0 += 3 * (3 * r + 7);
                        y_0 = 640 - (float)0.5 * ((float)minimins - (float)mins) - 18 - (float)minimins;
                        break;

                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkViolet, shape);
                        t.Colour = "Purple";
                        break;



                }

                tiles.Add(t);
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
            int inputL = tiles.Count;
            for (int i = 1; i <= 4; i++)
            {
                float x_c = 0;
                float y_c = 0;
                Tile t = new Tile(inputL + i, "blank");
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                    //t.Shape[a].X = shape[a].X;
                    //t.Shape[a].X = shape[a].X;
                    x_c += (shape[a].X / 6);
                    y_c += (shape[a].Y / 6);
                }
                
                PointF centar = new PointF(x_c, y_c);
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                    case 3:
                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        tiles.Add(t);
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        tiles.Add(t);
                        x_0 += 4 * (3 * r + 7);
                        y_0 = 640 - (float)0.5 * ((float)minimins - (float)mins) - 18 - 4*(float)minimins;
                        break;


                }

                y_0 -= (float)mins;
            }
        }

        public double Distance(PointF clicked, PointF other)
        {
            return (Math.Sqrt(Math.Pow(clicked.X - other.X, 2) + Math.Pow(clicked.Y - other.Y, 2)));
        }

        public void Selected(object sender, PaintEventArgs e, PointF[] p)
        {
            var graphics = e.Graphics;
            Color newColor = Color.FromArgb(60, Color.Black);
            graphics.FillPolygon(new SolidBrush(newColor), p);

        }

        int move = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            List<Tile> adjacent = new List<Tile>();
            Graphics g;
            g = this.CreateGraphics();
            double minD = 46;
            PointF clicked = new PointF(e.X, e.Y);
            Tile closest = new Tile();
            Color newColor = Color.FromArgb(60, Color.Black);
            foreach (Tile t in tiles)
            {
                if (Distance(clicked, t.CPoint) < minD)
                {

                    closest = t;
                    minD = Distance(clicked, t.CPoint);
                    g.FillPolygon(new SolidBrush(newColor), t.Shape);
                }

                if (Distance(clicked, t.CPoint) < 80)
                {
                    adjacent.Add(t);
                }
            }
            MessageBox.Show("closest = " + closest.Id);
        }
    }
}
