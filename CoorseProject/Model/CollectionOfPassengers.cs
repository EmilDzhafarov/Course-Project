using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoorseProject
{
    /*
         Класс CollectionOfPassengers предназначен для хранения списка пассажиров на определённом рейсе.
         В основание класса положен массив Passenger[] и реализованы несколько методов. Для удобства работы переопределён метод ToString().
    */

    public class CollectionOfPassengers
    {
        public Passenger[] passengers;

        public int Count { get; private set; }

        public CollectionOfPassengers(int k)
        {
            passengers = new Passenger[k];
            Count = 0;
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
        }
    }
}
