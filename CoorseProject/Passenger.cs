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
          Для внесения пользователя в базу данных используется метод  WriteInFile(), который получает в качестве параметра номер рейса
          (номер рейса является уникальным и поэтому в коллекции рейсов не может быть двух одинаковых по номеру рейсов) и записывает в нужный файл.
          Этот "нужный" файл создаётся сразу, когда пользователь нажимает на кнопку "Найти". Проще говоря каждый рейс имеет отдельный файл, 
          в котором хранятся данные о его пассажирах. 
          Для удобства обработки информации в классе переопределён метод ToString().

    */

    class Passenger
    {
        public Passenger(string name, string surname, string middlename)
        {
            Name = name;
            Surname = surname;
            MiddleName = middlename;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        

        public override string ToString()
        {
            return string.Format("{0}_{1}_{2}", Name, Surname, MiddleName);
        }

        public void WriteInFile(int n)
        {
            File.AppendAllText(n + "Passangers.txt", "\n" + ToString() + "\r", Encoding.GetEncoding("Windows-1251"));
        }
    }
}
