namespace project_gr.Control.AdminPage.Form_Field
{
    partial class Form_Modify_Info_Patient
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
            label17 = new Label();
            textName = new TextBox();
            textDatePatient = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radiobtnMale = new RadioButton();
            radiobtnFemale = new RadioButton();
            label5 = new Label();
            textNumberPhone = new TextBox();
            label7 = new Label();
            textAddress = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textMore = new TextBox();
            btnSave = new Button();
            Text_citizen = new TextBox();
            label16 = new Label();
            panel1 = new Panel();
            panelGroupPatients = new FlowLayoutPanel();
            btn_Cancel = new Button();
            btn_delete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(52, -88);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.FlatStyle = FlatStyle.System;
            label17.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Highlight;
            label17.Location = new Point(176, 9);
            label17.Name = "label17";
            label17.Size = new Size(369, 37);
            label17.TabIndex = 3;
            label17.Text = "Cập nhật thông tin cá nhân ";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(119, 37);
            textName.Margin = new Padding(3, 10, 3, 30);
            textName.Name = "textName";
            textName.PlaceholderText = "   Nhập họ và tên bệnh nhân";
            textName.Size = new Size(326, 27);
            textName.TabIndex = 0;
            // 
            // textDatePatient
            // 
            textDatePatient.CustomFormat = "dd/MM/yyyy";
            textDatePatient.Format = DateTimePickerFormat.Custom;
            textDatePatient.Location = new Point(119, 104);
            textDatePatient.Margin = new Padding(3, 10, 3, 30);
            textDatePatient.Name = "textDatePatient";
            textDatePatient.Size = new Size(326, 25);
            textDatePatient.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 43);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 108);
            label3.Margin = new Padding(1, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 3;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 169);
            label4.Margin = new Padding(1, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 5;
            label4.Text = "Giới tính:";
            // 
            // radiobtnMale
            // 
            radiobtnMale.AutoSize = true;
            radiobtnMale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnMale.Location = new Point(119, 169);
            radiobtnMale.Margin = new Padding(3, 10, 3, 30);
            radiobtnMale.Name = "radiobtnMale";
            radiobtnMale.Size = new Size(59, 24);
            radiobtnMale.TabIndex = 6;
            radiobtnMale.TabStop = true;
            radiobtnMale.Text = "Nam";
            radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // radiobtnFemale
            // 
            radiobtnFemale.AutoSize = true;
            radiobtnFemale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnFemale.Location = new Point(179, 169);
            radiobtnFemale.Margin = new Padding(3, 10, 3, 30);
            radiobtnFemale.Name = "radiobtnFemale";
            radiobtnFemale.Size = new Size(47, 24);
            radiobtnFemale.TabIndex = 7;
            radiobtnFemale.TabStop = true;
            radiobtnFemale.Text = "Nữ";
            radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(525, 107);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 8;
            label5.Text = "Điện thoại:";
            // 
            // textNumberPhone
            // 
            textNumberPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumberPhone.Location = new Point(625, 102);
            textNumberPhone.Margin = new Padding(3, 10, 3, 30);
            textNumberPhone.Name = "textNumberPhone";
            textNumberPhone.PlaceholderText = "   Nhập số điện thoại";
            textNumberPhone.Size = new Size(171, 27);
            textNumberPhone.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(552, 169);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ:";
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddress.Location = new Point(625, 163);
            textAddress.Margin = new Padding(3, 10, 3, 30);
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "   Nhập địa chỉ liên hệ";
            textAddress.Size = new Size(326, 27);
            textAddress.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(42, 226);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 14;
            label8.Text = "Nhóm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(535, 230);
            label9.Name = "label9";
            label9.Size = new Size(84, 21);
            label9.TabIndex = 16;
            label9.Text = "Ttin khác:";
            // 
            // textMore
            // 
            textMore.BorderStyle = BorderStyle.FixedSingle;
            textMore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMore.Location = new Point(625, 230);
            textMore.Margin = new Padding(3, 10, 3, 30);
            textMore.Multiline = true;
            textMore.Name = "textMore";
            textMore.PlaceholderText = "   Nhập địa chỉ liên hệ";
            textMore.Size = new Size(326, 195);
            textMore.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.icons8_save_40;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(663, 596);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10);
            btnSave.Size = new Size(123, 51);
            btnSave.TabIndex = 18;
            btnSave.Text = "LƯU";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Text_citizen
            // 
            Text_citizen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_citizen.Location = new Point(625, 37);
            Text_citizen.Margin = new Padding(3, 10, 10, 30);
            Text_citizen.Name = "Text_citizen";
            Text_citizen.PlaceholderText = "   Nhập mã căn cước công dân của bệnh nhân";
            Text_citizen.Size = new Size(326, 27);
            Text_citizen.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(563, 43);
            label16.Margin = new Padding(1, 0, 3, 0);
            label16.Name = "label16";
            label16.Size = new Size(56, 21);
            label16.TabIndex = 26;
            label16.Text = "CCCD:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelGroupPatients);
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(Text_citizen);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(textMore);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textAddress);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textNumberPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(radiobtnFemale);
            panel1.Controls.Add(radiobtnMale);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textDatePatient);
            panel1.Controls.Add(textName);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 686);
            panel1.TabIndex = 2;
            // 
            // panelGroupPatients
            // 
            panelGroupPatients.AutoScroll = true;
            panelGroupPatients.FlowDirection = FlowDirection.TopDown;
            panelGroupPatients.Location = new Point(119, 230);
            panelGroupPatients.Name = "panelGroupPatients";
            panelGroupPatients.Size = new Size(326, 195);
            panelGroupPatients.TabIndex = 30;
            panelGroupPatients.WrapContents = false;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ButtonFace;
            btn_Cancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cancel.Image = Properties.Resources.icons8_cancel_40;
            btn_Cancel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancel.Location = new Point(437, 596);
            btn_Cancel.Margin = new Padding(100);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Padding = new Padding(10);
            btn_Cancel.Size = new Size(123, 51);
            btn_Cancel.TabIndex = 29;
            btn_Cancel.Text = "HỦY";
            btn_Cancel.TextAlign = ContentAlignment.MiddleRight;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.RosyBrown;
            btn_delete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Image = Properties.Resources.icons8_trash_40;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(238, 596);
            btn_delete.Name = "btn_delete";
            btn_delete.Padding = new Padding(10);
            btn_delete.Size = new Size(123, 51);
            btn_delete.TabIndex = 28;
            btn_delete.Text = "XÓA";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form_Modify_Info_Patient
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 738);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form_Modify_Info_Patient";
            Text = "Chỉnh sửa thông tin bệnh nhân";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label17;
        private TextBox textName;
        private DateTimePicker textDatePatient;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radiobtnMale;
        private RadioButton radiobtnFemale;
        private Label label5;
        private TextBox textNumberPhone;
        private Label label7;
        private TextBox textAddress;
        private Label label8;
        private Label label9;
        private TextBox textMore;
        private Button btnSave;
        private TextBox Text_citizen;
        private Label label16;
        private Panel panel1;
        private Button btn_Cancel;
        private Button btn_delete;
        private FlowLayoutPanel panelGroupPatients;
    }
}