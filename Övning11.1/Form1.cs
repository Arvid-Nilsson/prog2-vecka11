using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._1
{
    public partial class Form1 : Form
    {
        internal Elipse elipse = new Elipse();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, 75, 75, elipse.height, elipse.width);
            brush.Color = Color.Blue;
            g.FillEllipse(brush, 300, 125, elipse.width, elipse.height);
        }

    }
}
