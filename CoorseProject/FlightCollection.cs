using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoorseProject
{
    /*
            Класс FlightCollection наследуемый от List<Flight> является важнейшим во всей программе. В конструкторе происходит 
            подключение к текстовому файлу Flights.txt, который содержит в себе все рейсы. Однако конструктор помимо пути к файлу 
            принимает ещё два параметра: "откуда" и "куда". Благодаря этому в коллекцию попадают только те рейсы, которые удовлетворяют
            условиям:
                  1) Рейсы, у которых совпадает поле "DepartureFrom" с параметром конструктора "откуда";
                  2) Рейсы, у которых совпадает поле "ArrivalIn" с параметром конструктора "куда";
                  3) Рейсы, у которых выполняются оба вышеуказанные условия;
            Также возможна "подсадка" пассажира на определённом рейсе. Например есть рейс Москва-Стамбул, который приземляется в Харькове
            (то есть Харьков входит в массив "StopStation" этого рейса).В таком случае если пассажир введёт Харьков-Стамбул, ему будет показан
            и этот рейс.
    */

    class FlightCollection :List<Flight>
    {
        public FlightCollection(string path,string dep,string arrival)
        {
            StreamReader flights = new StreamReader(path);
            while (!flights.EndOfStream)
            {
                string s = flights.ReadLine();
                string[] arr = s.Split('|');
                if (arr.Length != 7)
                {
                    throw new Exception();
                }
                else
                {
                    if ((arr[1] == dep && arr[2] == arrival) ||
                    (arr[6].IndexOf(arrival) != -1 && arr[1] == dep) ||
                    (arr[6].IndexOf(dep) != -1 && arr[2] == arrival))
                    {
                        this.Add(new Flight(Convert.ToInt32(arr[0]), arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));   
                    }
                }
                
            }
            flights.Close();
        }

        public FlightCollection(string path)
        {
            using (StreamReader flights = new StreamReader(path))
            {
                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                    if (arr.Length != 7)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    if (String.IsNullOrWhiteSpace(arr[1]) || String.IsNullOrWhiteSpace(arr[2]) || String.IsNullOrWhiteSpace(arr[3])
                        || String.IsNullOrWhiteSpace(arr[4]))
                    {
                        throw new ArgumentNullException();
                    }
                    this.Add(new Flight(Convert.ToInt32(arr[0]), arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));
                }
                flights.Close();
            }
        }
        
        public void SortingByDays() // Метод сортировки пузырьком рейсов по отправлению. 
        {                           
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this[j].Departure > this[i].Departure)
                    {
                        var t = this[i];
                        this[i] = this[j];
                        this[j] = t;
                    }
                }
            }
        }
    }
}
