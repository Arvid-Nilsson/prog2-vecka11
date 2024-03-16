using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._2
{
    public partial class Form1 : Form
    {
        Måltavla target = new Måltavla();
        public Form1()
        {
            InitializeComponent();
            target.x = ClientSize.Width / 2;
            target.y = ClientSize.Height / 2;
            target.radius = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            target.Draw(g);
        }

        private void btnChangeRadius_Click(object sender, EventArgs e)
        {
            target.radius = int.Parse(tbxRadius.Text);
            Invalidate();
        }
    }
}
