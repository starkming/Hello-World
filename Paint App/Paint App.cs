using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;   //generate a generic collection

namespace Paint_App
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints; //
        bool PencilDown;        // active or not when the mouse is clicked
        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList(); //This is the start and end for a drawn line
            PencilDown = false; // not active yet
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            listOfPoints.Add(p);
            PencilDown = true;  // Active when we press the mouse
            this.statusStrip1.Items[0].Text = "MouseDown";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;  // Active when we release the mouse
            this.statusStrip1.Items[0].Text = "MouseUp";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point points = new Point(e.X, e.Y);
            Pen pencil = new Pen(Color.BlueViolet);

            if (PencilDown)
            {
                this.statusStrip1.Items[0].Text = "MouseMove";
                if (listOfPoints.Count > 1)
                    g.DrawLine(pencil, (Point)listOfPoints[listOfPoints.Count - 1], points);
                listOfPoints.Add(points);
            }
        }
    }
}
