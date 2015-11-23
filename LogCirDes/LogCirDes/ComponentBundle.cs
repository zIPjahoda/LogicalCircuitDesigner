using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using LogCirDes.Logics;
using System.Windows.Forms;

namespace LogCirDes
{
    public class ComponentBundle
    {
        public event EventHandler ValueChange;

        public List<Coordinate> InputPositions { get; set; }
        public Coordinate OutputPosition { get; set; }
        public Dimension PinSize { get; set; }

        public Coordinate Position
        {
            get { return Renderable.Position; }
            set { Renderable.Position = value; }
        }

        public Dimension Dimension
        {
            get { return Renderable.Dimension; }
            set { Renderable.Dimension = value; }
        }

        public int Width
        {
            get { return Dimension.Width; }
            set { Dimension.Width = value; }
        }

        public int Height
        {
            get { return (int)(Dimension.Width * DimRatio); }
            private set { }
        }

        public float DimRatio
        {
            get; set;
        }

        public Coordinate Center
        {
            get { return new Coordinate(Position.X + Width / 2, Position.Y + Height / 2); }
            set { Position = new Coordinate(value.X - Width / 2, value.Y - Height / 2);  }
        }

        public LogicComponent LogicalPart { get; set; }

        public Renderable Renderable { get; set; }

        public ComponentBundle(LogicComponent component, Renderable renderable)
        {
            LogicalPart = component;
            Renderable = renderable;
        }

        public ComponentBundle() : this(null, null)
        {
        }

        public bool Value
        {
            get { return LogicalPart.Value; }
            set { LogicalPart.ForcedValue = value; }
        }

        public void Render(Graphics g)
        {
            Rectangle rectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
            g.DrawImage(Renderable.Texture, rectangle); 
        }

        public void Update()
        {
            
        }
    }
}