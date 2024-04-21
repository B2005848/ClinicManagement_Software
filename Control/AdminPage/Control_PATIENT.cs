using project_gr.Control.AdminPage.Form_Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_gr.Control.AdminPage
{
    public partial class Control_PATIENT : UserControl
    {
        public Control_PATIENT()
        {
            InitializeComponent();
            FormLoadPatient();
            TableListPatients.CellContentClick += TableListPatients_CellClick;
  
    }


    //function get quantity of Patients
    private void getQuantityPatients()
    {
        if (DatabaseManager.OpenConnection())
        {
            String quantity = DatabaseManager.GetQuantity_patient();
            Quantity_of_Patients.Text = quantity;

        }
        else
        {
            MessageBox.Show("Error occurred while getting quantity of patients.");
        }
    }


    //event add a new patient
    private bool isPatientDataLoaded = false;
        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            Form_Add_Patient formAddPatient = new();
            ParentForm.Enabled = false;
            formAddPatient.Show();

            formAddPatient.FormClosed += (s, args) =>
            {
                this.ParentForm.Enabled = true;

                if (!isPatientDataLoaded)
                {
                    FormLoadPatient();
                    isPatientDataLoaded = true;
                }
            };

        }

        private void TableListPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TableListPatients.Columns["delete_col"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int patientId = Convert.ToInt32(TableListPatients.Rows[e.RowIndex].Cells["patient_id"].Value);

                    bool success = DatabaseManager.DeletePatient(patientId);

                    if (success)
                    {
                        MessageBox.Show("Đã xóa thành công!");
                        FormLoadPatient();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa bệnh nhân. Vui lòng thử lại sau.");
                    }
                }


                
            }
            else if (TableListPatients.Columns[e.ColumnIndex].Name == "profile_col")
            {
                int patientId = Convert.ToInt32(TableListPatients.Rows[e.RowIndex].Cells["patient_id"].Value);
                Form_Infomation_details_patients formInfoDetails = new(patientId);
                formInfoDetails.ShowDialog();
            }
        }




        //event load form
        private void FormLoadPatient()
        {
            TableListPatients.Columns.Clear();
            DataTable dataTable = DatabaseManager.getListPatients();
            getQuantityPatients();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                TableListPatients.DataSource = dataTable;
                MessEmptyData.Visible = false;
                // Add a column for 'Profile'
                DataGridViewButtonColumn profileImageCol = new()
                {
                    HeaderText = "Hồ Sơ",
                    Name = "profile_col",
                    Text = "Xem",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
                };

                DataGridViewButtonColumn col_delete = new()
                {
                    HeaderText = "Tool",
                    Name = "delete_col",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                };

             

                // Insert col in DataGridView
                TableListPatients.Columns.Add(profileImageCol);
                TableListPatients.Columns.Add(col_delete);
                // Set column headers and widths
                TableListPatients.Columns["No"].HeaderText = "No.";
                TableListPatients.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["patient_id"].HeaderText = "MÃ BỆNH NHÂN";
                TableListPatients.Columns["patient_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["citizen_id"].HeaderText = "CCCD";
                TableListPatients.Columns["citizen_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["name"].HeaderText = "HỌ VÀ TÊN";
                TableListPatients.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["age"].HeaderText = "TUỔI";
                TableListPatients.Columns["age"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["address"].HeaderText = "ĐỊA CHỈ LIÊN HỆ";

                // Set gender column header and width
                TableListPatients.Columns["gender_text"].HeaderText = "GIỚI TÍNH";
                TableListPatients.Columns["gender_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                TableListPatients.Columns["phone"].HeaderText = "ĐIỆN THOẠI";


            }
            else
            {
                MessEmptyData.Visible = true;
                TableListPatients.Visible = false;
            }
        }

    }
}
