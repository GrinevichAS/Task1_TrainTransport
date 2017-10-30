using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTransport.Classes;

namespace TrainTransport
{
    class Program
    {
        public static void SortComfort(TrainPassenger tr)
        {
            foreach (var carriage in tr.SortByComfort())
            {
                Console.WriteLine(carriage.Name + " " + carriage.Comfort);
            }
            Console.WriteLine("------------------------------");
        }

        public static void TotalCount(TrainPassenger tr)
        {
            int summPass = (from carriage in tr.Carriages
                           select carriage.PassengersNumber)
                           .Sum();
            double sumBagg = (from carriage in tr.Carriages
                              select carriage.Baggage)
                           .Sum();

            Console.WriteLine("Passengers: " + summPass + "  Baggage: " + sumBagg);
            Console.WriteLine("------------------------------");
        }

        public static void CarriageSearch(TrainPassenger tr, int a, int b)
        {
            if (a > b)
            {
                int x = a;
                a = b;
                b = x;
            }
            ICollection<CarriagePassenger> list = tr.Carriages
                .Where(x => x.PassengersNumber > a && x.PassengersNumber < b)
                .ToList();
            foreach (var carriage in list)
            {
                Console.WriteLine(carriage.PassengersNumber);
            }
            Console.WriteLine("---------------------------------");
        }

        static void Main(string[] args)
        {
            Locomotive locom = new Locomotive("L-01", 355, 120);
            ICollection<CarriagePassenger> carriageList = new List<CarriagePassenger>();
            carriageList.Add(new CarriagePassenger("C-11", 100, 50, 10, 32, Comfort.Low));
            carriageList.Add(new CarriagePassenger("C-10", 100, 50, 12, 30, Comfort.High));
            carriageList.Add(new CarriagePassenger("C-09", 100, 50, 15, 52, Comfort.High));
            carriageList.Add(new CarriagePassenger("C-13", 100, 50, 18, 25, Comfort.Medium));
            carriageList.Add(new CarriagePassenger("C-10", 100, 55, 13, 60, Comfort.Low));

            TrainPassenger train = new TrainPassenger(locom, carriageList);

            TotalCount(train);
            SortComfort(train);
            CarriageSearch(train, 30, 60);
           
            Console.ReadKey();
        }
    }
}
