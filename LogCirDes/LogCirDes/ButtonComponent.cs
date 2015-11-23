using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class ButtonComponent : LogicComponent
    {
        public ButtonComponent() : base()
        {
            MaxInputs = 0;
        }

        protected override bool CalculateValue()
        {
            return false;
        }
    }
}