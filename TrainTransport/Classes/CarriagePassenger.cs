﻿namespace TrainTransport.Classes
{
    public class CarriagePassenger : Carriage
    {
        private string _name;
        private double _tare;
        private double _baggage;
        private int _maxPassengers;
        public int PassengersNumber { get; set; }
        public Comfort Comfort;

        public new string Name
        {
            get { return _name; }
            set { _name = value != "" ? value : "UnNamed"; }
        }
        public new double Tare
        {
            get { return _tare; }
            set { _tare = value >= 0 ? value : 100; } //100?
        }

        public int MaxPassengers
        {
            get { return _maxPassengers; }
            private set { _maxPassengers = value >= 0 ? value : 40; }
        }
        
        public double Baggage
        {
            get { return _baggage; }
            set { _baggage = value >= 0 ? value : 0; }
        }

        public CarriagePassenger(string name, double tare, int maxPassengers, double baggage)
        {
            this.Name = name;
            this.Tare = tare;
            this.MaxPassengers = maxPassengers;
            this.Baggage = baggage;
        }

    }
}
