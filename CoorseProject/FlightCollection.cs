using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoorseProject
{
    /*
            Класс FlightCollection наследуемый от List<Flight>, предназначен для подключения к файлу Flights.txt, который содержит в себе 
            все дступные рейсы, и создания коллекции этих рейсов. Метод  GetCollection() ищет в этой коллекции рейсы, маршрут которых совпадает 
            с параметрами метода.
    */
    class FlightCollection :List<Flight>
    {
        public FlightCollection()
        {
            StreamReader flights = new StreamReader("Flights.txt");
            while (!flights.EndOfStream)
            {
                string s = flights.ReadLine();
                string[] arr = s.Split('|');
                this.Add(new Flight(Convert.ToInt32(arr[0]), arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));
            }
        }

        public List<Flight> GetCollection(string dep, string arr)
        {
            List<Flight> result = new List<Flight>();
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].DepartureFrom == dep && this[i].ArrivalIn == arr)
                {
                    result.Add(this[i]);
                }
            }

            return result;
        }
    }
}
