using System;

namespace CoorseProject
{
    partial class EditFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFlight));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1DepartureDay = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1DepHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2DepMinutes = new System.Windows.Forms.NumericUpDown();
            this.textBox3stopstat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1dep = new System.Windows.Forms.TextBox();
            this.textBox1arr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2arrivalDay = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1ArrHours = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1ArrMinutes = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1DepHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2DepMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ArrHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ArrMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата вылета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(24, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время вылета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Промежуточные посадки";
            // 
            // dateTimePicker1DepartureDay
            // 
            this.dateTimePicker1DepartureDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1DepartureDay.Location = new System.Drawing.Point(124, 178);
            this.dateTimePicker1DepartureDay.MinDate = new System.DateTime(2016, 5, 6, 14, 38, 13, 163);
            this.dateTimePicker1DepartureDay.Name = "dateTimePicker1DepartureDay";
            this.dateTimePicker1DepartureDay.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1DepartureDay.TabIndex = 7;
            this.dateTimePicker1DepartureDay.Value = new System.DateTime(2016, 5, 6, 14, 38, 13, 163);
            // 
            // numericUpDown1DepHour
            // 
            this.numericUpDown1DepHour.Location = new System.Drawing.Point(145, 251);
            this.numericUpDown1DepHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1DepHour.Name = "numericUpDown1DepHour";
            this.numericUpDown1DepHour.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1DepHour.TabIndex = 8;
            // 
            // numericUpDown2DepMinutes
            // 
            this.numericUpDown2DepMinutes.Location = new System.Drawing.Point(209, 251);
            this.numericUpDown2DepMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2DepMinutes.Name = "numericUpDown2DepMinutes";
            this.numericUpDown2DepMinutes.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown2DepMinutes.TabIndex = 9;
            // 
            // textBox3stopstat
            // 
            this.textBox3stopstat.Location = new System.Drawing.Point(203, 365);
            this.textBox3stopstat.Name = "textBox3stopstat";
            this.textBox3stopstat.Size = new System.Drawing.Size(143, 20);
            this.textBox3stopstat.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(262, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(180, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(52, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Редактирование рейса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Откуда отправляется";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Куда направляется";
            // 
            // textBox1dep
            // 
            this.textBox1dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1dep.Enabled = false;
            this.textBox1dep.Location = new System.Drawing.Point(180, 113);
            this.textBox1dep.Name = "textBox1dep";
            this.textBox1dep.Size = new System.Drawing.Size(145, 20);
            this.textBox1dep.TabIndex = 17;
            // 
            // textBox1arr
            // 
            this.textBox1arr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1arr.Enabled = false;
            this.textBox1arr.Location = new System.Drawing.Point(180, 144);
            this.textBox1arr.Name = "textBox1arr";
            this.textBox1arr.Size = new System.Drawing.Size(145, 20);
            this.textBox1arr.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(24, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Номер рейса";
            // 
            // textBox1num
            // 
            this.textBox1num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1num.Enabled = false;
            this.textBox1num.Location = new System.Drawing.Point(124, 81);
            this.textBox1num.Name = "textBox1num";
            this.textBox1num.Size = new System.Drawing.Size(145, 20);
            this.textBox1num.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(24, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дата прибытия";
            // 
            // dateTimePicker2arrivalDay
            // 
            this.dateTimePicker2arrivalDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2arrivalDay.Location = new System.Drawing.Point(137, 211);
            this.dateTimePicker2arrivalDay.MinDate = new System.DateTime(2016, 5, 6, 14, 38, 13, 163);
            this.dateTimePicker2arrivalDay.Name = "dateTimePicker2arrivalDay";
            this.dateTimePicker2arrivalDay.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker2arrivalDay.TabIndex = 22;
            this.dateTimePicker2arrivalDay.Value = new System.DateTime(2016, 5, 6, 14, 38, 13, 163);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(24, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Время прибытия";
            // 
            // numericUpDown1ArrHours
            // 
            this.numericUpDown1ArrHours.Location = new System.Drawing.Point(145, 287);
            this.numericUpDown1ArrHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1ArrHours.Name = "numericUpDown1ArrHours";
            this.numericUpDown1ArrHours.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1ArrHours.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(190, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = ":";
            // 
            // numericUpDown1ArrMinutes
            // 
            this.numericUpDown1ArrMinutes.Location = new System.Drawing.Point(209, 287);
            this.numericUpDown1ArrMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown1ArrMinutes.Name = "numericUpDown1ArrMinutes";
            this.numericUpDown1ArrMinutes.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1ArrMinutes.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(24, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Стоимость билета";
            // 
            // numericUpDown1Price
            // 
            this.numericUpDown1Price.Enabled = false;
            this.numericUpDown1Price.Location = new System.Drawing.Point(158, 331);
            this.numericUpDown1Price.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown1Price.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1Price.Name = "numericUpDown1Price";
            this.numericUpDown1Price.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1Price.TabIndex = 28;
            this.numericUpDown1Price.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 456);
            this.Controls.Add(this.numericUpDown1Price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown1ArrMinutes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown1ArrHours);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2arrivalDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1arr);
            this.Controls.Add(this.textBox1dep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3stopstat);
            this.Controls.Add(this.numericUpDown2DepMinutes);
            this.Controls.Add(this.numericUpDown1DepHour);
            this.Controls.Add(this.dateTimePicker1DepartureDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1DepHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2DepMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ArrHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1ArrMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1DepartureDay;
        private System.Windows.Forms.NumericUpDown numericUpDown1DepHour;
        private System.Windows.Forms.NumericUpDown numericUpDown2DepMinutes;
        private System.Windows.Forms.TextBox textBox3stopstat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1dep;
        private System.Windows.Forms.TextBox textBox1arr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2arrivalDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1ArrHours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1ArrMinutes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1Price;
    }
}