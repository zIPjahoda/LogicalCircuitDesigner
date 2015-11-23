using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogCirDes.Logics;

namespace LogCirDes
{
    public class NOTComponent : LogicComponent
    {
        public NOTComponent() : base()
        {
            MaxInputs = 1;
            
        }

        protected override bool CalculateValue()
        {
            return !Inputs[0].Wire.Value;
        }
    }
}