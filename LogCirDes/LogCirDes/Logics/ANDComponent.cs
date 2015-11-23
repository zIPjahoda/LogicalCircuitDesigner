using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogCirDes.Logics;

namespace LogCirDes
{
    public class ANDComponent : LogicComponent
    {



        protected override bool CalculateValue()
        {
            foreach (LogicInput input in Inputs)
            {
                if (!input.Wire.Value)
                    return false;
            }
            return true;
        }
    }
}