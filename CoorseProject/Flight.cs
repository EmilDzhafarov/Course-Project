using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoorseProject
{
    class Flight
    {
        public int Number; // Номер рейса

        public string DepartureFrom; // Откуда отправляется

        public string ArrivalIn; // Куда направляется

        public Passengers ListOfPassengers; // Список пассажиров, зарегистрированных на рейс

        public DateTime Departure; // Время и день вылета

        private int CountPlaces;

        public string[] StopStation; // Места промежуточной посадки

        public Flight(int num, string dep, string arrival, string time, string day,int countPlace, params string[] mas)
        {
            Number = num; 
            DepartureFrom = dep; 
            ArrivalIn = arrival; 
            Departure = Convert.ToDateTime(day + " " + time); 
            StopStation = mas;
            CountPlaces = countPlace;
            ReadFromFile(); 
        }

        public int FreePlaces // Свойство, которое показывает количество свободных мест на борту 
        {
            get
            {
                return ListOfPassengers.passengers.Length - ListOfPassengers.Count;
            }
        }

        private void ReadFromFile()
        {
            ListOfPassengers = new Passengers(CountPlaces);
            
            FileStream file = new FileStream(Number + "Passangers.txt", FileMode.OpenOrCreate);
            StreamReader pass = new StreamReader(file);
            
            while (!pass.EndOfStream)
            {
                string s = pass.ReadLine();
                string[] arr = s.Split('_');
                if (arr.Length == 3)
                    ListOfPassengers.AddPassenger(new Passenger(arr[0], arr[1], arr[2]));
                
            }
            pass.Close();
            file.Close();
            
        }
        public override string ToString()
        {
            
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                Number, 
                DepartureFrom,
                ArrivalIn,
                Departure.TimeOfDay.ToString("hh':'mm"),
                Departure.ToString().Split(' ')[0],
                CountPlaces,
                Program.GetStations(StopStation));
        }

        public void WriteInFile(string path)
        {
            using (StreamWriter wr = new StreamWriter(path, true))
            {
                wr.WriteLine(ToString());
                wr.Close();
            }
        }
    }
}
