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
            FirstFunc();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тема курсового проекта: Касса аэрофлота\nРазработчик: ст.группы ПИ-15-2 Джафаров Эмиль\nСсылка на GitHub: https://github.com/EmilDzhafarov/Coorse-Project.git \nЭлектронная почта: emil.dzhafarov@nure.ua\nВерсия программы: 1.0", "О программе");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstFunc();
        }
        public void FirstFunc()
        {
            foreach (DataGridViewColumn colum in dataGridView1.Columns)
            {
                colum.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Rows.Clear();
            DateTime now = DateTime.Now;
            if (System.IO.File.Exists("Flights.txt") == false)
            {
                System.IO.FileStream file = new System.IO.FileStream("Flights.txt",System.IO.FileMode.Create);
                file.Close();
            }
            try {
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
           
            catch(FormatException)
            {
                
            }
            catch(IndexOutOfRangeException)
            {
                
            }
            catch (ArgumentNullException)
            {

            }

        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьРейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlight ob = new AddFlight();
            ob.Show();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationOfFlight ob = new InformationOfFlight();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddFlight ob = new AddFlight();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                FlightCollection file = new FlightCollection("Flights.txt");
                for (int i = 0; i < file.Count; i++)
                {
                    if (file[i].Number == Convert.ToInt32(num))
                    {
                        file.RemoveAt(i);
                        i--;
                        if (System.IO.File.Exists(num + "Passangers.txt") == true)
                        {
                            System.IO.File.Delete(num + "Passangers.txt");
                        }
                    }
                }
                file.ClearFile();
                file.WriteInFile();
                FirstFunc();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбран ни один рейс!","Оповещение");
            }
        }
    }
}
