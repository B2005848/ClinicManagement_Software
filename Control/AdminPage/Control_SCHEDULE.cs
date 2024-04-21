using project_gr.Control.AdminPage.Form_For_Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project_gr.Layout.AdminPage
{
    public partial class Control_SCHEDULE : UserControl
    {
        public Control_SCHEDULE()
        {
            InitializeComponent();
            loadControl_SCHEDULE();
        }

        private void loadControl_SCHEDULE()
        {

            DataGridViewButtonColumn col_tool = new()
            {
                HeaderText = "Tool",
                Name = "Submit",
                Text = "Cập nhật",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            };
            DateTime currentDate = DateTime.Today;

            DataTable data = DatabaseManager.GetAvailableTimeSlots();
            foreach (DataRow row in data.Rows)
            {
                string session_name = row["session_name"].ToString();
                TimeSpan startTime = (TimeSpan)row["start_time"];
                string startTimeString = startTime.ToString(@"hh\:mm");

                string timeInfo = $"{currentDate:dd/MM/yyyy} - {startTimeString}";

                switch (session_name)
                {
                    case "Sáng":
                        time_morning.Text = timeInfo;
                        time_morning.Tag = row["slot_id"];
                        break;
                    case "Chiều":
                        time_afternoon.Text = timeInfo;
                        time_afternoon.Tag = row["slot_id"];
                        break;
                    case "Tối":
                        time_night.Text = timeInfo;
                        time_night.Tag = row["slot_id"];
                        break;
                    default:
                        break;
                }
            }

            DataTable dataSchedule = DatabaseManager.getAll_Schedule();


            dataGrid_Schedule.DataSource = dataSchedule;
            dataGrid_Schedule.Columns.Add(col_tool);

            dataGrid_Schedule.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            dataGrid_Schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);

            dataGrid_Schedule.Columns["No"].HeaderText = "No.";

            dataGrid_Schedule.Columns["appointment_id"].HeaderText = "Mã lịch hẹn";

            dataGrid_Schedule.Columns["name"].HeaderText = "Tên bệnh nhân";

            dataGrid_Schedule.Columns["patient_id"].HeaderText = "Mã bệnh nhân";

            dataGrid_Schedule.Columns["appointment_datetime"].HeaderText = "Thời gian hẹn";

            dataGrid_Schedule.Columns["doctor_name"].HeaderText = "Tên bác sĩ";

            dataGrid_Schedule.Columns["status"].HeaderText = "Trạng thái";


        }

        private void btn_schl_moring_new_Click(object sender, EventArgs e)
        {
            int slotId = (int)time_morning.Tag;
            Form_New_Patient form_New_Patient = new Form_New_Patient(slotId);
            form_New_Patient.ShowDialog();
        }

        private void btn_schl_afternoon_new_Click(object sender, EventArgs e)
        {
            int slotId = (int)time_afternoon.Tag;
            Form_New_Patient form_New_Patient = new Form_New_Patient(slotId);
            form_New_Patient.ShowDialog();
        }

        private void btn_schl_night_new_Click(object sender, EventArgs e)
        {
            int slotId = (int)time_night.Tag;
            Form_New_Patient form_New_Patient = new Form_New_Patient(slotId);
            form_New_Patient.ShowDialog();
        }
    }
}
