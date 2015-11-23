using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class Coordinate
    {
        public float X { get; set; }

        public float Y { get; set; }

        /// <summary>
        /// Returns the distance between this coordinate and the one given in parameters.
        /// </summary>
        public double GetDistance(Coordinate other)
        {
            float deltaX = X - other.X;
            float deltaY = Y - other.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public Coordinate(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Coordinate() : this(0, 0)
        {
        }

        public override string ToString()
        {
            return "X: " + X + " Y: " + Y;
        }
    }
}
