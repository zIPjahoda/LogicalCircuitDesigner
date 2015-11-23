using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogCirDes
{
    public abstract class Renderable
    {
        /// <summary>
        /// Image to be rendered.
        /// </summary>
        public Image Texture { get; set; }

        public float Rotation { get; set; }

        public Dimension Dimension { get; set; }

        public Coordinate Position { get; set; }

        public Renderable(String texturePath)
        {
            Texture = new Bitmap(texturePath);
            Position = new Coordinate();
            Dimension = new Dimension();
        }

        /// <summary>
        /// Renders itself using the Graphics object supplied in parameters.
        /// </summary>
        public bool Render(int inputs, Graphics g)
        {
            if(Texture == null)
                Console.WriteLine("Texture is null! Cannot render object!");
            try
            {
                int compWidth = (int)(Dimension.Width * 0.6f);
                int compHeight = (int)(Dimension.Height * 0.6f);



                Rectangle targetRectangle = new Rectangle((int) Position.X, (int) Position.Y, Dimension.Width,
                    Dimension.Height);

                g.DrawImage(Texture, targetRectangle);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}