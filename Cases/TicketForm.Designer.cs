
namespace Cases
{
    partial class TicketForm
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
            this.Exem = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wagonNum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.seatNum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.pasportNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pasportSeria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.exemType = new System.Windows.Forms.ComboBox();
            this.getTicketButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trainNum = new System.Windows.Forms.Label();
            this.departureTime = new System.Windows.Forms.Label();
            this.arrivalPoint = new System.Windows.Forms.Label();
            this.deperturePoint = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exem
            // 
            this.Exem.AutoSize = true;
            this.Exem.Location = new System.Drawing.Point(386, 234);
            this.Exem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exem.Name = "Exem";
            this.Exem.Size = new System.Drawing.Size(185, 29);
            this.Exem.TabIndex = 2;
            this.Exem.Text = "Наличее льготы";
            this.Exem.UseVisualStyleBackColor = true;
            this.Exem.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Номер вагона";
            // 
            // wagonNum
            // 
            this.wagonNum.FormattingEnabled = true;
            this.wagonNum.Items.AddRange(new object[] {
            "1 класс",
            "2 класс"});
            this.wagonNum.Location = new System.Drawing.Point(386, 38);
            this.wagonNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wagonNum.Name = "wagonNum";
            this.wagonNum.Size = new System.Drawing.Size(180, 33);
            this.wagonNum.TabIndex = 8;
            this.wagonNum.SelectedIndexChanged += new System.EventHandler(this.wagonNum_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Номер места";
            // 
            // seatNum
            // 
            this.seatNum.Enabled = false;
            this.seatNum.FormattingEnabled = true;
            this.seatNum.Items.AddRange(new object[] {
            "1 класс",
            "2 класс"});
            this.seatNum.Location = new System.Drawing.Point(386, 84);
            this.seatNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seatNum.Name = "seatNum";
            this.seatNum.Size = new System.Drawing.Size(180, 33);
            this.seatNum.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(386, 23);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(180, 30);
            this.Surname.TabIndex = 17;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(386, 62);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(180, 30);
            this.FirstName.TabIndex = 18;
            this.FirstName.Text = "\r\n";
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(386, 103);
            this.Middlename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(180, 30);
            this.Middlename.TabIndex = 19;
            // 
            // pasportNum
            // 
            this.pasportNum.Location = new System.Drawing.Point(386, 191);
            this.pasportNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pasportNum.Name = "pasportNum";
            this.pasportNum.Size = new System.Drawing.Size(180, 30);
            this.pasportNum.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 373);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 377);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 198);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "Номер паспорта";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 155);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Серия паспорта";
            // 
            // pasportSeria
            // 
            this.pasportSeria.Location = new System.Drawing.Point(386, 147);
            this.pasportSeria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pasportSeria.Name = "pasportSeria";
            this.pasportSeria.Size = new System.Drawing.Size(180, 30);
            this.pasportSeria.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Тип льготы";
            // 
            // exemType
            // 
            this.exemType.Enabled = false;
            this.exemType.FormattingEnabled = true;
            this.exemType.Items.AddRange(new object[] {
            "1 класс",
            "2 класс"});
            this.exemType.Location = new System.Drawing.Point(386, 277);
            this.exemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exemType.Name = "exemType";
            this.exemType.Size = new System.Drawing.Size(180, 33);
            this.exemType.TabIndex = 26;
            // 
            // getTicketButton
            // 
            this.getTicketButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.getTicketButton.Location = new System.Drawing.Point(875, 610);
            this.getTicketButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getTicketButton.Name = "getTicketButton";
            this.getTicketButton.Size = new System.Drawing.Size(300, 45);
            this.getTicketButton.TabIndex = 28;
            this.getTicketButton.Text = "Оформить и распечатать";
            this.getTicketButton.UseVisualStyleBackColor = true;
            this.getTicketButton.Click += new System.EventHandler(this.getTicketButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1016, 554);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 25);
            this.label17.TabIndex = 29;
            this.label17.Text = "Цена:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(1088, 555);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(54, 25);
            this.Price.TabIndex = 30;
            this.Price.Text = "ХХХ";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(13, 612);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 45);
            this.button2.TabIndex = 31;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.wagonNum);
            this.groupBox2.Controls.Add(this.seatNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(18, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(591, 128);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о месте";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Exem);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Surname);
            this.groupBox3.Controls.Add(this.FirstName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Middlename);
            this.groupBox3.Controls.Add(this.exemType);
            this.groupBox3.Controls.Add(this.pasportNum);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.pasportSeria);
            this.groupBox3.Location = new System.Drawing.Point(13, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(596, 328);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные о пасажире";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(1150, 555);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 25);
            this.label21.TabIndex = 34;
            this.label21.Text = "₽";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trainNum);
            this.groupBox1.Controls.Add(this.departureTime);
            this.groupBox1.Controls.Add(this.arrivalPoint);
            this.groupBox1.Controls.Add(this.deperturePoint);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1162, 108);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о рейсе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Место прибытия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Место отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время отправления:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "№ поезда:";
            // 
            // trainNum
            // 
            this.trainNum.AutoSize = true;
            this.trainNum.Location = new System.Drawing.Point(127, 36);
            this.trainNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trainNum.Name = "trainNum";
            this.trainNum.Size = new System.Drawing.Size(108, 25);
            this.trainNum.TabIndex = 5;
            this.trainNum.Text = "№ поезда:";
            // 
            // departureTime
            // 
            this.departureTime.AutoSize = true;
            this.departureTime.Location = new System.Drawing.Point(225, 61);
            this.departureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(206, 25);
            this.departureTime.TabIndex = 3;
            this.departureTime.Text = "Время отправления:";
            // 
            // arrivalPoint
            // 
            this.arrivalPoint.AutoSize = true;
            this.arrivalPoint.Location = new System.Drawing.Point(649, 61);
            this.arrivalPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrivalPoint.Name = "arrivalPoint";
            this.arrivalPoint.Size = new System.Drawing.Size(175, 25);
            this.arrivalPoint.TabIndex = 1;
            this.arrivalPoint.Text = "Место прибытия:";
            // 
            // deperturePoint
            // 
            this.deperturePoint.AutoSize = true;
            this.deperturePoint.Location = new System.Drawing.Point(673, 36);
            this.deperturePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deperturePoint.Name = "deperturePoint";
            this.deperturePoint.Size = new System.Drawing.Size(204, 25);
            this.deperturePoint.TabIndex = 0;
            this.deperturePoint.Text = "Место отправления:";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.getTicketButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketForm";
            this.Text = "Оформление билета";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Exem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox wagonNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox seatNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.TextBox pasportNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox pasportSeria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox exemType;
        private System.Windows.Forms.Button getTicketButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label trainNum;
        private System.Windows.Forms.Label departureTime;
        private System.Windows.Forms.Label arrivalPoint;
        private System.Windows.Forms.Label deperturePoint;
    }
}