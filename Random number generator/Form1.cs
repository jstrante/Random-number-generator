using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_number_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetColor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int redValue = rnd.Next(0, 255) ;
            int blueValue = rnd.Next(0, 255);
            int greenValue = rnd.Next(0, 255);

            RedValue.Text = Int32.Parse(redValue);

            Redbulb.BackColor = Color.FromArgb(redValue, 0, 0);
            Greenbulb.BackColor = Color.FromArgb(0, greenValue, 0);
            Bluebulb.BackColor = Color.FromArgb(0, 0, blueValue);
            this.BackColor = Color.FromArgb(redValue, greenValue, blueValue);

        }
    }
}
