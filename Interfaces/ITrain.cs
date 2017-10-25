using System;
using System.Collections.Generic;
using TrainTransport.Classes;

namespace TrainTransport.Interfaces
{
    public interface ITrain
    {
        Locomotive Locomotive { get; }
    }
}