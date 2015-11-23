using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class Settings
    {
        public static int GRID_TYPE_LINES = 2;
        public static int GRID_TYPE_DOTS = 1;

        public static bool DisplayGrid { get; set; }
        public static int GridType { get; set; }

    }
}