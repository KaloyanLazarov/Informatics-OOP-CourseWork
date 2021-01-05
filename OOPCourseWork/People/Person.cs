using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace People
{
    [Serializable]
    public abstract class Person
    {
        public Point Position { get; private set; }
        public Point NextPosition { get; private set; }
        protected int DeltaPerFrame { get; set; }
        private int deltaX;
        protected double DeltaX { 
            get
            {
                return deltaX;
            }
            set
            {
                if (value < 0)
                    deltaX = (int)Math.Floor(value);
                else
                    deltaX = (int)Math.Ceiling(value);
            }
        }
        private int deltaY;
        protected double DeltaY
        {
            get
            {
                return deltaY;
            }
            set
            {
                if (value < 0)
                    deltaY = (int)Math.Floor(value);
                else
                    deltaY = (int)Math.Ceiling(value);
            }
        }
        protected int Radius { get; set; }
        public bool IsWearingMask { get; set; }

        public Person(Point position, Point nextPosition, int radius, bool isWearingMask=false, int deltaPerFrame=170)
        {
            Position = position;
            NextPosition = nextPosition;
            Radius = radius;
            IsWearingMask = isWearingMask;
            DeltaPerFrame = deltaPerFrame; // Higher the value, lower distance moved per frame, therefore lower speed
            DeltaX = (double)(NextPosition.X - Position.X) / DeltaPerFrame;
            DeltaY = (double)(NextPosition.Y - Position.Y) / DeltaPerFrame;

        }

        public abstract void Draw(IGraphics graphics);
        public virtual void Move()
        {
            Random r = new Random();
            if (Enumerable.Range(NextPosition.X - 50, NextPosition.X + 50).Contains(Position.X) ||
                Enumerable.Range(NextPosition.Y - 50, NextPosition.Y + 50).Contains(Position.Y))
            {
                NextPosition = new Point(r.Next(50, 950), r.Next(50, 700));
                DeltaX = (double)(NextPosition.X - Position.X) / DeltaPerFrame;
                DeltaY = (double)(NextPosition.Y - Position.Y) / DeltaPerFrame;
            }
            else
            {
                Position = new Point(Position.X + (int)DeltaX, Position.Y + (int)DeltaY);
            }
        }
    }
}
