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
                string Name = textBox1Name.Text;
                string Surname = textBox2Surname.Text;
                string Middlename = textBox3Middlename.Text;
                if (String.IsNullOrWhiteSpace(Name) == true || String.IsNullOrWhiteSpace(Surname) == true || 
                    String.IsNullOrWhiteSpace(Middlename) == true)
                {
                    MessageBox.Show("Введите регистрационные данные!", "Оповещение");
                    return;
                }
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Не найдено соответствующего рейса!", "Оповещение");
                    return;
                }

                string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
                decimal count = numericUpDown1Count.Value;
                
                Passenger user = new Passenger(Name, Surname, Middlename);
                FlightCollection arr = new FlightCollection();

                Flight Current = arr.FindByNumber(Convert.ToInt32(num));
                if (count <= Current.FreePlaces)
                {
                    while (count != 0)
                    {
                        Current.ListOfPassengers.AddPassenger(user);
                        user.WriteInFile(Current.Number);
                        count--;
                    }
                    MessageBox.Show("Пассажир добавлен!", "Оповещение");
                    this.Close();
                    Program.form1.FirstFunc();
                }
                else
                {
                    MessageBox.Show("Нет такого количества мест!","Оповещение");
                    return;
                }
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();
           string dep = textBox4DepartureFrom.Text;
           string arrival = textBox5arrivalIn.Text;

           if (String.IsNullOrWhiteSpace(dep) || String.IsNullOrWhiteSpace(arrival))
           {
                MessageBox.Show("Укажите маршрут!","Оповещение");
                return;
           }

           DateTime now = DateTime.Now;
        
                FlightCollection list = new FlightCollection(dep,arrival);
                
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
                if (check || dataGridView1.RowCount == 0) // Проверка на существование рейсов в базе данных
                {
                    MessageBox.Show("Не найдено соответствующего рейса","Оповещение");
                    return;
                }
        }

        private void button3Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
