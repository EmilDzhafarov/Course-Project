namespace CoorseProject
{
    partial class Reserve
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserve));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2Surname = new System.Windows.Forms.TextBox();
            this.textBox3Middlename = new System.Windows.Forms.TextBox();
            this.textBox4DepartureFrom = new System.Windows.Forms.TextBox();
            this.textBox5arrivalIn = new System.Windows.Forms.TextBox();
            this.SearchFlight = new System.Windows.Forms.Button();
            this.button2Ok = new System.Windows.Forms.Button();
            this.button3Reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1Count = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreePlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopStations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(332, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Откуда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(332, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Куда";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1Name.Location = new System.Drawing.Point(89, 67);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(173, 22);
            this.textBox1Name.TabIndex = 6;
            // 
            // textBox2Surname
            // 
            this.textBox2Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2Surname.Location = new System.Drawing.Point(89, 105);
            this.textBox2Surname.Name = "textBox2Surname";
            this.textBox2Surname.Size = new System.Drawing.Size(173, 22);
            this.textBox2Surname.TabIndex = 7;
            // 
            // textBox3Middlename
            // 
            this.textBox3Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3Middlename.Location = new System.Drawing.Point(89, 139);
            this.textBox3Middlename.Name = "textBox3Middlename";
            this.textBox3Middlename.Size = new System.Drawing.Size(173, 22);
            this.textBox3Middlename.TabIndex = 8;
            // 
            // textBox4DepartureFrom
            // 
            this.textBox4DepartureFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4DepartureFrom.Location = new System.Drawing.Point(403, 64);
            this.textBox4DepartureFrom.Name = "textBox4DepartureFrom";
            this.textBox4DepartureFrom.Size = new System.Drawing.Size(175, 22);
            this.textBox4DepartureFrom.TabIndex = 9;
            // 
            // textBox5arrivalIn
            // 
            this.textBox5arrivalIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5arrivalIn.Location = new System.Drawing.Point(403, 99);
            this.textBox5arrivalIn.Name = "textBox5arrivalIn";
            this.textBox5arrivalIn.Size = new System.Drawing.Size(175, 22);
            this.textBox5arrivalIn.TabIndex = 10;
            // 
            // SearchFlight
            // 
            this.SearchFlight.BackColor = System.Drawing.SystemColors.Control;
            this.SearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFlight.Location = new System.Drawing.Point(335, 134);
            this.SearchFlight.Name = "SearchFlight";
            this.SearchFlight.Size = new System.Drawing.Size(76, 27);
            this.SearchFlight.TabIndex = 12;
            this.SearchFlight.Text = "Найти!";
            this.SearchFlight.UseVisualStyleBackColor = false;
            this.SearchFlight.Click += new System.EventHandler(this.SearchFlight_Click);
            // 
            // button2Ok
            // 
            this.button2Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2Ok.Location = new System.Drawing.Point(584, 348);
            this.button2Ok.Name = "button2Ok";
            this.button2Ok.Size = new System.Drawing.Size(71, 29);
            this.button2Ok.TabIndex = 13;
            this.button2Ok.Text = "Готово!";
            this.button2Ok.UseVisualStyleBackColor = true;
            this.button2Ok.Click += new System.EventHandler(this.button2Ok_Click);
            // 
            // button3Reset
            // 
            this.button3Reset.BackColor = System.Drawing.SystemColors.Control;
            this.button3Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3Reset.Location = new System.Drawing.Point(505, 348);
            this.button3Reset.Name = "button3Reset";
            this.button3Reset.Size = new System.Drawing.Size(73, 29);
            this.button3Reset.TabIndex = 14;
            this.button3Reset.Text = "Отмена";
            this.button3Reset.UseVisualStyleBackColor = false;
            this.button3Reset.Click += new System.EventHandler(this.button3Reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество билетов";
            // 
            // numericUpDown1Count
            // 
            this.numericUpDown1Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1Count.Location = new System.Drawing.Point(159, 353);
            this.numericUpDown1Count.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown1Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1Count.Name = "numericUpDown1Count";
            this.numericUpDown1Count.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown1Count.TabIndex = 16;
            this.numericUpDown1Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(192, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Бронирование билетов";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.FreePlaces,
            this.DepartureFrom,
            this.ArrivalIn,
            this.Departure,
            this.FlightDay,
            this.ArrivalTime,
            this.ArrivalDay,
            this.Price,
            this.StopStations});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 191);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 133);
            this.dataGridView1.TabIndex = 18;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // FreePlaces
            // 
            this.FreePlaces.HeaderText = "Свободные места";
            this.FreePlaces.Name = "FreePlaces";
            this.FreePlaces.ReadOnly = true;
            // 
            // DepartureFrom
            // 
            this.DepartureFrom.HeaderText = "Откуда";
            this.DepartureFrom.Name = "DepartureFrom";
            this.DepartureFrom.ReadOnly = true;
            // 
            // ArrivalIn
            // 
            this.ArrivalIn.HeaderText = "Куда";
            this.ArrivalIn.Name = "ArrivalIn";
            this.ArrivalIn.ReadOnly = true;
            this.ArrivalIn.Width = 101;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Время отправления";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // FlightDay
            // 
            this.FlightDay.HeaderText = "День вылета";
            this.FlightDay.Name = "FlightDay";
            this.FlightDay.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Время прибытия";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // ArrivalDay
            // 
            this.ArrivalDay.HeaderText = "День прибытия";
            this.ArrivalDay.Name = "ArrivalDay";
            this.ArrivalDay.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость билета";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // StopStations
            // 
            this.StopStations.HeaderText = "Промежуточные посадки";
            this.StopStations.Name = "StopStations";
            this.StopStations.ReadOnly = true;
            this.StopStations.Width = 110;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(672, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3Reset);
            this.Controls.Add(this.button2Ok);
            this.Controls.Add(this.SearchFlight);
            this.Controls.Add(this.textBox5arrivalIn);
            this.Controls.Add(this.textBox4DepartureFrom);
            this.Controls.Add(this.textBox3Middlename);
            this.Controls.Add(this.textBox2Surname);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.TextBox textBox2Surname;
        private System.Windows.Forms.TextBox textBox3Middlename;
        private System.Windows.Forms.TextBox textBox4DepartureFrom;
        private System.Windows.Forms.TextBox textBox5arrivalIn;
        private System.Windows.Forms.Button SearchFlight;
        private System.Windows.Forms.Button button2Ok;
        private System.Windows.Forms.Button button3Reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1Count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreePlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopStations;
    }
}

