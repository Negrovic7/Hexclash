using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexclash
{
    public partial class Hexclash : Form
    {
        string bTm = "Blue to move..";
        string rTm = "Red to move..";
        Stopwatch s = new Stopwatch();
        public Hexclash()
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
            events.Items.Add(bTm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s.Start();
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
           
            int inputL = tiles.Count;
            
            for (int i = 1; i <= 14; i++)
            {
                var shape = new PointF[6];
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
                        t.R = Role.bGuard;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 2:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 3:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 4:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 5:
                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 6:
                    case 13:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        t.R = Role.rGuard;
                        x_0 += 3 * r + 7;
                        y_0 = 640 - (float)minimins + (float)mins;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 14:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        t.R = Role.rGuard;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
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
            var r = 45;
            for (int i = 1; i <= 8; i++)
            {
                PointF[] shape = new PointF[6];
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
                        t.R = Role.bKing;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.MidnightBlue, shape);
                        t.Colour = "Dark Blue";
                        t.R = Role.bGuard;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 3:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.DarkRed, shape);
                        t.Colour = "Dark Red";
                        t.R = Role.rGuard;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.Red, shape);
                        t.Colour = "Red";
                        t.R = Role.rKing;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
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
            int inputL = tiles.Count;

            for (int i = 1; i <= 12; i++)
            {
                var shape = new PointF[6];
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
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 2:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 3:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 4:
                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 5:
                    case 11:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 6:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        x_0 += 2*(3 * r + 7);
                        y_0 = 640 - (float)0.5*((float)minimins - (float)mins) - 18;
                        break;

                    case 12:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
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
            int inputL = tiles.Count;

            for (int i = 1; i <= 10; i++)
            {
                var shape = new PointF[6];
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
                        graphics.FillPolygon(Brushes.DarkSlateBlue, shape);
                        t.Colour = "Blue Ranger";
                        t.R = Role.bRanger;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 2:
                    case 7:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 3:
                    case 8:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;

                    case 4:
                    case 9:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.White, shape);
                        t.Colour = "White";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        break;


                    case 5:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.PaleVioletRed, shape);
                        t.Colour = "Red Ranger";
                        t.R = Role.rRanger;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        x_0 += 3 * (3 * r + 7);
                        y_0 = 640 - (float)0.5 * ((float)minimins - (float)mins) - 18 - (float)minimins;
                        break;

                    case 10:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.PaleVioletRed, shape);
                        t.Colour = "Red Ranger";
                        t.R = Role.rRanger;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
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

            int inputL = tiles.Count;
            for (int i = 1; i <= 4; i++)
            {
                var shape = new PointF[6];
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
                PointF centar = new PointF(x_c, y_c);
                t.Shape = shape;
                t.CPoint = centar;
                switch (i)
                {
                    case 1:
                    case 3:
                    case 4:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
                        tiles.Add(t);
                        break;

                    case 2:
                        graphics.DrawPolygon(borders, shape);
                        graphics.FillPolygon(Brushes.ForestGreen, shape);
                        t.Colour = "Green";
                        t.Bcolour = "Green";
                        t.R = Role.Terrain;
                        tiles.Add(t);
                        t.Hp = t.GetHP(t.R);
                        t.Force = t.GetForce(t.R);
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

        int move = 0;
        List<Tile> adjacent = new List<Tile>();
        List<Tile> allies = new List<Tile>();
        List<Tile> enemies = new List<Tile>();
        Tile selected = new Tile();
        int scoreB = 0;
        int scoreR = 0;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            double minD = 46;
            PointF clicked = new PointF(e.X, e.Y);
            Tile closest = new Tile();
            Color newColor01 = Color.FromArgb(100, Color.White);
            Color newColora = Color.FromArgb(50, Color.Black);
            Color c;
            Pen borders = new Pen(Brushes.Black, 6);
            int minutes = 0;
            int seconds = 0;
            Form2 f = new Form2();
            switch (move % 4)
            {
                case 0:
                    foreach (Tile t in tiles)
                    {
                        if (Distance(clicked, t.CPoint) < minD)
                        {
                            closest = t;
                            selected = closest;
                            break;
                        }
                    }

                    if (closest.R == Role.bKing || closest.R == Role.bGuard || closest.R == Role.bRanger || closest.R == Role.bDisarmedG || closest.R == Role.bAssassin)
                    {
                        move++;
                        g.FillPolygon(new SolidBrush(newColor01), closest.Shape);
                        foreach (Tile t in tiles)
                        {
                            if (closest.R == Role.bRanger || closest.R == Role.bAssassin)
                            {
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && t.R != Role.bKing && t.R != Role.bGuard && t.R != Role.bRanger && t.R != Role.bDisarmedG && t.R != Role.bAssassin && t.R != Role.rKing && t.R != Role.rGuard && t.R != Role.rRanger && t.R != Role.rDisarmedG && t.R != Role.rAssassin && closest.Id != t.Id)
                                    adjacent.Add(t);
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && (t.R == Role.bKing || t.R == Role.bGuard || t.R == Role.bRanger || t.R == Role.bDisarmedG || t.R == Role.bAssassin))
                                {
                                    allies.Add(t);
                                }
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && (t.R == Role.rKing || t.R == Role.rGuard || t.R == Role.rRanger || t.R == Role.rDisarmedG || t.R == Role.rAssassin))
                                {
                                    enemies.Add(t);
                                }
                            }
                            else if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && t.R != Role.bKing && t.R != Role.bGuard && t.R != Role.bRanger && t.R != Role.bDisarmedG && t.R != Role.bAssassin && t.R != Role.rKing && t.R != Role.rGuard && t.R != Role.rRanger && t.R != Role.rDisarmedG && t.R != Role.rAssassin && closest.Id != t.Id)
                            {
                                adjacent.Add(t);
                            }

                            if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && (t.R == Role.bKing || t.R == Role.bGuard || t.R == Role.bRanger || t.R == Role.bDisarmedG || t.R == Role.bAssassin))
                            {
                                allies.Add(t);
                            }

                            if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && (t.R == Role.rKing || t.R == Role.rGuard || t.R == Role.rRanger || t.R == Role.rDisarmedG || t.R == Role.rAssassin))
                            {
                                enemies.Add(t);
                            }




                        }

                        foreach (Tile t in adjacent)
                        {
                            g.FillPolygon(new SolidBrush(newColora), t.Shape);
                        }
                    }
                    break;

                case 1:
                case 3:
                    foreach (Tile t in tiles)
                    {
                        if (Distance(clicked, t.CPoint) < minD)
                        {
                            closest = t;
                            break;
                        }
                    }
                    if (closest.Id != selected.Id)
                    {
                        foreach (Tile t in enemies)
                        {
                            if (closest.Id == t.Id)
                            {
                                move++;
                                closest.Hp -= selected.Force;
                                if (move % 4 == 2)
                                {
                                    events.Items.Add("Blue attacks red for " + selected.Force + " HP, red has " + closest.Hp + " HP left");
                                    events.Items.Add(rTm);
                                    scoreB += selected.Force * 100;
                                    scoreR -= selected.Force * 10;
                                }
                                else
                                {
                                    events.Items.Add("Red attacks blue for " + selected.Force + " HP, blue has " + closest.Hp + " HP left");
                                    scoreR += selected.Force * 100;
                                    scoreB -= selected.Force * 10;
                                    events.Items.Add(bTm);
                                }
                                if (closest.Hp <= 0)
                                {
                                    if (closest.R == Role.rKing)
                                    {
                                        s.Stop();
                                        minutes = (int)s.ElapsedMilliseconds / 60000;
                                        seconds = ((int)s.ElapsedMilliseconds % 60000) / 1000;
                                        MessageBox.Show("Game over!\nBlue wins!\nTime elapsed -  " + minutes + ":" + seconds);
                                        scoreB -= (seconds + minutes*60);
                                        f.LabelText = scoreB.ToString();
                                        f.ShowDialog();                                     
                                        closest.R = Role.Terrain;
                                        closest.Colour = closest.Bcolour;
                                        g.DrawPolygon(borders, closest.Shape);
                                        g.FillPolygon(new SolidBrush(ReturnC(closest.Bcolour)), closest.Shape);
                                        Environment.Exit(0);
                                    }
                                    if (closest.R == Role.bKing)
                                    {
                                        s.Stop();
                                        minutes = (int)s.ElapsedMilliseconds / 60000;
                                        seconds = ((int)s.ElapsedMilliseconds % 60000) / 1000;
                                        MessageBox.Show("Game over!\nRed wins!\nTime elapsed -  " + minutes + ":" + seconds);
                                        closest.R = Role.Terrain;
                                        closest.Colour = closest.Bcolour;
                                        g.DrawPolygon(borders, closest.Shape);
                                        g.FillPolygon(new SolidBrush(ReturnC(closest.Bcolour)), closest.Shape);
                                        Environment.Exit(0);
                                    }
                                    events.Items.Add("Tile removed");
                                    closest.R = selected.R;
                                    closest.Hp = selected.Hp;
                                    closest.Force = selected.Force;
                                    closest.Colour = selected.Colour;
                                    selected.Colour = selected.Bcolour;
                                    selected.R = Role.Terrain;
                                    g.DrawPolygon(borders, closest.Shape);
                                    g.FillPolygon(new SolidBrush(ReturnC(closest.Colour)), closest.Shape);
                                    g.DrawPolygon(borders, selected.Shape);
                                    g.FillPolygon(new SolidBrush(ReturnC(selected.Bcolour)), selected.Shape);

                                }
                                break;
                            }
                        }
                        if (move % 2 == 0)
                        {
                            foreach (Tile t in adjacent)
                            {
                                g.DrawPolygon(borders, t.Shape);
                                g.FillPolygon(new SolidBrush(ReturnC(t.Colour)), t.Shape);
                            }
                            g.DrawPolygon(borders, selected.Shape);
                            g.FillPolygon(new SolidBrush(ReturnC(selected.Colour)), selected.Shape);
                            adjacent.Clear();
                            allies.Clear();
                            enemies.Clear();
                            

                            break;
                        }
                            foreach (Tile t in adjacent)
                            {
                                if (t.Id == closest.Id)
                                    move++;
                            }

                        if (move % 2 == 0)
                        {
                            foreach (Tile t in adjacent)
                            {
                                c = ReturnC(t.Colour);
                                if (t.Id == closest.Id)
                                {
                                    t.Colour = selected.Colour;
                                    selected.Colour = selected.Bcolour;
                                    g.DrawPolygon(borders, t.Shape);
                                    g.FillPolygon(new SolidBrush(ReturnC(t.Colour)), t.Shape);
                                    g.DrawPolygon(borders, selected.Shape);
                                    g.FillPolygon(new SolidBrush(ReturnC(selected.Colour)), selected.Shape);
                                    t.R = selected.R;
                                    t.Hp = selected.Hp;
                                    t.Force = selected.Force;
                                    selected.R = Role.Terrain;

                                }
                                else
                                {
                                    if (move % 2 == 0)
                                    {
                                        g.DrawPolygon(borders, t.Shape);
                                        g.FillPolygon(new SolidBrush(c), t.Shape);
                                    }
                                }
                            }
                        }
                        if (move % 2 == 0)
                        {
                            adjacent.Clear();
                            allies.Clear();
                            enemies.Clear();
                            if (move % 4 == 2)
                                events.Items.Add(rTm);
                            else
                                events.Items.Add(bTm);
                        }
                    }
                    else
                    {
                        move--;
                        g.DrawPolygon(borders, selected.Shape);
                        g.FillPolygon(new SolidBrush(ReturnC(selected.Colour)), selected.Shape);
                        foreach (Tile t in adjacent)
                        {
                            g.DrawPolygon(borders, t.Shape);
                            g.FillPolygon(new SolidBrush(ReturnC(t.Colour)), t.Shape);
                        }
                        adjacent.Clear();
                    }
                    break;

                case 2:
                    foreach (Tile t in tiles)
                    {
                        if (Distance(clicked, t.CPoint) < minD)
                        {
                            closest = t;
                            selected = closest;
                            break;
                        }
                    }
                    if (closest.R == Role.rKing || closest.R == Role.rGuard || closest.R == Role.rRanger || closest.R == Role.rDisarmedG || closest.R == Role.rAssassin)
                    {
                        move++;
                        g.FillPolygon(new SolidBrush(newColor01), closest.Shape);
                        foreach (Tile t in tiles)
                        {
                            if (closest.R == Role.rRanger || closest.R == Role.rAssassin)
                            {
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && t.R != Role.bKing && t.R != Role.bGuard && t.R != Role.bRanger && t.R != Role.bDisarmedG && t.R != Role.bAssassin && t.R != Role.rKing && t.R != Role.rGuard && t.R != Role.rRanger && t.R != Role.rDisarmedG && t.R != Role.rAssassin && closest.Id != t.Id)
                                    adjacent.Add(t);
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && (t.R == Role.rKing || t.R == Role.rGuard || t.R == Role.rRanger || t.R == Role.rDisarmedG || t.R == Role.rAssassin))
                                {
                                    allies.Add(t);
                                }
                                if (Distance(closest.CPoint, t.CPoint) < 170 && closest.Id != t.Id && (t.R == Role.bKing || t.R == Role.bGuard || t.R == Role.bRanger || t.R == Role.bDisarmedG || t.R == Role.bAssassin))
                                {
                                    enemies.Add(t);
                                }
                            }
                            else if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && t.R != Role.bKing && t.R != Role.bGuard && t.R != Role.bRanger && t.R != Role.bDisarmedG && t.R != Role.bAssassin && t.R != Role.rKing && t.R != Role.rGuard && t.R != Role.rRanger && t.R != Role.rDisarmedG && t.R != Role.rAssassin && closest.Id != t.Id)
                            {
                                adjacent.Add(t);
                            }

                            if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && (t.R == Role.rKing || t.R == Role.rGuard || t.R == Role.rRanger || t.R == Role.rDisarmedG || t.R == Role.rAssassin))
                            {
                                allies.Add(t);
                            }

                            if (Distance(closest.CPoint, t.CPoint) < 120 && closest.Id != t.Id && (t.R == Role.bKing || t.R == Role.bGuard || t.R == Role.bRanger || t.R == Role.bDisarmedG || t.R == Role.bAssassin))
                            {
                                enemies.Add(t);
                            }



                        }

                        foreach (Tile t in adjacent)
                        {
                            g.FillPolygon(new SolidBrush(newColora), t.Shape);
                        }
                    }
                    break;
               

            }

            if (events.Items.Count >= 10)
            {
                for (int i = 9; i >= 2; i--)
                {
                    events.Items.RemoveAt(i);
                }
            }
        }

        private Color ReturnC(string input)
        {
            switch (input)
            {
                case "Green":
                    return Color.ForestGreen;
                case "White":
                    return Color.White;
                case "Red":
                case "Red Disarmed":
                    return Color.Red;
                case "Blue":
                case "Blue Disarmed":
                    return Color.Blue;
                case "Dark Red":
                    return Color.DarkRed;
                case "Dark Blue":
                    return Color.MidnightBlue;
                case "Red Ranger":
                case "Red Assassin":
                    return Color.PaleVioletRed;
                case "Blue Ranger":
                case "Blue Assassin":
                    return Color.DarkSlateBlue;
                

            }
            return Color.Black;
        }

    }
}
