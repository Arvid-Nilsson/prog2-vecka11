using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning11._2
{
    internal class Måltavla
    {
        public int x = 0;
        public int y = 0;
        public int radius = 50;
        public void Draw(Graphics g)
        {
            
            DrawCircle(g, Color.White, x, y, radius, 1);
            DrawCircle(g, Color.Black,x,y,radius, 0.8);
            DrawCircle(g, Color.Blue, x, y, radius, 0.6);
            DrawCircle(g, Color.Red, x, y, radius, 0.4);
            DrawCircle(g, Color.Yellow, x, y, radius, 0.2);
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, x - radius / 2, y - radius / 2, radius, radius);
        }
        private void DrawCircle(Graphics g, Color color, int tempX, int TempY, int tempRadius, double Size)
        {
            SolidBrush brush = new SolidBrush(color);

            g.FillEllipse(brush, (float)(x + (radius * (1 - Size) / 2) - radius/2), (float)(y + (radius * (1 - Size) / 2) - radius / 2), (float)(radius * Size), (float)(radius * Size));
        }
    }
}
