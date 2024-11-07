﻿namespace CampusCare.Views
{
    partial class AddPatient
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
            buttonCancel = new Button();
            buttonOk = new Button();
            textBox_firstname = new TextBox();
            textBox_lastname = new TextBox();
            textBox_gender = new TextBox();
            dateTimePicker_birthday = new DateTimePicker();
            textBox_contact = new TextBox();
            comboBox_studentorstaff = new ComboBox();
            textBox_id = new TextBox();
            comboBox_gradeordepartment = new ComboBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(304, 213);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 54);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(171, 213);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(127, 54);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(12, 12);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.PlaceholderText = "First name";
            textBox_firstname.Size = new Size(100, 23);
            textBox_firstname.TabIndex = 5;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(118, 12);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.PlaceholderText = "Last name";
            textBox_lastname.Size = new Size(100, 23);
            textBox_lastname.TabIndex = 6;
            // 
            // textBox_gender
            // 
            textBox_gender.Location = new Point(12, 70);
            textBox_gender.Name = "textBox_gender";
            textBox_gender.PlaceholderText = "Gender";
            textBox_gender.Size = new Size(100, 23);
            textBox_gender.TabIndex = 7;
            // 
            // dateTimePicker_birthday
            // 
            dateTimePicker_birthday.Location = new Point(12, 41);
            dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            dateTimePicker_birthday.Size = new Size(200, 23);
            dateTimePicker_birthday.TabIndex = 8;
            // 
            // textBox_contact
            // 
            textBox_contact.Location = new Point(12, 128);
            textBox_contact.Name = "textBox_contact";
            textBox_contact.PlaceholderText = "Contact no.";
            textBox_contact.Size = new Size(100, 23);
            textBox_contact.TabIndex = 9;
            // 
            // comboBox_studentorstaff
            // 
            comboBox_studentorstaff.FormattingEnabled = true;
            comboBox_studentorstaff.Location = new Point(118, 70);
            comboBox_studentorstaff.Name = "comboBox_studentorstaff";
            comboBox_studentorstaff.Size = new Size(121, 23);
            comboBox_studentorstaff.TabIndex = 10;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(12, 99);
            textBox_id.Name = "textBox_id";
            textBox_id.PlaceholderText = "ID";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 11;
            // 
            // comboBox_gradeordepartment
            // 
            comboBox_gradeordepartment.FormattingEnabled = true;
            comboBox_gradeordepartment.Location = new Point(118, 99);
            comboBox_gradeordepartment.Name = "comboBox_gradeordepartment";
            comboBox_gradeordepartment.Size = new Size(121, 23);
            comboBox_gradeordepartment.TabIndex = 12;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 279);
            Controls.Add(comboBox_gradeordepartment);
            Controls.Add(textBox_id);
            Controls.Add(comboBox_studentorstaff);
            Controls.Add(textBox_contact);
            Controls.Add(dateTimePicker_birthday);
            Controls.Add(textBox_gender);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "AddPatient";
            Text = "AddPatient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private TextBox textBox_firstname;
        private TextBox textBox_lastname;
        private TextBox textBox_gender;
        private DateTimePicker dateTimePicker_birthday;
        private TextBox textBox_contact;
        private ComboBox comboBox_studentorstaff;
        private TextBox textBox_id;
        private ComboBox comboBox_gradeordepartment;
    }
}