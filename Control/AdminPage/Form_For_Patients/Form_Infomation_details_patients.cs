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
    public partial class Form_Infomation_details_patients : Form
    {
        private int patientId;

        public Form_Infomation_details_patients(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            Text_name.Text = patientId.ToString();
            LoadPatientInformation();
            //Center for text value
            if (dataGroup.Rows.Count > 0)
            {
                dataGroup.Columns["group_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dataAppointment.Rows.Count > 0)
            {
                dataAppointment.Columns["appointment_datetime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataAppointment.Columns["status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataAppointment.Columns["employee_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataAppointment.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dataGridView3.Rows.Count > 0)
            {
                dataGridView3.Columns["diagnosis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }



            //Center for header
            foreach (DataGridViewColumn column in dataAppointment.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void LoadPatientInformation()
        {
            DataSet patientData = DatabaseManager.GetPatientDetails(patientId);
            if (patientData != null && patientData.Tables.Count > 0)
            {
                DataTable personalInfoTable = patientData.Tables["PersonalInfo"];
                if (personalInfoTable.Rows.Count > 0)
                {
                    DataRow row = personalInfoTable.Rows[0];
                    Text_name.Text = row["name"].ToString();
                    Text_citizen.Text = row["citizen_id"].ToString();
                    Text_more.Text = row["other_details"].ToString();
                    Text_date.Text = ((DateTime)row["age"]).ToString("dd-MM-yyyy");
                    Text_gender.Text = row["gender_text"].ToString();
                    Text_address.Text = row["address"].ToString();
                    Text_phone.Text = row["phone"].ToString();
                }

                DataTable groupInfoTable = patientData.Tables["GroupInfo"];
                if (groupInfoTable.Rows.Count > 0)
                {
                    dataGroup.DataSource = groupInfoTable;
                    dataGroup.Columns["group_name"].HeaderText = "";
                    dataGroup.Columns["group_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }

                DataTable appointmentsTable = patientData.Tables["Appointments"];
                if (appointmentsTable.Rows.Count > 0)
                {
                    dataAppointment.Visible = true;
                    Message_Empty_Data_Appoint.Visible = false;
                    dataAppointment.DataSource = appointmentsTable;
                    dataAppointment.Columns["appointment_datetime"].HeaderText = "Ngày và giờ khám";
                    dataAppointment.Columns["appointment_datetime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataAppointment.Columns["appointment_datetime"].DisplayIndex = 2;


                    dataAppointment.Columns["employee_id"].HeaderText = "Mã bác sĩ";
                    dataAppointment.Columns["employee_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataAppointment.Columns["employee_id"].DisplayIndex = 0;

                    dataAppointment.Columns["name"].HeaderText = "Tên bác sĩ";
                    dataAppointment.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataAppointment.Columns["name"].DisplayIndex = 1;


                    dataAppointment.Columns["status"].HeaderText = "Trạng thái";
                    dataAppointment.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataAppointment.Columns["status"].DisplayIndex = 3;

                }
                else
                {
                    dataAppointment.Visible = false;
                    Message_Empty_Data_Appoint.Visible = true;
                }

                DataTable Medical_RecordTable = patientData.Tables["Medical_Record"];
                if (Medical_RecordTable.Rows.Count > 0)
                {
                    dataGridView3.Visible = true;
                    Message_Empty_MR.Visible = false;
                    dataGridView3.DataSource = Medical_RecordTable;
                    dataGridView3.Columns["diagnosis"].HeaderText = "Chuẩn đoán";
                    dataGridView3.Columns["diagnosis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    dataGridView3.Visible = false;
                    Message_Empty_MR.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Không có thông tin cho bệnh nhân này.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Modify_Info_Patient form_Modify_Info_Patient = new(patientId);
            form_Modify_Info_Patient.ShowDialog(this);

        }
    }
}


