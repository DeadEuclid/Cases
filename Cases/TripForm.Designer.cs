
namespace Cases
{
    partial class TripForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ArrivalPoint = new System.Windows.Forms.Label();
            this.DeparturePoint = new System.Windows.Forms.Label();
            this.DepartureTime = new System.Windows.Forms.Label();
            this.TrainNumber = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AllSecondClassSeats = new System.Windows.Forms.Label();
            this.AllFirstClassSeats = new System.Windows.Forms.Label();
            this.FreeSecondClassSeats = new System.Windows.Forms.Label();
            this.FreeFirstClassSeats = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FirstClassExemPrice = new System.Windows.Forms.Label();
            this.SecondClassPrice = new System.Windows.Forms.Label();
            this.FirstClassPrice = new System.Windows.Forms.Label();
            this.SecondClassExemPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ArrivalPoint);
            this.groupBox1.Controls.Add(this.DeparturePoint);
            this.groupBox1.Controls.Add(this.DepartureTime);
            this.groupBox1.Controls.Add(this.TrainNumber);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1162, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о рейсе";
            // 
            // ArrivalPoint
            // 
            this.ArrivalPoint.AutoSize = true;
            this.ArrivalPoint.Location = new System.Drawing.Point(595, 61);
            this.ArrivalPoint.Name = "ArrivalPoint";
            this.ArrivalPoint.Size = new System.Drawing.Size(75, 25);
            this.ArrivalPoint.TabIndex = 9;
            this.ArrivalPoint.Text = "label20";
            this.ArrivalPoint.Click += new System.EventHandler(this.ArrivalPoint_Click);
            // 
            // DeparturePoint
            // 
            this.DeparturePoint.AutoSize = true;
            this.DeparturePoint.Location = new System.Drawing.Point(631, 34);
            this.DeparturePoint.Name = "DeparturePoint";
            this.DeparturePoint.Size = new System.Drawing.Size(75, 25);
            this.DeparturePoint.TabIndex = 8;
            this.DeparturePoint.Text = "label19";
            // 
            // DepartureTime
            // 
            this.DepartureTime.AutoSize = true;
            this.DepartureTime.Location = new System.Drawing.Point(174, 61);
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Size = new System.Drawing.Size(64, 25);
            this.DepartureTime.TabIndex = 7;
            this.DepartureTime.Text = "label5";
            // 
            // TrainNumber
            // 
            this.TrainNumber.AutoSize = true;
            this.TrainNumber.Location = new System.Drawing.Point(92, 34);
            this.TrainNumber.Name = "TrainNumber";
            this.TrainNumber.Size = new System.Drawing.Size(64, 25);
            this.TrainNumber.TabIndex = 6;
            this.TrainNumber.Text = "label3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 25);
            this.label18.TabIndex = 5;
            this.label18.Text = "№ поезда:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место прибытия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место отправления:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1027, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AllSecondClassSeats);
            this.groupBox2.Controls.Add(this.AllFirstClassSeats);
            this.groupBox2.Controls.Add(this.FreeSecondClassSeats);
            this.groupBox2.Controls.Add(this.FreeFirstClassSeats);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(702, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(468, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество свободных мест";
            // 
            // AllSecondClassSeats
            // 
            this.AllSecondClassSeats.AutoSize = true;
            this.AllSecondClassSeats.Location = new System.Drawing.Point(227, 76);
            this.AllSecondClassSeats.Name = "AllSecondClassSeats";
            this.AllSecondClassSeats.Size = new System.Drawing.Size(34, 25);
            this.AllSecondClassSeats.TabIndex = 13;
            this.AllSecondClassSeats.Text = "20";
            // 
            // AllFirstClassSeats
            // 
            this.AllFirstClassSeats.AutoSize = true;
            this.AllFirstClassSeats.Location = new System.Drawing.Point(227, 52);
            this.AllFirstClassSeats.Name = "AllFirstClassSeats";
            this.AllFirstClassSeats.Size = new System.Drawing.Size(34, 25);
            this.AllFirstClassSeats.TabIndex = 12;
            this.AllFirstClassSeats.Text = "20";
            this.AllFirstClassSeats.Click += new System.EventHandler(this.label16_Click);
            // 
            // FreeSecondClassSeats
            // 
            this.FreeSecondClassSeats.AutoSize = true;
            this.FreeSecondClassSeats.Location = new System.Drawing.Point(168, 77);
            this.FreeSecondClassSeats.Name = "FreeSecondClassSeats";
            this.FreeSecondClassSeats.Size = new System.Drawing.Size(34, 25);
            this.FreeSecondClassSeats.TabIndex = 11;
            this.FreeSecondClassSeats.Text = "20";
            // 
            // FreeFirstClassSeats
            // 
            this.FreeFirstClassSeats.AutoSize = true;
            this.FreeFirstClassSeats.Location = new System.Drawing.Point(168, 52);
            this.FreeFirstClassSeats.Name = "FreeFirstClassSeats";
            this.FreeFirstClassSeats.Size = new System.Drawing.Size(34, 25);
            this.FreeFirstClassSeats.TabIndex = 10;
            this.FreeFirstClassSeats.Text = "20";
            this.FreeFirstClassSeats.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "из";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "из";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Первый класс:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Второй класс:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FirstClassExemPrice);
            this.groupBox3.Controls.Add(this.SecondClassPrice);
            this.groupBox3.Controls.Add(this.FirstClassPrice);
            this.groupBox3.Controls.Add(this.SecondClassExemPrice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(22, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(668, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тарифы";
            // 
            // FirstClassExemPrice
            // 
            this.FirstClassExemPrice.AutoSize = true;
            this.FirstClassExemPrice.Location = new System.Drawing.Point(566, 59);
            this.FirstClassExemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstClassExemPrice.Name = "FirstClassExemPrice";
            this.FirstClassExemPrice.Size = new System.Drawing.Size(62, 25);
            this.FirstClassExemPrice.TabIndex = 10;
            this.FirstClassExemPrice.Text = "ххххх";
            // 
            // SecondClassPrice
            // 
            this.SecondClassPrice.AutoSize = true;
            this.SecondClassPrice.Location = new System.Drawing.Point(174, 86);
            this.SecondClassPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondClassPrice.Name = "SecondClassPrice";
            this.SecondClassPrice.Size = new System.Drawing.Size(62, 25);
            this.SecondClassPrice.TabIndex = 9;
            this.SecondClassPrice.Text = "ххххх";
            // 
            // FirstClassPrice
            // 
            this.FirstClassPrice.AutoSize = true;
            this.FirstClassPrice.Location = new System.Drawing.Point(174, 59);
            this.FirstClassPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstClassPrice.Name = "FirstClassPrice";
            this.FirstClassPrice.Size = new System.Drawing.Size(62, 25);
            this.FirstClassPrice.TabIndex = 8;
            this.FirstClassPrice.Text = "ххххх";
            // 
            // SecondClassExemPrice
            // 
            this.SecondClassExemPrice.AutoSize = true;
            this.SecondClassExemPrice.Location = new System.Drawing.Point(566, 84);
            this.SecondClassExemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondClassExemPrice.Name = "SecondClassExemPrice";
            this.SecondClassExemPrice.Size = new System.Drawing.Size(62, 25);
            this.SecondClassExemPrice.TabIndex = 7;
            this.SecondClassExemPrice.Text = "ххххх";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Первый класс ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(579, 161);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "ххххх";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Второй класс ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Первый класс льгота";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Второй класс льгота";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 330);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TripForm";
            this.Text = "Данные о рейсе";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SecondClassPrice;
        private System.Windows.Forms.Label FirstClassPrice;
        private System.Windows.Forms.Label SecondClassExemPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ArrivalPoint;
        private System.Windows.Forms.Label DeparturePoint;
        private System.Windows.Forms.Label DepartureTime;
        private System.Windows.Forms.Label TrainNumber;
        private System.Windows.Forms.Label FirstClassExemPrice;
        private System.Windows.Forms.Label AllSecondClassSeats;
        private System.Windows.Forms.Label AllFirstClassSeats;
        private System.Windows.Forms.Label FreeSecondClassSeats;
        private System.Windows.Forms.Label FreeFirstClassSeats;
    }
}