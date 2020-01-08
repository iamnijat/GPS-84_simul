using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aircraft_project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
               /* Graphics g = e.Graphics;
                int numofcesll = 150;
                int cellsize = 30;
                Pen p = new Pen(Color.Black);

                for (int y = 0; y < numofcesll; ++y)
                {
                    g.DrawLine(p, 0, y * cellsize, numofcesll * cellsize, y * cellsize);

                }

                for (int x = 0; x < numofcesll; ++x)
                {
                    g.DrawLine(p, x * cellsize, 0, x * cellsize, numofcesll * cellsize);
                }
                */
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*  int kor1 = e.X;
             int kor2 = e.Y;


             double rad = kor1 / kor2;
             double derece = (rad * (180 / Math.PI));

             double minutes = (derece - Math.Floor(derece)) * 60.0;
             double seconds = (minutes - Math.Floor(minutes)) * 60.0;
             double tenths = (seconds - Math.Floor(seconds)) * 10.0;

             minutes = Math.Floor(minutes);
             seconds = Math.Floor(seconds);


             tenths = Math.Floor(tenths);

             label1.Text = minutes + "° " + seconds + "' " + tenths;
             */


            double y = Convert.ToDouble(e.Y) - 565 + pictureBox1.Width / 2;
            double x = Convert.ToDouble(e.X) + pictureBox1.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            label1.Text = "LATITUDE : " + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "LONGTITUDE : " + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
        }
    }
    }
