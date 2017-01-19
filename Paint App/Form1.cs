using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Paint_App
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints;
        bool PencilDown;
        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            PencilDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
