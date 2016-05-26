using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoorseProject
{
    /*
         Класс Passengers предназначен для хранения списка пассажиров на определённом рейсе. В основание класса положен массив Passenger[]
         и реализованы несколько методов. Для удобства работы переопределён метод ToString().
    */
    class Passengers
    {
        public Passenger[] passengers;

        public int Count { get; private set; }

        public Passengers(int k)
        {
            passengers = new Passenger[k];
        }

        public Passenger this[int index]
        {
            get
            {
                return passengers[index];
            }
            set
            {
                passengers[index] = value;
            }
        }

        public void AddPassenger(Passenger user)
        {
            if (Count < passengers.Length)
            {
                passengers[Count] = user;
                Count++;
            }
            else
                throw new Exception("Нет такого количества свободных мест!");

        }

        public override string ToString()
        {
            string rez = "";
            for (int i = 0; i < this.Count; i++)
            {
                rez += "\n" + passengers[i];
            }
            return rez;
        }
    }
}
