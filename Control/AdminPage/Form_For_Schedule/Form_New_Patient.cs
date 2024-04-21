using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_gr.Control.AdminPage.Form_For_Schedule
{
    public partial class Form_New_Patient : Form
    {
        public int SlotId;
        public Form_New_Patient(int slotId)
        {
           

            this.SlotId = slotId;
            InitializeComponent();
            DataTable data = DatabaseManager.GetInfoSlottime(SlotId);
            DataRow row = data.Rows[0];
            string session_name = row["session_name"].ToString();
            TimeSpan startTime = (TimeSpan)row["start_time"];
            string startTimeString = startTime.ToString(@"hh\:mm");

            TimeSpan endTime = (TimeSpan)row["end_time"];
            string endTimeString = endTime.ToString(@"hh\:mm");

            string timeInfo = $"{session_name}: {startTimeString} - {endTimeString}";

            Text_slottime.Text = timeInfo;


            //Load group name
            DataTable groupDataTable = DatabaseManager.getListGroupPatients();

            if (groupDataTable != null && groupDataTable.Rows.Count > 0)
            {
                foreach (DataRow rows in groupDataTable.Rows)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = rows["group_name"].ToString();
                    checkBox.AutoSize = true;
                    checkBox.Dock = DockStyle.Top;
                    checkBox.Padding = new Padding(10, 5, 0, 0);
                    panelGroupPatients.Controls.Add(checkBox);

                }
                foreach (CheckBox checkbox in panelGroupPatients.Controls)
                {
                    checkbox.CheckedChanged += CheckBox_CheckedChanged;
                }
            }
            else
            {
                MessageBox.Show("No group names found in the database.");

            }

        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            combo_doctor.Items.Clear();

            List<int> groupIds = GetSelectedGroupIds();

            DataTable doctorDataTable = DatabaseManager.GetDoctorsByPatientGroups(groupIds);

            if (doctorDataTable != null && doctorDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in doctorDataTable.Rows)
                {
                    string doctorName = row["DoctorName"].ToString();
                    combo_doctor.Items.Add(doctorName);
                }
            }
            else
            {
                MessageBox.Show("Không có bác sĩ nào phù hợp với các nhóm bệnh nhân đã chọn.");
            }
        }

        private List<int> GetSelectedGroupIds()
        {
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

            return groupIds;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string citizen_id = Text_citizen.Text;
            DateTime age = textDatePatient.Value;
            char gender = radiobtnMale.Checked ? '1' : '0';
            string address = textAddress.Text;
            string phone = textNumberPhone.Text;
            string otherDetails = "";
            DateTime datebook = dateTimeAppointment.Value;
            string doctor_name = combo_doctor.Text;
            string note = textNote.Text;

            //validation field
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân.");
                return;
            }

            if (string.IsNullOrWhiteSpace(citizen_id))
            {
                MessageBox.Show("Căn cước công dân không được trống!");
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

            if (phone.Length > 11 || phone.Length < 9 || !phone.All(char.IsDigit))
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
            //ADD THIS NEW PATIENT END THEN SUBMIT SCHEDULE
            bool addnewPatient = DatabaseManager.AddNewPatientAndAssignGroups(name, citizen_id, age, gender, address, phone, otherDetails, groupIds);

            if (addnewPatient)
            {
                int patientId = DatabaseManager.GetPatientIdByNameAndCitizenId(name, citizen_id);

                int doctor_id = DatabaseManager.GetDoctorIdByName(doctor_name);
                //MAIN
                //SUBMIT APPOINTMENT
                bool booking = DatabaseManager.BookAppointment(patientId, SlotId, doctor_id, datebook, note);
                if (booking) {

                    MessageBox.Show("Đặt lịch thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi khi đặt lịch");

                }

            }
            else
            {
                MessageBox.Show("Bệnh nhân đã tồn tại");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
