using System;
using TrainTransport.Interfaces;

namespace TrainTransport.Classes
{
    public class Locomotive : ILocomotive
    {
        private string _name;
        private double _power;
        private double _speed;

        public string Name
        {
            get { return _name; }
            set { _name = value != "" ? value : "UnNamedLocom"; }
        }

        public double Power
        {
            get { return _power; }
            set { _power = value > 0 ? value : 300; }
        }

        public double Speed
        {
            get { return _speed; }
            set { _speed = value > 0 ? value : 100; }
        }

        public Locomotive(string name, double power, double speed)
        {
            this.Name = name;
            this.Power = power;
            this.Speed = speed;
        }
    }
}