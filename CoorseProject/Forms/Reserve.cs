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
            foreach (DataGridViewColumn colum in FlightTable.Columns)
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

                string num = FlightTable.CurrentRow.Cells[0].Value.ToString();
                decimal count = numericUpDown1Count.Value;

                Passenger user = new Passenger(Name, Surname, Middlename);
                FlightCollection arr = new FlightCollection("Flights.txt");

                Flight Current = arr.FindByNumber(Convert.ToInt32(num));
                Current.AddPassenger(user, count);
               
                MessageBox.Show("Пассажир добавлен!", "Оповещение");
                this.Close();
                Program.MainForm.OnLoadFuction();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбрано ни одного рейса!", "Оповещение");
            }
            catch (Exception my)
            {
                MessageBox.Show(my.Message, "Оповещение");
            }
        }

        private void SearchFlight_Click(object sender, EventArgs e)
        {
            try
            {
                FlightTable.Rows.Clear();
                string dep = Program.RemoveSpaces(textBox4DepartureFrom.Text);
                string arrival = Program.RemoveSpaces(textBox5arrivalIn.Text);

                DateTime now = DateTime.Now;
                FlightCollection list = new FlightCollection("Flights.txt",dep, arrival);

                list.SortingByDays();

                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].Departure > now)
                    {
                        FlightTable.Rows.Add(list[i].Number,
                                                  list[i].FreePlaces,
                                                  list[i].DepartureFrom,
                                                  list[i].ArrivalIn,
                                                  list[i].Departure.TimeOfDay.ToString("hh':'mm"),
                                                  list[i].Departure.Date.ToString().Split(' ')[0],
                                                  list[i].Arrival.TimeOfDay.ToString("hh':'mm"),
                                                  list[i].Arrival.Date.ToString().Split(' ')[0],
                                                  Program.GetStopStations(list[i].StopStation)
                                                  );
                    }
                }
                if (FlightTable.RowCount == 0) // Проверка на существование рейсов в базе данных
                {
                    MessageBox.Show("Не найдено соответствующего рейса", "Оповещение");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3Reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
