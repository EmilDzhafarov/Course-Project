using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoorseProject
{
    /*
          Класс Passenger является классом, который содержит данные о пользователе: имя, фамилия, отчество и маршрут;
          Открытое свойство "Route" (маршрут) является обязательным для каждого пользователя, так как база данных состоит
          из двух файлов: Flights.txt и Passengers.txt. Первый содержит в себе все доступные рейсы, а второй - всех пассажиров со всех
          рейсов. Для связывания двух этих файлов применяется свойство "Route", которое является обязательным и для класса Flight.
          Для внесения пользователя в базу данных используется метод  WriteInFile().
          Для удобства обработки информации в классе переопределён метод ToString().
    */

    class Passenger
    {

        public Passenger(string name, string surname, string middlename, string route)
        {
            Name = name;
            Surname = surname;
            MiddleName = middlename;
            Route = route;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Route { get; set; }

        public override string ToString()
        {
            return string.Format("{0}_{1}_{2}_{3}", Name, Surname, MiddleName, Route);
        }

        public void WriteInFile(int n)
        {
            File.AppendAllText(n + "Passangers.txt", "\n" + ToString() + "\r");
        }
    }
}
