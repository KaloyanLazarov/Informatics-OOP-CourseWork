using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    [Serializable]
    public class Infected : Person
    {
        public int ChanceToInfect { get; set; }
        public int InfectiousRadius { get; set; }
        public int R { get; set; }

        public Infected(Point position, Point nextPosition, bool isWearingMask=false, int chanceToInfect = 90, int radius = 10)
            : base(position, nextPosition, radius, isWearingMask)
        {
            ChanceToInfect = chanceToInfect;
            InfectiousRadius = isWearingMask ? Radius * 5 : Radius * 10;
        }

        public override void Draw(IGraphics graphics)
        {
            using (var RedPen = new Pen(Color.Red))
            using (var RedBrush = new SolidBrush(Color.Red))
            {
                graphics.DrawEllipse(RedPen, Position.X, Position.Y, Radius, Radius);
                graphics.FillEllipse(RedBrush, Position.X, Position.Y, Radius, Radius);
            }

            DrawInfectiousArea(graphics);
        }

        public void DrawInfectiousArea(IGraphics graphics)
        {   
            using (var RedPen = new Pen(Color.Red))
            {
                graphics.DrawEllipse(RedPen,
                    Position.X - (InfectiousRadius / 2),
                    Position.Y - (InfectiousRadius / 2),
                    Radius + InfectiousRadius,
                    Radius + InfectiousRadius);
            }
        }

        public Person[] NearbyPeople(Person[] ActivePeople)
        {
            return ActivePeople
                .Where(p => Position.X - InfectiousRadius <= p.Position.X 
                         && Position.X + InfectiousRadius >= p.Position.X
                         && Position.Y - InfectiousRadius <= p.Position.Y
                         && Position.Y + InfectiousRadius >= p.Position.Y)
                .ToArray();
        }
    }
}
