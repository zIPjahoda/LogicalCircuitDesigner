using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public abstract class Renderable
    {
        /// <summary>
        /// Image to be rendered.
        /// </summary>
        public Image Texture
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public float Rotation
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Dimension Dimension
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Coordinate Coordinate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Renders the renderable using the Renderer given in parameters.
        /// </summary>
        public bool Render()
        {
            throw new System.NotImplementedException();
        }
    }
}