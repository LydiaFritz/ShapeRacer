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
        
        public const int RACE_DISTANCE = 1000;
        private Racer[] racers = new Racer[2];
        private int currRacer = 0;

        public void runRace()
        {
            //initialize racers
            racers[0] = new Racer("Jill", 2, 10);
            racers[1] = new Racer("Lydia", 4, 6);
            Random rnd = new Random();
            int interval = rnd.Next(10);
            //let first racer start
            int dist = racers[currRacer].run(interval);
            //update the racer's position
            //advance the pic by the distance
            
            advancePic(dist,currRacer);
       
            while (racers[currRacer].getDistanceCovered() < RACE_DISTANCE)
            {                
                //move to next racer
                currRacer = (currRacer+1) % racers.Length;
                //let next racer run
                interval = rnd.Next(10);
                dist = racers[currRacer].run(interval);
                //advance the pic
                //advance the pic by the distance
                
                advancePic(dist, currRacer);
               

            }
            Console.WriteLine("Somebody won");
        }


        public Form1()
        {
            InitializeComponent();

            this.Width = 1500;
            this.Height = 450;
            
            myPen.DashOffset = 5;
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            runRace();
            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(myPen, 0, 200, 1500, 200);
            
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

            if(racer == 0)
            {
                harePic.Location = new Point(harePic.Location.X + distance, harePic.Location.Y); 
            }
            else
            {
                tortPic.Location = new Point(tortPic.Location.X + distance, tortPic.Location.Y);
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
