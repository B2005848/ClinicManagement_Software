namespace project_gr.Control.AdminPage.Form_For_Schedule
{
    partial class Form_New_Patient
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
            label1 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            textName = new TextBox();
            label16 = new Label();
            textDatePatient = new DateTimePicker();
            Text_citizen = new TextBox();
            label2 = new Label();
            label13 = new Label();
            label3 = new Label();
            label12 = new Label();
            label4 = new Label();
            label11 = new Label();
            radiobtnMale = new RadioButton();
            label10 = new Label();
            radiobtnFemale = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            textAddress = new TextBox();
            textNumberPhone = new TextBox();
            label7 = new Label();
            label14 = new Label();
            label9 = new Label();
            dateTimeAppointment = new DateTimePicker();
            panel2 = new Panel();
            combo_doctor = new ComboBox();
            Text_slottime = new Label();
            label21 = new Label();
            label22 = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            label19 = new Label();
            panelGroupPatients = new Panel();
            label20 = new Label();
            label17 = new Label();
            label18 = new Label();
            label8 = new Label();
            label23 = new Label();
            textNote = new TextBox();
            label24 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 13);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textName);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textDatePatient);
            panel1.Controls.Add(Text_citizen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(radiobtnMale);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(radiobtnFemale);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textAddress);
            panel1.Controls.Add(textNumberPhone);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 241);
            panel1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(41, 140);
            label15.Name = "label15";
            label15.Size = new Size(13, 17);
            label15.TabIndex = 46;
            label15.Text = "*";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(114, 29);
            textName.Margin = new Padding(3, 10, 3, 30);
            textName.Name = "textName";
            textName.PlaceholderText = "   Nhập họ và tên bệnh nhân";
            textName.Size = new Size(416, 27);
            textName.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(52, 137);
            label16.Margin = new Padding(1, 0, 3, 0);
            label16.Name = "label16";
            label16.Size = new Size(56, 21);
            label16.TabIndex = 45;
            label16.Text = "CCCD:";
            // 
            // textDatePatient
            // 
            textDatePatient.CustomFormat = "dd/MM/yyyy";
            textDatePatient.Format = DateTimePickerFormat.Custom;
            textDatePatient.Location = new Point(118, 82);
            textDatePatient.Margin = new Padding(3, 10, 3, 30);
            textDatePatient.Name = "textDatePatient";
            textDatePatient.Size = new Size(412, 25);
            textDatePatient.TabIndex = 29;
            // 
            // Text_citizen
            // 
            Text_citizen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_citizen.Location = new Point(114, 131);
            Text_citizen.Margin = new Padding(3, 10, 3, 30);
            Text_citizen.Name = "Text_citizen";
            Text_citizen.PlaceholderText = "   Nhập mã căn cước công dân của bệnh nhân";
            Text_citizen.Size = new Size(416, 27);
            Text_citizen.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 35);
            label2.Margin = new Padding(1, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 30;
            label2.Text = "Họ và Tên:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(567, 38);
            label13.Name = "label13";
            label13.Size = new Size(13, 17);
            label13.TabIndex = 43;
            label13.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 86);
            label3.Margin = new Padding(1, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 31;
            label3.Text = "Ngày sinh:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(240, 192);
            label12.Name = "label12";
            label12.Size = new Size(13, 17);
            label12.TabIndex = 42;
            label12.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 188);
            label4.Margin = new Padding(1, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 32;
            label4.Text = "Giới tính:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(13, 191);
            label11.Name = "label11";
            label11.Size = new Size(13, 17);
            label11.TabIndex = 41;
            label11.Text = "*";
            // 
            // radiobtnMale
            // 
            radiobtnMale.AutoSize = true;
            radiobtnMale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnMale.Location = new Point(116, 188);
            radiobtnMale.Margin = new Padding(3, 10, 3, 30);
            radiobtnMale.Name = "radiobtnMale";
            radiobtnMale.Size = new Size(59, 24);
            radiobtnMale.TabIndex = 33;
            radiobtnMale.TabStop = true;
            radiobtnMale.Text = "Nam";
            radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(8, 90);
            label10.Name = "label10";
            label10.Size = new Size(13, 17);
            label10.TabIndex = 40;
            label10.Text = "*";
            // 
            // radiobtnFemale
            // 
            radiobtnFemale.AutoSize = true;
            radiobtnFemale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnFemale.Location = new Point(176, 188);
            radiobtnFemale.Margin = new Padding(3, 10, 3, 30);
            radiobtnFemale.Name = "radiobtnFemale";
            radiobtnFemale.Size = new Size(47, 24);
            radiobtnFemale.TabIndex = 34;
            radiobtnFemale.TabStop = true;
            radiobtnFemale.Text = "Nữ";
            radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(4, 39);
            label6.Name = "label6";
            label6.Size = new Size(13, 17);
            label6.TabIndex = 39;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(259, 189);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 35;
            label5.Text = "Điện thoại:";
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddress.Location = new Point(659, 29);
            textAddress.Margin = new Padding(3, 10, 3, 30);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "   Nhập địa chỉ liên hệ cụ thể";
            textAddress.Size = new Size(224, 183);
            textAddress.TabIndex = 38;
            // 
            // textNumberPhone
            // 
            textNumberPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumberPhone.Location = new Point(359, 184);
            textNumberPhone.Margin = new Padding(3, 10, 3, 30);
            textNumberPhone.Name = "textNumberPhone";
            textNumberPhone.PlaceholderText = "   Nhập số điện thoại";
            textNumberPhone.Size = new Size(171, 27);
            textNumberPhone.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(586, 35);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 37;
            label7.Text = "Địa chỉ:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(58, 76);
            label14.Name = "label14";
            label14.Size = new Size(13, 17);
            label14.TabIndex = 43;
            label14.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(71, 72);
            label9.Margin = new Padding(1, 0, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 42;
            label9.Text = "Thời gian:";
            // 
            // dateTimeAppointment
            // 
            dateTimeAppointment.CustomFormat = "dd/MM/yyyy";
            dateTimeAppointment.Format = DateTimePickerFormat.Custom;
            dateTimeAppointment.Location = new Point(168, 68);
            dateTimeAppointment.Margin = new Padding(3, 10, 3, 30);
            dateTimeAppointment.Name = "dateTimeAppointment";
            dateTimeAppointment.Size = new Size(362, 25);
            dateTimeAppointment.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label23);
            panel2.Controls.Add(textNote);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(combo_doctor);
            panel2.Controls.Add(Text_slottime);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(panelGroupPatients);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(dateTimeAppointment);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(12, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 465);
            panel2.TabIndex = 3;
            // 
            // combo_doctor
            // 
            combo_doctor.FormattingEnabled = true;
            combo_doctor.Location = new Point(168, 278);
            combo_doctor.Name = "combo_doctor";
            combo_doctor.Size = new Size(366, 25);
            combo_doctor.TabIndex = 56;
            combo_doctor.Text = "    Chọn bác sĩ";
            // 
            // Text_slottime
            // 
            Text_slottime.AutoSize = true;
            Text_slottime.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_slottime.Location = new Point(659, 71);
            Text_slottime.Name = "Text_slottime";
            Text_slottime.Size = new Size(131, 20);
            Text_slottime.TabIndex = 55;
            Text_slottime.Text = "SÁNG: 7:00 - 12:00";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(604, 71);
            label21.Margin = new Padding(1, 0, 3, 0);
            label21.Name = "label21";
            label21.Size = new Size(49, 21);
            label21.TabIndex = 53;
            label21.Text = "Buổi:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Red;
            label22.Location = new Point(587, 75);
            label22.Name = "label22";
            label22.Size = new Size(13, 17);
            label22.TabIndex = 54;
            label22.Text = "*";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Location = new Point(751, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 40);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "HỦY";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(558, 395);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 40);
            btnSubmit.TabIndex = 50;
            btnSubmit.Text = "LƯU";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(20, 124);
            label19.Name = "label19";
            label19.Size = new Size(13, 17);
            label19.TabIndex = 49;
            label19.Text = "*";
            // 
            // panelGroupPatients
            // 
            panelGroupPatients.AutoScroll = true;
            panelGroupPatients.BorderStyle = BorderStyle.Fixed3D;
            panelGroupPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelGroupPatients.Location = new Point(175, 123);
            panelGroupPatients.Margin = new Padding(3, 3, 3, 30);
            panelGroupPatients.Name = "panelGroupPatients";
            panelGroupPatients.Size = new Size(366, 122);
            panelGroupPatients.TabIndex = 48;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(41, 123);
            label20.Name = "label20";
            label20.Size = new Size(132, 21);
            label20.TabIndex = 47;
            label20.Text = "Loại bệnh nhân:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(80, 282);
            label17.Margin = new Padding(1, 0, 3, 0);
            label17.Name = "label17";
            label17.Size = new Size(81, 21);
            label17.TabIndex = 45;
            label17.Text = "BS Khám:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Red;
            label18.Location = new Point(63, 286);
            label18.Name = "label18";
            label18.Size = new Size(13, 17);
            label18.TabIndex = 46;
            label18.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 304);
            label8.Name = "label8";
            label8.Size = new Size(181, 25);
            label8.TabIndex = 2;
            label8.Text = "CHI TIẾT LỊCH HẸN";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Red;
            label23.Location = new Point(568, 123);
            label23.Name = "label23";
            label23.Size = new Size(13, 17);
            label23.TabIndex = 59;
            label23.Text = "*";
            // 
            // textNote
            // 
            textNote.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNote.Location = new Point(660, 114);
            textNote.Margin = new Padding(3, 10, 3, 30);
            textNote.Multiline = true;
            textNote.Name = "textNote";
            textNote.Size = new Size(224, 183);
            textNote.TabIndex = 58;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(587, 120);
            label24.Name = "label24";
            label24.Size = new Size(72, 21);
            label24.TabIndex = 57;
            label24.Text = "Ghi chú:";
            // 
            // Form_New_Patient
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 798);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form_New_Patient";
            Text = "ĐẶT LỊCH DÀNH CHO BỆNH NHÂN MỚI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label15;
        private TextBox textName;
        private Label label16;
        private DateTimePicker textDatePatient;
        private TextBox Text_citizen;
        private Label label2;
        private Label label13;
        private Label label3;
        private Label label12;
        private Label label4;
        private Label label11;
        private RadioButton radiobtnMale;
        private Label label10;
        private RadioButton radiobtnFemale;
        private Label label6;
        private Label label5;
        private TextBox textAddress;
        private TextBox textNumberPhone;
        private Label label7;
        private Label label14;
        private Label label9;
        private DateTimePicker dateTimeAppointment;
        private Panel panel2;
        private Label label8;
        private Label label17;
        private Label label18;
        private Label label19;
        private Panel panelGroupPatients;
        private Label label20;
        private Button btnSubmit;
        private Button btnCancel;
        private Label label21;
        private Label label22;
        private Label Text_slottime;
        private ComboBox combo_doctor;
        private Label label23;
        private TextBox textNote;
        private Label label24;
    }
}