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

        }


        //event add a new patient
        private bool isPatientDataLoaded = false;
        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            Form_Add_Patient formAddPatient = new();

            formAddPatient.FormClosed += (s, args) =>
            {
                this.ParentForm.Enabled = true;

                if (!isPatientDataLoaded)
                {
                    FormLoadPatient();
                    isPatientDataLoaded = true;
                }
            };

            this.ParentForm.Enabled = false;
            formAddPatient.Show();
        }




        //event load form
        private void FormLoadPatient()
        {
            DataTable dataTable = DatabaseManager.getListPatients();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                TableListPatients.DataSource = dataTable;
                MessEmptyData.Visible = false;
                // Add a column for 'Profile'
                DataGridViewButtonColumn profileImageCol = new DataGridViewButtonColumn()
                {
                    HeaderText = "Hồ Sơ",
                    Name = "profile_col",
                    Text = "Xem",
                    UseColumnTextForButtonValue = true
                };

              

                // Insert col in DataGridView
                TableListPatients.Columns.Add(profileImageCol);

                // Set column headers and widths
                TableListPatients.Columns["No"].HeaderText = "No.";
                TableListPatients.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["patient_id"].HeaderText = "MÃ BỆNH NHÂN";
                TableListPatients.Columns["patient_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["name"].HeaderText = "HỌ VÀ TÊN";
                TableListPatients.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["age"].HeaderText = "TUỔI";
                TableListPatients.Columns["age"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                TableListPatients.Columns["address"].HeaderText = "ĐỊA CHỈ LIÊN HỆ";

                // Set gender column header and width
                TableListPatients.Columns["gender_text"].HeaderText = "GIỚI TÍNH";
                TableListPatients.Columns["gender_text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                TableListPatients.Columns["phone"].HeaderText = "ĐIỆN THOẠI";

                TableListPatients.Columns["other_details"].HeaderText = "THÔNG TIN KHÁC";

            }
            else
            {
                MessEmptyData.Visible = true;
                TableListPatients.Visible = false;
            }
        }

    }
}
