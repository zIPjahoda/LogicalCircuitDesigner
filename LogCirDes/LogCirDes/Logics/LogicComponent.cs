using LogCirDes.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogCirDes
{
    public class LogicComponent
    {
        public event EventHandler StateChanged;

        public LogicInput[] Inputs
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public LogicOutput Output
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void IsEnabled()
        {
            throw new System.NotImplementedException();
        }
    }
}