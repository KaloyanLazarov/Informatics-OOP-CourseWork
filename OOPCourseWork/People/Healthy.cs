using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    [Serializable]
    public class Healthy : Person
    {
        public Healthy(Point position, Point nextPosition, int radius = 10)
            : base(position, nextPosition, radius)
        {

        }
        public override void Draw(IGraphics graphics)
        {
            using (var GreenPen = new Pen(Color.GreenYellow))
            using (var GreenBrush = new SolidBrush(Color.GreenYellow))
            {
                graphics.DrawEllipse(GreenPen, Position.X, Position.Y, Radius, Radius);
                graphics.FillEllipse(GreenBrush, Position.X, Position.Y, Radius, Radius);
            }
        }
    }
}
