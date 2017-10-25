using System;

namespace TrainTransport.Interfaces
{
    public interface ICarriage
    {
        string Name { get; }
        double Tare { get; }
    }
}