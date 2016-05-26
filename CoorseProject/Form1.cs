using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            try
            { 

            string Name = textBox1Name.Text;
            string Surname = textBox2Surname.Text;
            string Middlename = textBox3Middlename.Text;
            if (String.IsNullOrWhiteSpace(Name) == true || String.IsNullOrWhiteSpace(Surname) == true || String.IsNullOrWhiteSpace(Middlename) == true)
            {
                    MessageBox.Show("Введите регистрационные данные!","Оповещение");
                    return;
            }
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Не найдено соответствующего рейса!","Оповещение");
                return;
            }
            
            string DepartureFrom = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string ArrivalIn = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Route = DepartureFrom + "-" + ArrivalIn;
            decimal count = numericUpDown1Count.Value;
            decimal copy = count;
            Passenger user = new Passenger(Name, Surname, Middlename);
            FlightCollection arr = new FlightCollection("Flights.txt",DepartureFrom,ArrivalIn);
            bool check = false; // Булевая переменная, которая становится "true" если был найден соответственный рейс, в который добавлено определённое количество пассажиров
            int copyNumber = 0; // Переменная, в которую записывается номер рейса, на который совершается регистрация
                
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].Number == Convert.ToInt32(num) && arr[i].DepartureFrom + "-" + arr[i].ArrivalIn == Route)
                    {
                        copyNumber = arr[i].Number;
                        check = true;
                        while (count != 0)
                        {
                            arr[i].ListOfPassengers.AddPassenger(user);
                            count--;
                        }
                    }
                }
                
                if (check)
                {
                    while (copy != 0)
                    {
                        user.WriteInFile(copyNumber); ;
                        copy--;
                    }
                    MessageBox.Show("Пассажир добавлен!","Оповещение");
                    this.Close();
                }
            }
           
            catch (Exception z)
            {
                MessageBox.Show(z.Message,"Оповещение");
            }
            
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            
           dataGridView1.Rows.Clear();
           string dep = textBox4DepartureFrom.Text;
           string arrival = textBox5arrivalIn.Text;
           if (dep == "" || arrival == "")
           {
                MessageBox.Show("Укажите маршрут!","Оповещение");
                return;
           }
           DateTime now = DateTime.Now;
        
            try
            {
                FlightCollection list = new FlightCollection("Flights.txt",dep,arrival);
                
                bool check = false;
                
                if (list.Count == 0)
                {
                    check = true;
                }

                list.SortingByDays();

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
                                                 Program.GetStations(list[i].StopStation)
                                                 );
                    }
                }
                if (check) // Проверка на существование рейсов в базе данных
                {
                    MessageBox.Show("Не найдено соответствующего рейса","Оповещение");
                    return;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка базы данных. Попробуйте позже.","Оповещение");
                this.Close();
            }

        }

        private void button3Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
