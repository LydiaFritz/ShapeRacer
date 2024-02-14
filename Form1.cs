using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Shapes;

namespace ShapeRacer
{
    public partial class Form1 : Form
    {

        Pen myPen = new Pen(Color.Orange, 13);

        public const int RACE_DISTANCE = 900;
        private Racer[] racers = new Racer[2];
        private int currRacer = 0;
        private int currInterval = 0;
        static Random rnd = new Random();

        private int runInterval(Racer r)
        {
            //return distance run this interval
            return racers[currRacer].run(currInterval);
        }

        private void initializeRace()
        {
            racers[0] = new Racer("Jill", 2, 10);
            racers[1] = new Racer("Lydia", 4, 6);

        }
      


        public Form1()
        {
            InitializeComponent();

            this.Width = 1500;
            this.Height = 450;

            myPen.DashOffset = 5;
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            initializeRace();
            currInterval = rnd.Next(10);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(myPen, 0, 200, 1500, 200);
            myPen.Color = Color.Black;
            myPen.Width = 6;
            g.DrawLine(myPen, RACE_DISTANCE, 0, RACE_DISTANCE, this.Height);

        }

        private void harePic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Bitmap.FromFile("C:\\Users\\Lydia\\source\\SP2022\\ShapeRacer\\Martin-Berube-Flat-Animal-Rabbit.128.png"), 0, 0);
        }

        private void tortPic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Image.FromFile("C:\\Users\\Lydia\\source\\SP2022\\ShapeRacer\\tortoise2sml.png"), 0, 0);
        }

        private void advancePic(int distance, int racer)
        {
            //pause before advancing
            this.SuspendLayout();
            if (racer == 0 && harePic.Left < RACE_DISTANCE)
            {
                harePic.Left += distance;
            }
            else if (racer == 1 && tortPic.Left < RACE_DISTANCE)
            {
                tortPic.Left += distance;
            }
            this.ResumeLayout();

        }

        private void moveTimerEvent(object sender, EventArgs e)
        {

            //let racer start
            int dist = runInterval(racers[currRacer]);
            //advance the pic by the distance            
            advancePic(dist, currRacer);

            //did this racer win?
            if (racers[currRacer].getDistanceCovered() >= RACE_DISTANCE)
            {
                Console.WriteLine("Winner");
                this.moveTimer.Stop();
            }
            //otherwise
            //move to next racer
            currRacer = (currRacer+1) % racers.Length;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.moveTimer.Enabled = true;
        }
    }
}

