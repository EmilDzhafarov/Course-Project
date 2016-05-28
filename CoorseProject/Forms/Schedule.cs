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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        private void Schedule_Load(object sender, EventArgs e)
        {
            OnLoadFuction();
        }

        public void OnLoadFuction()
        {
            foreach (DataGridViewColumn colum in FlightTable1.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            try
            {
                FlightTable1.Rows.Clear();

                FlightCollection list = new FlightCollection("Flights.txt");
                list.SortingByDays();

                for (int i = list.Count - 1; i >= 0; i--)
                {

                    FlightTable1.Rows.Add(list[i].Number,
                                           list[i].FreePlaces,
                                           list[i].DepartureFrom,
                                           list[i].ArrivalIn,
                                           list[i].Departure.TimeOfDay.ToString("hh':'mm"),
                                           list[i].Departure.Date.ToString().Split(' ')[0],
                                           list[i].Arrival.TimeOfDay.ToString("hh':'mm"),
                                           list[i].Arrival.Date.ToString().Split(' ')[0],
                                           Program.GetStopStations(list[i].StopStation));
                }
                if (FlightTable1.Rows.Count == 0)
                {
                    button3DeleteFlight.Visible = false;
                    button5InfomOfFlight.Visible = false;
                    button2EditFlight.Visible = false;
                }
                else
                {
                    button3DeleteFlight.Visible = true;
                    button5InfomOfFlight.Visible = true;
                    button2EditFlight.Visible = true;
                }
            }
            catch
            {
                this.Show();
                MessageBox.Show("Ошибка в базе данных!", "Оповещение");
                this.Close();
            }
        }
        private void бронированиеБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserve ob = new Reserve();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Тема курсового проекта: Касса аэрофлота
Разработчик: ст.группы ПИ-15-2 Джафаров Эмиль
Электронная почта: emil.dzhafarov@nure.ua
Версия программы: 1.0", "О программе");
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = FlightTable1.CurrentRow.Cells[0].Value.ToString();
            FlightCollection file = new FlightCollection("Flights.txt");
            file.RemoveFlightAndFile(num);
            file.ClearFile();
            file.WriteInFile();
            OnLoadFuction();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = FlightTable1.CurrentRow.Cells[0].Value.ToString();
            EditFlight ob = new EditFlight(num);
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = FlightTable1.CurrentRow.Cells[0].Value.ToString();
            Info ob = new Info(num);
            ob.Show();
        }

        private void добавитьРейсToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddFlight ob = new AddFlight();
            ob.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void удалитьСтарыеРейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightCollection file = new FlightCollection("Flights.txt");
            file.ClearFile();
            file.WriteInFile();
            MessageBox.Show("Старые рейсы были успешно удалены из базы данных!", "Оповещение");
        }
    }
}
