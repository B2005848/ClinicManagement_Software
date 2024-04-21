using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_gr.Control.AdminPage.Form_Field
{
    public partial class Form_Modify_Info_Patient : Form
    {
        private int patientId;

        public Form_Modify_Info_Patient(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;

            //infomation basic 
            DataSet patientData = DatabaseManager.GetPatientDetails(patientId);
            if (patientData != null && patientData.Tables.Count > 0)
            {
                DataTable personalInfoTable = patientData.Tables["PersonalInfo"];
                if (personalInfoTable.Rows.Count > 0)
                {
                    DataRow row = personalInfoTable.Rows[0];
                    textName.Text = row["name"].ToString();
                    Text_citizen.Text = row["citizen_id"].ToString();
                    textDatePatient.Text = row["age"].ToString();
                    string genderText = row["gender_text"].ToString();
                    textMore.Text = row["other_details"].ToString();
                    if (genderText == "Nam")
                    {
                        radiobtnMale.Checked = true;
                    }
                    else if (genderText == "Nữ")
                    {
                        radiobtnFemale.Checked = true;
                    }
                    textAddress.Text = row["address"].ToString();
                    textNumberPhone.Text = row["phone"].ToString();
                }

            }


            // Load group information of patient
            DataTable groupInfoTable = patientData.Tables["GroupInfo"];
            if (groupInfoTable.Rows.Count > 0)
            {
                foreach (DataRow row in groupInfoTable.Rows)
                {
                    string groupName_Patient = row["group_name"].ToString();
                    AddGroupCheckbox(groupName_Patient);
                }
            }

            // Get all groups
            DataTable allGroupsTable = DatabaseManager.getListGroupPatients();

            // Check if patient belongs to each group
            if (allGroupsTable != null && allGroupsTable.Rows.Count > 0)
            {
                foreach (DataRow row in allGroupsTable.Rows)
                {
                    string groupName = row["group_name"].ToString();
                    AddGroupCheckbox(groupName);
                    bool patientBelongsToGroup = groupInfoTable.AsEnumerable().Any(r => r.Field<string>("group_name") == groupName);
                    if (patientBelongsToGroup)
                    {
                        CheckBox checkBox = (CheckBox)panelGroupPatients.Controls[groupName];
                        checkBox.Checked = true;
                    }
                }
            }

        }
        private void AddGroupCheckbox(string groupName)
        {
            CheckBox checkBox = new()
            {
                Name = groupName,
                Text = groupName,
                AutoSize = true
            };

            panelGroupPatients.Controls.Add(checkBox);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string citizenId = Text_citizen.Text;
            DateTime age = textDatePatient.Value;
            string gender = radiobtnMale.Checked ? "1" : "0";
            string address = textAddress.Text;
            string phoneNumber = textNumberPhone.Text;
            string other_detail = textMore.Text;
            List<string> selectedGroups = [];
            foreach (CheckBox checkBox in panelGroupPatients.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    selectedGroups.Add(checkBox.Text);
                }
            }

            bool success = DatabaseManager.UpdatePatientInformation(patientId, name, citizenId, age, gender, address, phoneNumber, other_detail, selectedGroups);
            if (success)
            {
                MessageBox.Show("Cập nhật thông tin bệnh nhân thành công.");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin bệnh nhân.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool success = DatabaseManager.DeletePatient(patientId);

                if (success)
                {
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa bệnh nhân. Vui lòng thử lại sau.");
                }
            }
            else
            {
                MessageBox.Show("Đã hủy thao tác");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
