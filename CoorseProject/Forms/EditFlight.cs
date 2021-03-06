﻿using System;
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

        private void button1Ok_Click(object sender, EventArgs e)
        {
            try
            {
                FlightCollection File = new FlightCollection("Flights.txt");
                Flight Current = File.FindByNumber(Number);

                string depDay = dateTimePicker1DepartureDay.Value.Day.ToString() + "."
                              + dateTimePicker1DepartureDay.Value.Month.ToString() + "."
                              + dateTimePicker1DepartureDay.Value.Year.ToString();
                string arrDay = dateTimePicker2arrivalDay.Value.Day.ToString() + "."
                              + dateTimePicker2arrivalDay.Value.Month.ToString() + "."
                              + dateTimePicker2arrivalDay.Value.Year.ToString();
                string depTime = numericUpDown1DepHour.Value + ":" + numericUpDown2DepMinutes.Value;
                string arrTime = numericUpDown1ArrHours.Value + ":" + numericUpDown1ArrMinutes.Value;

                string StopStation = Program.RemoveSpaces(textBox3stopstat.Text);

                if (StopStation != "")
                {
                    Current.AddStopStation(StopStation);
                }

                Current.Departure = Convert.ToDateTime(depDay + " " + depTime);
                Current.Arrival = Convert.ToDateTime(arrDay + " " + arrTime);
                File.ClearFile();
                File.WriteInFile();
                this.Close();
                Program.MainForm.OnLoadFuction();
            }
            catch (Exception myexp)
            {
                MessageBox.Show(myexp.Message, "Оповещение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            try
            {
                FlightCollection File = new FlightCollection("Flights.txt");
                Flight Current = File.FindByNumber(Number);
                textBox1dep.Text = Current.DepartureFrom;
                textBox1arr.Text = Current.ArrivalIn;
                textBox1num.Text = Current.Number.ToString();
                numericUpDown1DepHour.Value = Current.Departure.TimeOfDay.Hours;
                numericUpDown2DepMinutes.Value = Current.Departure.TimeOfDay.Minutes;
                numericUpDown1ArrHours.Value = Current.Arrival.TimeOfDay.Hours;
                numericUpDown1ArrMinutes.Value = Current.Arrival.TimeOfDay.Minutes;
                dateTimePicker1DepartureDay.Value = Current.Departure;
                dateTimePicker2arrivalDay.Value = Current.Arrival;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Ошибка: время отправления этого рейса стало меньше текущего.","Оповещение");
                this.Close();
                Program.MainForm.OnLoadFuction();
            }
        }
    }
}
