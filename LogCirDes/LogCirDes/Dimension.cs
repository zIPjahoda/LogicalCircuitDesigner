using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class Dimension
    {
        /// <summary>
        /// The width of the dimension
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// The height of the dimension
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Area covered by this dimension.
        /// </summary>
        public int Area => Width*Height;

        public Dimension(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Dimension() : this(0, 0)
        {

        }

        public string ToString()
        {
            return "Width: " + Width + " Height: " + Height;
        }
    }
}