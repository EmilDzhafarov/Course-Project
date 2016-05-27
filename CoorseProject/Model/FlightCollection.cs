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
            подключение к указанному файлу, который содержит в себе все рейсы. Благодаря тому, что конструктор может принимать от 0 до 2 параметров,
            в коллекцию попадают только те рейсы, которые удовлетворяют параметрам конструктора.
    */

    class FlightCollection : List<Flight>
    {
        public string Path;
        public FlightCollection(string _path,string dep = null, string arrival = null)
        {
            Path = _path;
            this.CheckFile();
            DateTime now = DateTime.Now;
            using (StreamReader flights = new StreamReader(Path))
            {
                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                    if (arr.Length != 9)
                    {
                        throw new Exception();
                    }
                   
                    if (dep != null && arrival != null)
                    {
                        if (Convert.ToDateTime(arr[3] + " " + arr[4]) >= now &&
                           (arr[1] == dep && arr[2] == arrival || arr[1] == dep && arr[8].IndexOf(arrival) != -1))
                        {
                            this.Add(new Flight(arr[0], arr[1], arr[2], arr[3],arr[4], arr[5], arr[6], Convert.ToInt32(arr[7]), arr[8].Split(',')));
                        }
                    }

                    else if ((dep == null || arrival == null) && Convert.ToDateTime(arr[3] + " " + arr[4]) >= now)
                    {
                          this.Add(new Flight(arr[0], arr[1], arr[2], arr[3],arr[4], arr[5], arr[6], Convert.ToInt32(arr[7]), arr[8].Split(',')));
                    }
                   
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
            using (StreamWriter wr = new StreamWriter(Path, true))
            {
                foreach(Flight ob in this)
                {
                    wr.WriteLine(ob.ToString());
                }
                wr.Close();
            }
        }
        public void ClearFile() // метод, который очищает файл, который хранит все рейсы.
        {
            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write("");
                wr.Close();
            }
        }
        public Flight FindByNumber(int num) // Метод, который находит заданный по номеру рейс
        {
            foreach(Flight ob in this)
            {
                if (ob.Number == num)
                {
                    return ob;
                }
            }
            return null;
        }

        public void AddFlightAndWriteInFile(Flight obj) // Метод, который добавляет рейс и сразу записывает его в файл
        {
            this.Add(obj);
            using (StreamWriter wr = new StreamWriter(Path, true))
            {
                wr.WriteLine(obj.ToString());
                wr.Close();
            }
        }

        public void RemoveFlightAndFile(string num) // Метод для удаления рейса и файла, содержащего список пассажиров, зарегистрированных на этот рейс
        {
            Flight Current = this.FindByNumber(Convert.ToInt32(num));

            if (Current != null)
            {
                this.Remove(Current);

                if (File.Exists("Passengers\\" + num + "Passengers.txt") == true)
                {
                    File.Delete("Passengers\\" + num + "Passengers.txt");
                }
            }
        }
        public void CheckFile() // Метод для проверки на существование файла со всеми рейсами
        {
            if (File.Exists(Path) == false)
            {
                if (Directory.Exists("Passengers"))
                {
                    Directory.Delete("Passengers", true);
                }

                FileStream file = new FileStream(Path,FileMode.Create);
                file.Close();
            }
        }
    }
}
