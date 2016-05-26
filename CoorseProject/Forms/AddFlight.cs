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
                string Number = Program.RemoveSpaces(textBox1Number.Text);
                string depDay = dateTimePicker1DepartureDay.Value.Day.ToString() + "."
                          + dateTimePicker1DepartureDay.Value.Month.ToString() + "."
                          + dateTimePicker1DepartureDay.Value.Year.ToString();
                string arrDay = dateTimePicker2ArrivalDay.Value.Day.ToString() + "."
                          + dateTimePicker2ArrivalDay.Value.Month.ToString() + "."
                          + dateTimePicker2ArrivalDay.Value.Year.ToString();
                string depTime = numericUpDown4DepHours.Value + ":" + numericUpDown5DepMinutes.Value;
                string arrTime = numericUpDown1ArrHours.Value + ":" + numericUpDown2ArrMinutes.Value;
                string[] StopStations = Program.RemoveSpaces(textBox1StopStations.Text).Split(',');
              
                string DepartureFrom = Program.RemoveSpaces(textBox1DepartureFrom.Text);
                string ArrivalIn = Program.RemoveSpaces(textBox1ArrivalIn.Text);
                int countPlaces = Convert.ToInt32(numericUpDown6countPlaces.Value);

                Flight newFlight;
                FlightCollection file = new FlightCollection();
                Flight Current = file.FindByNumber(Convert.ToInt32(Number));
                if (Convert.ToDateTime(depDay + " " + depTime) <= DateTime.Now)
                {
                    MessageBox.Show("Время и дата отправления должны быть больше текущих.", "Оповещение");
                    return;
                }
                if (Current == null)
                {
                    newFlight = new Flight(Number, DepartureFrom, ArrivalIn, depTime, depDay, arrTime, arrDay, countPlaces, StopStations);
                    file.AddFlightAndWriteInFile(newFlight);
                }
                else
                {
                    MessageBox.Show("Рейс с таким номером уже существует.", "Оповещение");
                    return;
                }
                this.Close();
                Program.MainForm.OnLoadFuction();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введённых данных.", "Оповещение");
            }
            catch(ArithmeticException)
            {
                MessageBox.Show("Номер рейса слишком длинный.", "Оповещение");
            }
            catch (Exception my)
            {
                MessageBox.Show(my.Message, "Оповещение");
            }
        }
    }
}
