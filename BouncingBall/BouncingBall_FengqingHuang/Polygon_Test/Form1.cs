using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelColor.BackColor = polygonView.Color;
            colorDialog1.Color = polygonView.Color;
        }

        //Set the velocity in the textbox to the ball
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int velocity;
            //in case the user sets the textbox blank.
            if (textBox1.Text == string.Empty) { velocity = 0; }
            else
            {
                //otherwise send the textbox content.
                velocity = Convert.ToInt16(textBox1.Text);
            }
            polygonView.velocity = velocity;
            //send the velocity to the trackBar. 
            if (velocity > trackBar1.Maximum) velocity = trackBar1.Maximum;
            trackBar1.Value = velocity;
            
        }

        //send the velocity in the trackBar to the UserController.
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int velocity = trackBar1.Value;
            polygonView.velocity = velocity;
            textBox1.Text = velocity.ToString();
        }

        //Colour Control.
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                polygonView.Color = colorDialog1.Color;
                labelColor.BackColor = colorDialog1.Color;
            }
        }

        private void polygonView_Load(object sender, EventArgs e)
        {

        }

        private void polygonView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }
    }
}
