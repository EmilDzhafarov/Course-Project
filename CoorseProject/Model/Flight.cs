using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoorseProject
{
    public class Flight
    {
        private DateTime _arrival;
        private DateTime _departure;

        public Flight(string num, string dep, string arrival, 
                      string deptime, string depday, 
                      string arrtime, string arrday, int price, 
                      int countPlace, params string[] mas) 
        {
            Number = Convert.ToInt32(num); 
            DepartureFrom = Program.RemoveSpaces(dep); 
            ArrivalIn = Program.RemoveSpaces(arrival); 
            _departure = Convert.ToDateTime(depday + " " + deptime);
            _arrival = Convert.ToDateTime(arrday + " " + arrtime);
            if (_arrival <= _departure || _departure < DateTime.Now)
                throw new Exception();
            StopStation = mas;
            CountPlaces = countPlace;
            TicketPrice = price;
            ReadFromFile(); 
        }
        
        public int Number { get; set; } // Номер рейса

        public string DepartureFrom { get; set; } // Откуда отправляется

        public string ArrivalIn { get; set; }   // Куда направляется

        public CollectionOfPassengers ListOfPassengers { get; set; } // Список пассажиров, зарегистрированных на рейс

        public DateTime Departure // Время и день вылета
        {
            get
            {
                return _departure;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception();
                }
                else
                    _departure = value;
            }
        } 

        public DateTime Arrival // Время и день прибытия
        {
            get
            {
                return _arrival;
            }
            set
            {
                if (value <= Departure)
                {
                    throw new Exception();
                }
                else
                    _arrival = value;
            }
        } 

        public int TicketPrice { get; set; } // Стоимость билета на рейс

        public int CountPlaces { get; set; } // Общее количество мест

        public string[] StopStation { get; set; }  // Места промежуточной посадки

        public int FreePlaces // Свойство, которое показывает количество свободных мест на борту 
        {
            get
            {
                return ListOfPassengers.passengers.Length - ListOfPassengers.Count;
            }
        }

        public void ReadFromFile() // Метод, предназначенный для подключения к файлу определенного рейса для получения списка пассажиров
        {
            ListOfPassengers = new CollectionOfPassengers(CountPlaces);
            Directory.CreateDirectory("Passengers");
            using (FileStream file = new FileStream("Passengers\\" + Number + "Passengers.txt", FileMode.OpenOrCreate))
            {
                StreamReader pass = new StreamReader(file);

                while (!pass.EndOfStream)
                {
                    string s = pass.ReadLine();
                    string[] arr = s.Split('_');
                    if (arr.Length == 3)
                        ListOfPassengers.AddPassenger(new Passenger(arr[0], arr[1], arr[2]));
                    else
                        throw new ArgumentOutOfRangeException(); //Выбрасываем исключение если не содержит трёх элементов (имя, фамилия, отчество)
                }
                pass.Close();
                file.Close();
            }
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}",
                Number,
                DepartureFrom,
                ArrivalIn,
                Departure.TimeOfDay.ToString("hh':'mm"),
                Departure.ToString().Split(' ')[0],
                Arrival.TimeOfDay.ToString("hh':'mm"),
                Arrival.ToString().Split(' ')[0],
                TicketPrice,
                CountPlaces,
                Program.GetStations(StopStation));
        }
    }
}
