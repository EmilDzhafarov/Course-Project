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
    public partial class EditFlight : Form
    {
        private int Number;
        public EditFlight(string ob)
        {
            Number = Convert.ToInt32(ob);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightCollection File = new FlightCollection();
            Flight Current = File.FindByNumber(Number);

            string day = dateTimePicker1.Value.Day.ToString() + "."
                          + dateTimePicker1.Value.Month.ToString() + "."
                          + dateTimePicker1.Value.Year.ToString();

            string time = numericUpDown1Hour.Value + ":" + numericUpDown2Minutes.Value;
            if (Convert.ToDateTime(time).TimeOfDay < DateTime.Now.TimeOfDay && Convert.ToDateTime(day).Equals(DateTime.Now.Date))
            {
                MessageBox.Show("Время должно быть больше текущего!", "Оповещение");
                return;
            }
            string[] StopStations = textBox3stopstat.Text.Split(',');
            List<string> arr = Current.StopStation.ToList<string>();
            for (int i = 0; i < StopStations.Length; i++)
            {
                arr.Add(StopStations[i]);
            }
            Current.StopStation = arr.ToArray();
            Current.Departure = Convert.ToDateTime(day + " " + time);

            File.ClearFile();
            File.WriteInFile();
            this.Close();
            Program.form1.FirstFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            FlightCollection File = new FlightCollection();
            Flight Current = File.FindByNumber(Number);
            textBox1dep.Text = Current.DepartureFrom;
            textBox1arr.Text = Current.ArrivalIn;
            textBox1num.Text = Current.Number.ToString();
            numericUpDown1Hour.Value = Current.Departure.TimeOfDay.Hours;
            numericUpDown2Minutes.Value = Current.Departure.TimeOfDay.Minutes;

        }
    }
}
