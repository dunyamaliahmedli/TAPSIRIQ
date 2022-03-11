using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask.Model
{
    class Bus : Vehicle

    {
        public Bus(string model)
        {
            this.model = model;
        }
        public Bus(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Bus(string model, string color, int passengerCount) : this(model, color)
        {
            this.passengerCount = passengerCount;
        }
        public Bus(string model, string color, int passengerCount, int cycle) : this(model, color, passengerCount)
        {
            this.cycle = cycle;
        }

    }
}

    

