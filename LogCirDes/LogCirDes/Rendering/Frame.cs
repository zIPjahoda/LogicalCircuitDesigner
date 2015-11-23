using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCirDes
{
    class Frame
    {

        public Dimension Dimension { get; set; }
        public Coordinate Position { get; set; }

        public int X
        {
            get { return (int)Position.X; }
            set { Position.X = value; }
        }

        public int Y
        {
            get { return (int)Position.Y; }
            set { Position.Y = value; }
        }

        public int Width
        {
            get { return Dimension.Width; }
            set { Dimension.Width = value; }
        }

        public int Height
        {
            get { return Dimension.Height; }
            set { Dimension.Height = value; }
        }

        public Frame(int x, int y, int width, int height) 
            : this(new Coordinate(x, y), new Dimension(width, height))
        {
        }

        public Frame(Coordinate pos, Dimension dim)
        {
            Dimension = dim;
            Position = pos;
        }

        public bool Intesects(Frame other)
        {
            return ToRectangle().IntersectsWith(other.ToRectangle());
        }

        public bool IsInside(Coordinate c)
        {
            return ToRectangle().IntersectsWith(new Rectangle((int)c.X, (int)c.Y, 1, 1));
        }

        public Rectangle ToRectangle()
        {
            return new Rectangle(X, Y, Width, Height);
        }

    }
}
