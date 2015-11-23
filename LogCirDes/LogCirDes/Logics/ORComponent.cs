using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogCirDes.Logics;

namespace LogCirDes
{
    public class ORComponent : LogicComponent
    {
        protected override bool CalculateValue()
        {
            foreach (LogicInput input in Inputs)
            {
                if (input.Wire.Value)
                    return true;
            }
            return false;
        }
    }
}