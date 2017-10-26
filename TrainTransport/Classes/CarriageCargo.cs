namespace TrainTransport.Classes
{
    public class CarriageCargo: Carriage
    {
        private string _name;
        private double _tare;
        private double _carrying;

        public new string Name
        {
            get { return _name; }
            set { _name = value != "" ? value : "UnNamedCarr"; }
        }
        public new double Tare
        {
            get { return _tare; }
            set { _tare = value >= 0 ? value : 100; } 
        }

        public double Carrying
        {
            get { return _carrying;}
            set { _carrying = value >= 0 ? value : 100; }
        }

        public CarriageCargo(string name, double tare, double carrying)
        {                                           
            this.Name = name;
            this.Tare = tare;
            this.Carrying = carrying;
        }
    }
}