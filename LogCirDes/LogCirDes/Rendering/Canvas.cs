#define RUNNING

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace LogCirDes
{
    public class Canvas : PictureBox
    {
        private int _GridRaster;
        public int GridRaster
        {
            get
            {
                return _GridRaster;
            }
            set
            {
                _GridRaster = value;
                InitGrid(_GridRaster);
            }
        }
        private List<Renderable> Renderables { get; set; }
        private Bitmap GridTexture;

        public event PaintEventHandler Painted;

        public Canvas() : base()
        {
            Renderables = new List<Renderable>();
            GridRaster = 10;
            Paint += OnPaint;
            MouseMove += OnMouseMove;
        }

        private void OnPaint(object sender, PaintEventArgs paintEventArgs)
        {
            Graphics g = paintEventArgs.Graphics;

            Clear(g);
            RenderGrid(GridRaster, g);

            foreach (Renderable renderable in Renderables)
            {
                if (!renderable.Render(g))
                    throw new Exception("Failed to render!");
            }

            if (paintEventArgs == null)
                throw new Exception("For some strange reason EventArgs are null.");

            try
            {
                Painted(this, paintEventArgs);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to call event painted! " + ex.Message);
            }

        }

        public void Render(Renderable renderable)
        {
            Renderables.Add(renderable);
            Update();
        }

        public void RemoveRenderable(Renderable renderable)
        {
            Renderables.Remove(renderable);
            Update();
        }

        private void RenderGrid(int raster, Graphics g)
        {
            if(GridTexture.Width != Width || GridTexture.Height != Height)
            {
                InitGrid(GridRaster);
            }

            g.DrawImage(GridTexture, new Point(0, 0));
        }

        private void InitGrid(int raster)
        {
            GridTexture = new Bitmap(Width, Height);

            if (raster < 5)
                raster += 5;

            int padding = raster;

            for (int x = padding; x < (Width - padding); x += raster)
            {
                for (int y = padding; y < (Height - padding); y += raster)
                {
                    GridTexture.SetPixel(x, y, Color.Black);
                }
            }
        } 

        private void Clear(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);
        }

        private void OnMouseMove(object sender, MouseEventArgs args)
        {
            Refresh();
        }
    }
}