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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Number = textBox1Number.Text;
                string day = dateTimePicker1.Value.Day.ToString() + "."
                          + dateTimePicker1.Value.Month.ToString() + "."
                          + dateTimePicker1.Value.Year.ToString();
                
                string time = numericUpDown4Hours.Value + ":" + numericUpDown5Minutes.Value;
               
                string[] StopStations = textBox1StopStations.Text.Split(',');
                string DepartureFrom = Program.RemoveSpaces(textBox1DepartureFrom.Text);
                string ArrivalIn = Program.RemoveSpaces(textBox1ArrivalIn.Text);
                int countPlaces = Convert.ToInt32(numericUpDown6countPlaces.Value);

                if (String.IsNullOrWhiteSpace(DepartureFrom) || String.IsNullOrWhiteSpace(ArrivalIn))
                {
                    MessageBox.Show("Укажите маршрут!", "Оповещение");
                    return;
                }
                if (Convert.ToDateTime(time).TimeOfDay < DateTime.Now.TimeOfDay && Convert.ToDateTime(day).Equals(DateTime.Now.Date))
                {
                    MessageBox.Show("Время должно быть больше текущего!", "Оповещение");
                    return;
                }
                Flight newFlight;
                FlightCollection file = new FlightCollection();
                Flight Current = file.FindByNumber(Convert.ToInt32(Number));

                if (Current == null)
                {
                    newFlight = new Flight(Number, DepartureFrom, ArrivalIn, time, day, countPlaces, StopStations);
                    file.AddFlightAndWriteInFile(newFlight);
                }
                else
                {
                    MessageBox.Show("Рейс с таким номером уже существует.", "Оповещение");
                    return;
                }
                this.Close();
                Program.form1.FirstFunc();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность введённых данных.", "Оповещение");
            }
        }

       
    }
}
