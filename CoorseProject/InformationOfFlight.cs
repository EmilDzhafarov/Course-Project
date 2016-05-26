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
    public partial class InformationOfFlight : Form
    {
        public InformationOfFlight()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void InformationOfFlight_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn colum in dataGridView1.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Rows.Clear();
            DateTime now = DateTime.Now;
            if (System.IO.File.Exists("Flights.txt") == false)
            {
                System.IO.FileStream file = new System.IO.FileStream("Flights.txt", System.IO.FileMode.Create);
                file.Close();
            }
            try
            {
                FlightCollection list = new FlightCollection("Flights.txt");
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
            }

            catch (FormatException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }
            catch (ArgumentNullException)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                List<string> result = new List<string>();

                FlightCollection file = new FlightCollection("Flights.txt");
                for (int i = 0; i < file.Count; i++)
                {
                    if (file[i].Number == Convert.ToInt32(num))
                    {
                        result.Add("Номер рейса: " + file[i].Number + "");
                        result.Add("Откуда отправляется: " + file[i].DepartureFrom);
                        result.Add("Куда направляется: " + file[i].ArrivalIn);
                        result.Add("Время отправления: " + file[i].Departure.TimeOfDay.ToString("hh':'mm"));
                        result.Add("Дата отправления: " + file[i].Departure.Date.ToString().Split(' ')[0]);
                        result.Add("Всего мест: " + file[i].CountPlaces);
                        result.Add("Свободные места: " + file[i].FreePlaces);
                        result.Add("Пункты промежуточных посадок: " + Program.GetStations(file[i].StopStation));
                        result.Add("");
                        result.Add("Список пассажиров: ");
                        result.Add("");
                        int k = 0;
                        while (k < file[i].ListOfPassengers.Count)
                        {
                            result.Add("Имя: " + file[i].ListOfPassengers[k].Name);
                            result.Add("Фамилия: " + file[i].ListOfPassengers[k].Surname);
                            result.Add("Отчество: " + file[i].ListOfPassengers[k].MiddleName);
                            result.Add("----------------------------------------------");
                            k++;
                        }
                    }
                }
                listBox1.DataSource = result;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбрано ни одного рейса!","Оповещение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
