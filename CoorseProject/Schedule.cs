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
                if (System.IO.Directory.Exists("Passengers"))
                {
                    System.IO.Directory.Delete("Passengers",true);
                }
                System.IO.FileStream file = new System.IO.FileStream("Flights.txt",System.IO.FileMode.Create);
                file.Close();
            }
            try
            {
                FlightCollection list = new FlightCollection();
                list.SortingByDays();

                for (int i = list.Count-1; i >= 0; i--)
                {
                    if (list[i].Departure >= now)
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
            catch
            {
                MessageBox.Show("Ошибка в базе данных!","Оповещение");
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
Ссылка на GitHub: https://github.com/EmilDzhafarov/Coorse-Project.git
Электронная почта: emil.dzhafarov@nure.ua
Версия программы: 1.0", "О программе");
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
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

                FlightCollection file = new FlightCollection();
                Flight Current = file.FindByNumber(Convert.ToInt32(num));
                
                file.Remove(Current);
                        
                if (System.IO.File.Exists("Passengers\\" + num + "Passengers.txt") == true)
                {
                     System.IO.File.Delete("Passengers\\" + num + "Passengers.txt");
                }
                 
                file.ClearFile();
                file.WriteInFile();
                FirstFunc();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбрано ни одного рейса!","Оповещение");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                EditFlight ob = new EditFlight(num);
                ob.Show();
            }
           catch(NullReferenceException)
            {
                MessageBox.Show("Не выбрано ни одного рейса!", "Оповещение");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string num = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Info ob = new Info(num);
                ob.Show();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Не выбрано ни одного рейса!","Оповещение");
            }
        }
    }
}
