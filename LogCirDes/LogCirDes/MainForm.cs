using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogCirDes
{
    public partial class MainForm : ContentForm
    {

        public Project CurrentProject { get; set; }
        public ComponentBundle CurrentlySelected { get; set; }

        public MainForm()
        {
            Console.WriteLine("Comp INIT!");

            InitializeComponent();
            Settings.GridType = Settings.GRID_TYPE_DOTS;
            Settings.DisplayGrid = true;

            RasterTextBox.Text = Convert.ToString(ProjectCanvas.GridRaster);
            CurrentProject = new Project();

            ProjectCanvas.Painted += Canvas_Painted;
            RenderRefreshTimer.Start();
        }

        private void RasterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProjectCanvas.GridRaster = Convert.ToInt32(RasterTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The entered raster is not a valid number!", "Error");
                return;
            }

            ProjectCanvas.Refresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void AddANDButton_Click(object sender, EventArgs e)
        {
            ANDGate gate = new ANDGate();
            gate.Position = new Coordinate(0, 0);
            gate.Dimension = new Dimension(66, 100);

            CurrentlySelected = gate;

            CurrentProject.AddComponent(gate);
            Refresh();
        }

        private void Canvas_Painted(object sender, PaintEventArgs e)
        {
            CurrentProject.Render(e.Graphics);
            CurrentlySelected?.Render(e.Graphics);
        }

        private void ProjectCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (CurrentlySelected == null)
            {
                return;
            }

            //Move component to mouse position
            CurrentlySelected.Center = new Coordinate(
                    e.X - e.X % ProjectCanvas.GridRaster,
                    e.Y - e.Y % ProjectCanvas.GridRaster);

            //Align the component with the grid
            if (CurrentlySelected.Position.X % ProjectCanvas.GridRaster != 0)
            {
                CurrentlySelected.Position.X -= CurrentlySelected.Position.X % ProjectCanvas.GridRaster;
            }

            if(CurrentlySelected.Position.Y % ProjectCanvas.GridRaster != 0)
            {
                CurrentlySelected.Position.Y -= CurrentlySelected.Position.Y % ProjectCanvas.GridRaster;
            }
                
        }

        private void RenderRefreshTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ProjectCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Click!");
            if(e.Button == MouseButtons.Left)
            {
                if(CurrentlySelected != null)
                {
                    CurrentlySelected = null;
                } else
                {
                    CurrentlySelected = CurrentProject.FindComponent(e.X, e.Y);
                }
            }
        }
    }
}
