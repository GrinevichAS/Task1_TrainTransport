using System;
using TrainTransport.Interfaces;

namespace TrainTransport.Classes
{
    public abstract class Carriage : ICarriage
    {
        public string Name { get; }
        public double Tare { get; }
    }
}