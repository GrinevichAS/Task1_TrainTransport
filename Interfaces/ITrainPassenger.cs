using System.Collections.Generic;
using TrainTransport.Classes;

namespace TrainTransport.Interfaces
{
    public interface ITrainPassenger: ITrain
    {
        ICollection<CarriagePassenger> Carriages { get; }
    }
}