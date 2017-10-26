using System;
using System.Collections.Generic;
using System.Linq;
using TrainTransport.Interfaces;

namespace TrainTransport.Classes
{
    public class TrainPassenger: ITrainPassenger
    {
        public Locomotive Locomotive { get; set; }
        public ICollection<CarriagePassenger> Carriages { get; set; }

        public TrainPassenger(Locomotive locomotive, ICollection<CarriagePassenger> carriages)
        {
            this.Locomotive = locomotive;
            this.Carriages = carriages;
        }

        public IEnumerable<CarriagePassenger> SortByComfort()
        {
            return Carriages.OrderBy(x => x.Comfort).ToArray();
        }

    }
}