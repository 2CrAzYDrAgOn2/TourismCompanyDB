﻿namespace test_DataBase
{
    partial class AddFormBookings
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfPersons = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxBookingDate = new System.Windows.Forms.TextBox();
            this.textBoxTourIDBookings = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxClientIDBookings = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Бронирование";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(206, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 25);
            this.labelTitle.TabIndex = 37;
            this.labelTitle.Text = "Создание записи:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(281, 662);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(202, 56);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(166, 517);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(81, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Общая сумма:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(129, 478);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 13);
            this.label26.TabIndex = 49;
            this.label26.Text = "Количество человек:";
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(248, 504);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(391, 33);
            this.textBoxTotalAmount.TabIndex = 48;
            // 
            // textBoxNumberOfPersons
            // 
            this.textBoxNumberOfPersons.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfPersons.Location = new System.Drawing.Point(248, 465);
            this.textBoxNumberOfPersons.Name = "textBoxNumberOfPersons";
            this.textBoxNumberOfPersons.Size = new System.Drawing.Size(391, 33);
            this.textBoxNumberOfPersons.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(133, 439);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Дата бронирования:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(175, 399);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Номер тура:";
            // 
            // textBoxBookingDate
            // 
            this.textBoxBookingDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBookingDate.Location = new System.Drawing.Point(248, 426);
            this.textBoxBookingDate.Name = "textBoxBookingDate";
            this.textBoxBookingDate.Size = new System.Drawing.Size(391, 33);
            this.textBoxBookingDate.TabIndex = 44;
            // 
            // textBoxTourIDBookings
            // 
            this.textBoxTourIDBookings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTourIDBookings.Location = new System.Drawing.Point(248, 387);
            this.textBoxTourIDBookings.Name = "textBoxTourIDBookings";
            this.textBoxTourIDBookings.Size = new System.Drawing.Size(391, 33);
            this.textBoxTourIDBookings.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Номер клиента:";
            // 
            // textBoxClientIDBookings
            // 
            this.textBoxClientIDBookings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientIDBookings.Location = new System.Drawing.Point(248, 348);
            this.textBoxClientIDBookings.Name = "textBoxClientIDBookings";
            this.textBoxClientIDBookings.Size = new System.Drawing.Size(391, 33);
            this.textBoxClientIDBookings.TabIndex = 40;
            // 
            // AddFormBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 729);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textBoxNumberOfPersons);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBoxBookingDate);
            this.Controls.Add(this.textBoxTourIDBookings);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxClientIDBookings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Name = "AddFormBookings";
            this.Text = "Добавить бронирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxNumberOfPersons;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxBookingDate;
        private System.Windows.Forms.TextBox textBoxTourIDBookings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxClientIDBookings;
    }
}