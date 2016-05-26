namespace CoorseProject
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расписаниеРейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бронированиеБилетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3DeleteFlight = new System.Windows.Forms.Button();
            this.button4AddFlight = new System.Windows.Forms.Button();
            this.button2EditFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5InfomOfFlight = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеРейсовToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расписаниеРейсовToolStripMenuItem
            // 
            this.расписаниеРейсовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бронированиеБилетовToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.расписаниеРейсовToolStripMenuItem.Name = "расписаниеРейсовToolStripMenuItem";
            this.расписаниеРейсовToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.расписаниеРейсовToolStripMenuItem.Text = "Главная";
            // 
            // бронированиеБилетовToolStripMenuItem
            // 
            this.бронированиеБилетовToolStripMenuItem.Name = "бронированиеБилетовToolStripMenuItem";
            this.бронированиеБилетовToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.бронированиеБилетовToolStripMenuItem.Text = "Бронирование билетов";
            this.бронированиеБилетовToolStripMenuItem.Click += new System.EventHandler(this.бронированиеБилетовToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 96);
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
            this.dataGridView1.Size = new System.Drawing.Size(640, 203);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(568, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3DeleteFlight
            // 
            this.button3DeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3DeleteFlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3DeleteFlight.Location = new System.Drawing.Point(213, 334);
            this.button3DeleteFlight.Name = "button3DeleteFlight";
            this.button3DeleteFlight.Size = new System.Drawing.Size(74, 29);
            this.button3DeleteFlight.TabIndex = 20;
            this.button3DeleteFlight.Text = "Удалить";
            this.button3DeleteFlight.UseVisualStyleBackColor = true;
            this.button3DeleteFlight.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4AddFlight
            // 
            this.button4AddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4AddFlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4AddFlight.Location = new System.Drawing.Point(8, 334);
            this.button4AddFlight.Name = "button4AddFlight";
            this.button4AddFlight.Size = new System.Drawing.Size(82, 29);
            this.button4AddFlight.TabIndex = 21;
            this.button4AddFlight.Text = "Добавить";
            this.button4AddFlight.UseVisualStyleBackColor = true;
            this.button4AddFlight.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2EditFlight
            // 
            this.button2EditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2EditFlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2EditFlight.Location = new System.Drawing.Point(100, 334);
            this.button2EditFlight.Name = "button2EditFlight";
            this.button2EditFlight.Size = new System.Drawing.Size(107, 29);
            this.button2EditFlight.TabIndex = 22;
            this.button2EditFlight.Text = "Редактировать";
            this.button2EditFlight.UseVisualStyleBackColor = true;
            this.button2EditFlight.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(219, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Расписание полётов";
            // 
            // button5InfomOfFlight
            // 
            this.button5InfomOfFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5InfomOfFlight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5InfomOfFlight.Location = new System.Drawing.Point(293, 334);
            this.button5InfomOfFlight.Name = "button5InfomOfFlight";
            this.button5InfomOfFlight.Size = new System.Drawing.Size(88, 29);
            this.button5InfomOfFlight.TabIndex = 24;
            this.button5InfomOfFlight.Text = "Ведомость";
            this.button5InfomOfFlight.UseVisualStyleBackColor = true;
            this.button5InfomOfFlight.Click += new System.EventHandler(this.button5_Click);
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
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(660, 376);
            this.Controls.Add(this.button5InfomOfFlight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2EditFlight);
            this.Controls.Add(this.button4AddFlight);
            this.Controls.Add(this.button3DeleteFlight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расписаниеРейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бронированиеБилетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3DeleteFlight;
        private System.Windows.Forms.Button button4AddFlight;
        private System.Windows.Forms.Button button2EditFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5InfomOfFlight;
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