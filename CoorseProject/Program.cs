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
        ///  
        public static Schedule MainForm; // поле для хранения ссылки на главную форму
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm = new Schedule());
        }

        public static string RemoveSpaces(string str) // Метод, который удаляет лишние пробельные символы
        {
            string[] t = str.Split(' ');

            string res = "";
            for (int i = 0; i < t.Length; i++)   
            {
                if (t[i] != "")
                {
                    res += t[i];
                    if (i != t.Length - 1)
                    {
                        res += " ";
                    }
                }
            }
            return res;
        }
        public static string GetStopStations(string[] str) // Метод, который будет использован для вывода промежуточных станций 
        {                                                  //(Промежуточные станции - это массив строк)
            string rez = "";
            if (str.Length == 0)
            {
                return rez;
            }
            else if (str.Length == 1)
            {
                rez = str[0];
                return rez;
            }
            else
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] != "")
                    {
                        rez += str[i] + ",";
                    }
                }
                rez += str[str.Length - 1];
                return rez;
            }
        }
    }
}
