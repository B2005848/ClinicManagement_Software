using project_gr.Control.AdminPage;
using project_gr.Layout.AdminPage;
using project_gr.Control.AdminPage.Children_menu_option;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_gr
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            LoadUserControl(new Control_HOMEPAGE());
            this.FormClosing += AdminPage_FormClosing;

        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseManager.CloseConnection();
            Console.WriteLine("Connection closed.");
        }

        //method show children page
        private void LoadUserControl(UserControl childControl)
        {
            childControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childControl);
        }


        private void focusMenuOpt(ToolStripMenuItem menuOpt)
        {
            menuOpt.ForeColor = Color.FromArgb(0x3D, 0xA9, 0xFC);

            foreach (ToolStripMenuItem item in menuAdminPage.Items)
            {
                if (item != menuOpt)
                {
                    item.ForeColor = Color.FromArgb(9, 64, 103);
                    item.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
                }
            }
        }




        //event load control homepage
        private void sys_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_HOMEPAGE());
            focusMenuOpt(sys_menu_opt);
        }


        //event load control patient
        private void patient_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_PATIENT());
            focusMenuOpt(patient_menu_opt);
        }


        //event load control schedule
        private void calendar_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_SCHEDULE());
            focusMenuOpt(calendar_menu_opt);
        }
      


        //event load control income and expenses
        private void cash_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_INCOME());
            focusMenuOpt(cash_menu_opt);
        }


        //event load control prescription
        private void presc_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_PRESCRIPTION());
            focusMenuOpt(presc_menu_opt);
        }


        //event load control report
        private void report_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_REPORT());
            focusMenuOpt(report_menu_opt);
        }


        //event load control setting
        private void setting_menu_opt_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Control_SETTING());
            focusMenuOpt(setting_menu_opt);
        }


        //event load children control for Examination
        private void unitPre_exam_menu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EXAM_UNIT_PRE());
            focusMenuOpt(unitPre_exam_menu);
            test_menu_opt.ForeColor = Color.FromArgb(0x3D, 0xA9, 0xFC);
            CLS_exam_menu.ForeColor = Color.FromArgb(9, 64, 103);
        }
        private void CLS_exam_menu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new EXAM_CLS());
            focusMenuOpt(CLS_exam_menu);
            unitPre_exam_menu.ForeColor = Color.FromArgb(9, 64, 103);
            test_menu_opt.ForeColor = Color.FromArgb(0x3D, 0xA9, 0xFC);

        }

    }
}
