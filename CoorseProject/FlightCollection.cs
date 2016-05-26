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
            using (StreamReader flights = new StreamReader("Flights.txt"))
            {
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
                        (arr[6].IndexOf(arrival) != -1 && arr[1] == dep))
                        {
                            this.Add(new Flight(arr[0], arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));
                        }
                    }
                }
                flights.Close();
            }
        }

        public FlightCollection() 
        {
            using (StreamReader flights = new StreamReader("Flights.txt"))
            {
                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                    if (arr.Length != 7)
                    {
                        throw new Exception();
                    }
                    if (String.IsNullOrWhiteSpace(arr[1]) || String.IsNullOrWhiteSpace(arr[2]) || String.IsNullOrWhiteSpace(arr[3])
                        || String.IsNullOrWhiteSpace(arr[4]))
                    {
                        throw new ArgumentNullException();
                    }
                    this.Add(new Flight(arr[0], arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));
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
