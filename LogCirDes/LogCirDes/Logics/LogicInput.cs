using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCirDes.Logics
{
    public class LogicInput
    {
        public event EventHandler ValueChanged;

        public LogicComponent Parent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Wire Wire
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
