using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask.Model
{
    class Car : Vehicle
    {

        public double motor;

        public Car(string model)
        {
            this.model = model;
        }
        public Car(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Car(string model, string color, int passengerCount) : this(model, color)
        {
            this.passengerCount = passengerCount;
        }
        public Car(string model, string color, int passengerCount, int cycle) : this(model, color, passengerCount)
        {
            this.cycle = cycle;
        }
        public Car(double motor)
        {

            this.motor = motor;



        }
    }
}
