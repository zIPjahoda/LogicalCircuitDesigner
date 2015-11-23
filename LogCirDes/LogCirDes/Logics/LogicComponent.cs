using LogCirDes.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;

namespace LogCirDes
{
    public abstract class LogicComponent
    {
        public event EventHandler StateChanged;

        public LogicInput[] Inputs
        {
            get { return Inputs; }

            set
            {
                if(value.Length < MinInputs)
                    throw new Exception("You cannot have less than " + MinInputs + " inputs.");
                else if(value.Length > MaxInputs)
                    throw new Exception("You cannot have more than " + MaxInputs + " inputs.");

                Inputs = value;
            }
        }

        public LogicOutput Output
        {
            get { return Output; }

            set
            {
                if(value == null)
                    throw new Exception("Each component must have an output and " +
                                        "thus you cannot assign null to an output.");
                Output = value;
            }
        }

        public int MaxInputs
        {
            get { return MaxInputs; }

            set { MaxInputs = value; }
        }

        public int MinInputs { get; set; }

        public bool Value
        {
            get
            {
                Value = CalculateValue();
                return Value;
            }
            private set { }
        }

        public bool ForcedValue { get; set; }

        protected abstract bool CalculateValue();

    }
}