using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class Wire
    {
        public event EventHandler ValueChanged;

        public bool Value
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}