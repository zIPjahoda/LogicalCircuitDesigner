using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class ANDGate : ComponentBundle
    {

        public ANDGate() : base(new ANDComponent(), new ANDRenderable())
        {
            DimRatio = 1 / 0.66f;
        }

    }
}