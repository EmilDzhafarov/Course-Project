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
            подключение к указанному файлу, который содержит в себе все рейсы. Однако конструктор перегружен  и принимает два параметра: 
            "откуда" и "куда". Благодаря этому в коллекцию попадают только те рейсы, которые удовлетворяют
            параметрам конструктора.
    */

    class FlightCollection :List<Flight>
    {
        public FlightCollection(string dep,string arrival)
        {
            CreateFlightCollection();
            List<Flight> rez = new List<Flight>();

            foreach (Flight obj in this)
            {
                if ((obj.DepartureFrom == dep && obj.ArrivalIn == arrival) ||
                        (Array.IndexOf(obj.StopStation,arrival) != -1 && obj.DepartureFrom == dep))
                {
                    rez.Add(obj);
                }
            }

            this.Clear();
            this.AddRange(rez);
        }

        public FlightCollection()
        {
            CreateFlightCollection();
        }

        private void CreateFlightCollection() 
        {
            using (StreamReader flights = new StreamReader("Flights.txt"))
            {
                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                    if (arr.Length != 10)
                    {
                        throw new Exception();
                    }

                    this.Add(new Flight(arr[0], arr[1], arr[2], arr[3],
                                        arr[4], arr[5], arr[6],
                                        Convert.ToInt32(arr[7]), Convert.ToInt32(arr[8]), arr[9]));
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

        public void WriteInFile() // Метод, который записывает в файл построчно данные о всех рейсах
        {
            using (StreamWriter wr = new StreamWriter("Flights.txt", true))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    wr.WriteLine(this[i].ToString());
                }
                wr.Close();
            }
        }
        public void ClearFile() // метод, который очищает файл, который хранит все рейсы.
        {
            using (StreamWriter wr = new StreamWriter("Flights.txt"))
            {
                wr.Write("");
                wr.Close();
            }
        }
        public Flight FindByNumber(int num) // Метод, который находит заданный по номеру рейс
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Number == num)
                {
                    return this[i];
                }
            }
            return null;
        }

        public void AddFlightAndWriteInFile(Flight obj) // Метод, который добавляет рейс и сразу записывает его в файл
        {
            this.Add(obj);
            using (StreamWriter wr = new StreamWriter("Flights.txt", true))
            {
                wr.WriteLine(obj.ToString());
                wr.Close();
            }
        }
    }
}
