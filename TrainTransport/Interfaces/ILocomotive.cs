using System.Security.Cryptography.X509Certificates;

namespace TrainTransport.Interfaces
{
    public interface ILocomotive
    {
        string Name { get; }
        double Speed { get; }
        double Power { get; }
    }
}