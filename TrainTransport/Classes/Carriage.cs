using System;
using TrainTransport.Interfaces;

namespace TrainTransport.Classes
{
     abstract class Carriage : ICarriage
    {
        public string Name { get; set; }
        public double Tare { get; set; }

        public abstract double GetWeight();

    }
}