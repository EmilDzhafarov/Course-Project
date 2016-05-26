using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoorseProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Schedule());
        }
        public static string GetStations(string[] str) // Метод, который будет использован для вывода промежуточных станций 
        {                                              //(Промежуточные станции - это массив строк)
            string rez = "";
            if (str.Length == 0)
            {
                return rez;
            }
            if (str.Length == 1)
            {
                rez = str[0];
                return rez;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    rez += str[i] + " ";
                }
            }
            return rez;
        }
    }
}
