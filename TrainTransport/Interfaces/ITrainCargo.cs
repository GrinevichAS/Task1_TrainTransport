using System.Collections.Generic;
using TrainTransport.Classes;

namespace TrainTransport.Interfaces
{
    public interface ITrainCargo: ITrain
    {
        ICollection<CarriageCargo> Carriages { get; }
    }
}