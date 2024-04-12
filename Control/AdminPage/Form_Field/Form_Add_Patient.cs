using System.Data;
using System.Data.SqlClient;

namespace project_gr.Control.AdminPage
{
    partial class Form_Add_Patient : Form
    {


        public Form_Add_Patient()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAdd = new Button();
            textMore = new TextBox();
            label9 = new Label();
            panelGroupPatients = new Panel();
            label8 = new Label();
            textAddress = new TextBox();
            label7 = new Label();
            textNumberPhone = new TextBox();
            label5 = new Label();
            radiobtnFemale = new RadioButton();
            radiobtnMale = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textDatePatient = new DateTimePicker();
            textName = new TextBox();
            btnCancel = new Button();
            label1 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(textMore);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panelGroupPatients);
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
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(56, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 766);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(414, 689);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 40);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "THÊM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textMore
            // 
            textMore.BorderStyle = BorderStyle.FixedSingle;
            textMore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMore.Location = new Point(119, 461);
            textMore.Margin = new Padding(3, 10, 3, 30);
            textMore.Multiline = true;
            textMore.Name = "textMore";
            textMore.PlaceholderText = "   Nhập địa chỉ liên hệ";
            textMore.Size = new Size(408, 195);
            textMore.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 461);
            label9.Name = "label9";
            label9.Size = new Size(84, 21);
            label9.TabIndex = 16;
            label9.Text = "Ttin khác:";
            // 
            // panelGroupPatients
            // 
            panelGroupPatients.AutoScroll = true;
            panelGroupPatients.BorderStyle = BorderStyle.Fixed3D;
            panelGroupPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelGroupPatients.Location = new Point(119, 299);
            panelGroupPatients.Margin = new Padding(3, 3, 3, 30);
            panelGroupPatients.Name = "panelGroupPatients";
            panelGroupPatients.Size = new Size(408, 122);
            panelGroupPatients.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(51, 299);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 14;
            label8.Text = "Nhóm:";
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAddress.Location = new Point(119, 239);
            textAddress.Margin = new Padding(3, 10, 3, 30);
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "   Nhập địa chỉ liên hệ";
            textAddress.Size = new Size(408, 27);
            textAddress.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 245);
            label7.Name = "label7";
            label7.Size = new Size(67, 21);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ:";
            // 
            // textNumberPhone
            // 
            textNumberPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNumberPhone.Location = new Point(356, 172);
            textNumberPhone.Margin = new Padding(3, 10, 3, 30);
            textNumberPhone.Name = "textNumberPhone";
            textNumberPhone.PlaceholderText = "   Nhập số điện thoại";
            textNumberPhone.Size = new Size(171, 27);
            textNumberPhone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(256, 177);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 8;
            label5.Text = "Điện thoại:";
            // 
            // radiobtnFemale
            // 
            radiobtnFemale.AutoSize = true;
            radiobtnFemale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnFemale.Location = new Point(179, 178);
            radiobtnFemale.Margin = new Padding(3, 10, 3, 30);
            radiobtnFemale.Name = "radiobtnFemale";
            radiobtnFemale.Size = new Size(47, 24);
            radiobtnFemale.TabIndex = 7;
            radiobtnFemale.TabStop = true;
            radiobtnFemale.Text = "Nữ";
            radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // radiobtnMale
            // 
            radiobtnMale.AutoSize = true;
            radiobtnMale.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnMale.Location = new Point(119, 178);
            radiobtnMale.Margin = new Padding(3, 10, 3, 30);
            radiobtnMale.Name = "radiobtnMale";
            radiobtnMale.Size = new Size(59, 24);
            radiobtnMale.TabIndex = 6;
            radiobtnMale.TabStop = true;
            radiobtnMale.Text = "Nam";
            radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 178);
            label4.Margin = new Padding(1, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 5;
            label4.Text = "Giới tính:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 43);
            label2.Margin = new Padding(1, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên:";
            // 
            // textDatePatient
            // 
            textDatePatient.CustomFormat = "dd/MM/yyyy";
            textDatePatient.Format = DateTimePickerFormat.Custom;
            textDatePatient.Location = new Point(119, 104);
            textDatePatient.Margin = new Padding(3, 10, 3, 30);
            textDatePatient.Name = "textDatePatient";
            textDatePatient.Size = new Size(408, 25);
            textDatePatient.TabIndex = 1;
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(119, 37);
            textName.Margin = new Padding(3, 10, 3, 30);
            textName.Name = "textName";
            textName.PlaceholderText = "   Nhập họ và tên bệnh nhân";
            textName.Size = new Size(408, 27);
            textName.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Location = new Point(110, 689);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 40);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "HỦY BỎ";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(9, 47);
            label6.Name = "label6";
            label6.Size = new Size(13, 17);
            label6.TabIndex = 20;
            label6.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(9, 112);
            label10.Name = "label10";
            label10.Size = new Size(13, 17);
            label10.TabIndex = 21;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(16, 181);
            label11.Name = "label11";
            label11.Size = new Size(13, 17);
            label11.TabIndex = 22;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(237, 180);
            label12.Name = "label12";
            label12.Size = new Size(13, 17);
            label12.TabIndex = 23;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(27, 248);
            label13.Name = "label13";
            label13.Size = new Size(13, 17);
            label13.TabIndex = 24;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(30, 300);
            label14.Name = "label14";
            label14.Size = new Size(13, 17);
            label14.TabIndex = 21;
            label14.Text = "*";
            // 
            // Form_Add_Patient
            // 
            AcceptButton = btnAdd;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(731, 876);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form_Add_Patient";
            Load += Form_Add_Patient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel? panel1;
        private Label? label1;
        private TextBox? textName;
        private Label? label2;
        private DateTimePicker? textDatePatient;
        private Label? label3;
        private RadioButton? radiobtnFemale;
        private RadioButton? radiobtnMale;
        private Label? label4;
        private Label? label5;
        private TextBox? textNumberPhone;
        private Label? label7;
        private TextBox? textAddress;
        private Label? label8;
        private Panel? panelGroupPatients;
        private Label? label9;
        private TextBox? textMore;
        private Button? btnAdd;
        private Button? btnCancel;

        private void Form_Add_Patient_Load(object? sender, EventArgs e)
        {

            DataTable groupDataTable = DatabaseManager.getListGroupPatients();

            if (groupDataTable != null && groupDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in groupDataTable.Rows)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = row["group_name"].ToString();
                    checkBox.AutoSize = true;
                    checkBox.Dock = DockStyle.Top;
                    checkBox.Padding = new Padding(10, 5, 0, 0);
                    panelGroupPatients.Controls.Add(checkBox);
                }
            }
            else
            {
                MessageBox.Show("No group names found in the database.");

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            DateTime age = textDatePatient.Value;
            char gender = radiobtnMale.Checked ? '1' : '0';
            string address = textAddress.Text;
            string phone = textNumberPhone.Text;
            string otherDetails = textMore.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân.");
                return;
            }

            if (age < DateTime.MinValue || age > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh hợp lệ.");
                return;
            }

            if (!radiobtnMale.Checked && !radiobtnFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                return;
            }

            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.");
                return;
            }

            List<int> groupIds = new List<int>();
            foreach (CheckBox checkbox in panelGroupPatients.Controls)
            {
                if (checkbox is CheckBox checkBox && checkBox.Checked)
                {
                    string groupName = checkBox.Text;
                    DataTable groupDataTable = DatabaseManager.getListGroupPatients();
                    if (groupDataTable != null && groupDataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in groupDataTable.Rows)
                        {
                            if (row["group_name"].ToString() == groupName)
                            {
                                int groupId = Convert.ToInt32(row["group_id"]);
                                groupIds.Add(groupId);
                                break;
                            }
                        }
                    }
                }
            }

            if (groupIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhóm.");
                return;
            }

            bool success = DatabaseManager.AddNewPatientAndAssignGroups(name, age, gender, address, phone, otherDetails, groupIds);

            if (success)
            {
                MessageBox.Show("ĐÃ THÊM BỆNH NHÂN THÀNH CÔNG !");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }

        private Label label11;
        private Label label10;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
