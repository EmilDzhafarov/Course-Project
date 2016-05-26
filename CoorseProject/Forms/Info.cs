﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoorseProject
{
        public partial class Info : Form
        {
            private int Number;
            private List<string> rez;

            public Info(string str)
            {
                Number = Convert.ToInt32(str);
                InitializeComponent();
            }

            private void Info_Load(object sender, EventArgs e)
            {

                foreach (DataGridViewColumn colum in ListOfPassengers.Columns)
                {
                    colum.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                FlightCollection file = new FlightCollection();
                Flight Current = file.FindByNumber(Number);
                rez = new List<string>();
                rez.Add("Номер: " + Current.Number);
                rez.Add("Откуда отправляется: " + Current.DepartureFrom);
                rez.Add("Куда направляется: " + Current.ArrivalIn);
                rez.Add("Дата отправления: " + Current.Departure.Date.ToString().Split(' ')[0]);
                rez.Add("Время отправления: " + Current.Departure.TimeOfDay.ToString("hh':'mm"));
                rez.Add("Дата прибытия: " + Current.Arrival.Date.ToString().Split(' ')[0]);
                rez.Add("Время прибытия: " + Current.Arrival.TimeOfDay.ToString("hh':'mm"));
                rez.Add("Количество посадочных мест: " + Current.CountPlaces);
                rez.Add("Свободные места: " + Current.FreePlaces);
                rez.Add("Пункты промежуточной посадки: " + Program.GetStopStations(Current.StopStation));

                listBox1info.DataSource = rez;

                for (int i = 0; i < Current.ListOfPassengers.Count; i++)
                {
                    ListOfPassengers.Rows.Add(Current.ListOfPassengers[i].Name,
                                          Current.ListOfPassengers[i].Surname,
                                          Current.ListOfPassengers[i].MiddleName);
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
 }
