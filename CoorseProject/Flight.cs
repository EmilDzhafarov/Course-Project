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


        public string[] StopStation; // Места промежуточной посадки

        public Flight(int num, string dep, string arrival, string time, string day,int countPlace, params string[] mas)
        {
            Number = num; 
            DepartureFrom = dep; 
            ArrivalIn = arrival; 
            Departure = Convert.ToDateTime(day + " " + time); 
            StopStation = mas;
            ReadFromFile(countPlace); 
        }

        public int FreePlaces // Свойство, которое показывает количество свободных мест на борту 
        {
            get
            {
                return ListOfPassengers.passengers.Length - ListOfPassengers.Count;
            }
        }

        private void ReadFromFile(int k)
        {
            ListOfPassengers = new Passengers(k);
            
            FileStream file = new FileStream(Number + "Passangers.txt", FileMode.OpenOrCreate);
            StreamReader pass = new StreamReader(file);
            
            while (!pass.EndOfStream)
            {
                string s = pass.ReadLine();
                string[] arr = s.Split('_');
                if (arr.Length == 4)
                    ListOfPassengers.AddPassenger(new Passenger(arr[0], arr[1], arr[2], arr[3]));
                
            }
            pass.Close();
            file.Close();
            
        }   
    }
}
