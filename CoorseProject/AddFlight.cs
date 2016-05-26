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
    public partial class AddFlight : Form
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void textBox1Minutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Number = Convert.ToInt32(textBox1Number.Text);
                string day = numericUpDown1day.Value + "." + numericUpDown2month.Value + "." + numericUpDown3years.Value;
                string time = numericUpDown4Hours.Value + ":" + numericUpDown5Minutes.Value;
                string[] StopStations = textBox1StopStations.Text.Split(',');
                string DepartureFrom = textBox1DepartureFrom.Text;
                string ArrivalIn = textBox1ArrivalIn.Text;
                int countPlaces = Convert.ToInt32(numericUpDown6countPlaces.Value);
                if (DepartureFrom == "" || ArrivalIn == "")
                {
                    MessageBox.Show("Укажите маршрут!", "Оповещение");
                    return;
                }
                Flight newFlight = new Flight(Number, DepartureFrom, ArrivalIn, time, day, countPlaces, StopStations);
                FlightCollection file = new FlightCollection("Flights.txt");
                bool m = false;
                for (int i = 0; i < file.Count; i++)
                {
                    if (file[i].Number == newFlight.Number)
                    {
                        m = true;
                    }
                }

                if (m)
                {
                    MessageBox.Show("Рейс с таким номером уже существует.","Оповещение");
                    return;
                }
                newFlight.WriteInFile("Flights.txt");
                MessageBox.Show("Рейс успешно добавлен! Обновите расписание.", "Оповещение");
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Проверьте правильность введённых данных.","Оповещение");
            }
        }
    }
}
