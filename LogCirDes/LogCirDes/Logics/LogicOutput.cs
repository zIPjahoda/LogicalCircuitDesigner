using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class LogicOutput
    {
        public event EventHandler ValueChanged;

        public LogicComponent Parent
        {
            get;
            set;
        }

        public Wire Wire
        {
            get;
            set;
        }
    }
}