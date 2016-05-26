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

        private void бронированиеБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserve ob = new Reserve();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn colum in dataGridView1.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Rows.Clear();
            DateTime now = DateTime.Now;

            try
            {
                FlightCollection list = new FlightCollection("Flights.txt");

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
                                                 list.GetStations(list[i].StopStation)
                                                 );
                    }
                }
                if (check) // Проверка на существование рейсов в базе данных
                {
                    MessageBox.Show("Не найдено соответствующего рейса");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка базы данных. Попробуйте позже.");
                this.Close();
            }

        }
    }
}
