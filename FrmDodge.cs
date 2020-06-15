using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingAgain
{

    public partial class FrmDodge : Form
    {
        Graphics g; //declare a graphics object called g
        Planet planet1 = new Planet(); //create the object, planet1


        public FrmDodge()
        {
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            planet1.drawPlanet(g);

        }
    }
}
