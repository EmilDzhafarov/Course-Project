using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoorseProject
{
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn colum in dataGridView1.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button2Ok_Click(object sender, EventArgs e)
        {
            string Name = textBox1Name.Text;
            string Surname = textBox2Surname.Text;
            string Middlename = textBox3Middlename.Text;

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Не найдено соответствующего рейса!");
                return;
            }

            string DepartureFrom = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string ArrivalIn = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Route = DepartureFrom + "-" + ArrivalIn;
            decimal count = numericUpDown1Count.Value;
            decimal copy = count;
            try
            {
                Passenger user = new Passenger(Name, Surname, Middlename, Route);

                StreamReader flights = new StreamReader("Flights.txt");
                bool m = false;
                int n = 0;

                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                   
                    if (arr.Length > 3)
                    {
                        if (num == arr[0] && arr[1] + "-" + arr[2] == user.Route)
                        {
                            m = true;
                            Flight ob = new Flight(Convert.ToInt32(arr[0]), arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]);
                            n = ob.Number;
                            while (count != 0)
                            {
                                ob.ListOfPassengers.AddPassenger(user);
                               
                                count--;
                            }
                            break;
                        }
                        
                    }
                }

                if (m)
                {
                    while (copy != 0)
                    {
                        user.WriteInFile(n);
                        copy--;
                    }
                    MessageBox.Show("Забронировано! Хорошего полёта!");
                    this.Close();
                }

                flights.Close();

            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            
           dataGridView1.Rows.Clear();
           string dep = textBox4DepartureFrom.Text;
           string arrival = textBox5arrivalIn.Text;
           DateTime now = DateTime.Now;
        
            try
            {
                StreamReader flights = new StreamReader("Flights.txt");
                List<Flight> list = new List<Flight>();
                bool check = true;
                while (!flights.EndOfStream)
                {
                    string s = flights.ReadLine();
                    string[] arr = s.Split('|');
                    if (arr.Length != 7)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if ((arr[1] == dep && arr[2] == arrival) ||
                        (arr[6].IndexOf(arrival) != -1 && arr[1] == dep) ||
                        (arr[6].IndexOf(dep) != -1 && arr[2] == arrival))
                        {
                            list.Add(new Flight(Convert.ToInt32(arr[0]), arr[1], arr[2], arr[3], arr[4], Convert.ToInt32(arr[5]), arr[6]));
                            check = false;
                        }
                    }
                }

                SortingByDays(list);

                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].Departure > now)
                    {
                        dataGridView1.Rows.Add(list[i].Number,
                                                 list[i].FreePlaces,
                                                 list[i].DepartureFrom,
                                                 list[i].ArrivalIn,
                                                 list[i].Departure.TimeOfDay.ToString("hh':'mm"),
                                                 list[i].Departure.Date.ToString().Split(' ')[0],
                                                 GetStations(list[i].StopStation)
                                                 );
                    }
                }
                if (dataGridView1.RowCount == 0 && check) // Проверка на существование рейсов в базе данных
                {
                    MessageBox.Show("Не найдено соответствующего рейса");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка базы данных. Попробуйте позже.");
                this.Close();
            }

        }
        private string GetStations(string[] str) // Метод, который будет использован для вывода промежуточных станций 
        {                                              //(Промежуточные станции - это сроковый массив)
            string rez = "";
            if (str.Length == 0)
            {
                return rez;
            }
            if (str.Length == 1)
            {
                rez = str[0];
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == str.Length - 1)
                        rez += str[i];
                    rez += str[i] + ",";
                }
            }
            return rez;
        }
        private void SortingByDays(List<Flight> arr) // Метод сортировки пузырьком рейсов по дням полётов. 
        {                                                  //Дни полётов относятся к классу DayOfWeek, благодаря чему легко сравниваются
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j].Departure > arr[i].Departure)
                    {
                        var t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
        }
    }
}
