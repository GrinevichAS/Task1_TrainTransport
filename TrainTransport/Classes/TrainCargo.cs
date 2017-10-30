using System;
using System.Collections.Generic;
using TrainTransport.Interfaces;

namespace TrainTransport.Classes
{
    public class TrainCargo : ITrainCargo
    {
        public Locomotive Locomotive { get; private set; }
        public ICollection<CarriageCargo> Carriages { get; private set; }

        public TrainCargo(Locomotive locomotive, ICollection<CarriageCargo> carriages)
        {
            this.Locomotive = locomotive;
            this.Carriages = carriages;
        }
    }
}
