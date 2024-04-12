using Microsoft.VisualBasic.ApplicationServices;

namespace project_gr
{
    partial class AdminPage
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
            menuAdminPage = new MenuStrip();
            sys_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            patient_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            calendar_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            test_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            unitPre_exam_menu = new ToolStripMenuItem();
            CLS_exam_menu = new ToolStripMenuItem();
            cash_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            presc_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            report_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            setting_menu_opt = new FontAwesome.Sharp.IconMenuItem();
            panelMain = new Panel();
            lỊCHHẸNToolStripMenuItem = new ToolStripMenuItem();
            menuAdminPage.SuspendLayout();
            SuspendLayout();
            // 
            // menuAdminPage
            // 
            menuAdminPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuAdminPage.AutoSize = false;
            menuAdminPage.BackColor = Color.FromArgb(216, 238, 254);
            menuAdminPage.Dock = DockStyle.None;
            menuAdminPage.GripStyle = ToolStripGripStyle.Visible;
            menuAdminPage.Items.AddRange(new ToolStripItem[] { sys_menu_opt, patient_menu_opt, calendar_menu_opt, test_menu_opt, cash_menu_opt, presc_menu_opt, report_menu_opt, setting_menu_opt });
            menuAdminPage.Location = new Point(0, 0);
            menuAdminPage.Name = "menuAdminPage";
            menuAdminPage.Padding = new Padding(3, 10, 0, 10);
            menuAdminPage.Size = new Size(1385, 50);
            menuAdminPage.TabIndex = 0;
            menuAdminPage.Text = "menuStrip1";
            // 
            // sys_menu_opt
            // 
            sys_menu_opt.AutoSize = false;
            sys_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            sys_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            sys_menu_opt.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            sys_menu_opt.IconColor = SystemColors.ActiveCaption;
            sys_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            sys_menu_opt.IconSize = 60;
            sys_menu_opt.Name = "sys_menu_opt";
            sys_menu_opt.Size = new Size(156, 30);
            sys_menu_opt.Text = " TRANG CHỦ";
            sys_menu_opt.Click += sys_menu_opt_Click;
            // 
            // patient_menu_opt
            // 
            patient_menu_opt.AutoSize = false;
            patient_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            patient_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            patient_menu_opt.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            patient_menu_opt.IconColor = Color.IndianRed;
            patient_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            patient_menu_opt.Name = "patient_menu_opt";
            patient_menu_opt.Size = new Size(155, 30);
            patient_menu_opt.Text = "BỆNH NHÂN";
            patient_menu_opt.Click += patient_menu_opt_Click;
            // 
            // calendar_menu_opt
            // 
            calendar_menu_opt.AutoSize = false;
            calendar_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            calendar_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            calendar_menu_opt.IconChar = FontAwesome.Sharp.IconChar.Clock;
            calendar_menu_opt.IconColor = Color.Orange;
            calendar_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            calendar_menu_opt.Name = "calendar_menu_opt";
            calendar_menu_opt.Size = new Size(128, 30);
            calendar_menu_opt.Text = "LỊCH HẸN";
            calendar_menu_opt.Click += calendar_menu_opt_Click;
            // 
            // test_menu_opt
            // 
            test_menu_opt.AutoSize = false;
            test_menu_opt.DropDownItems.AddRange(new ToolStripItem[] { unitPre_exam_menu, CLS_exam_menu });
            test_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            test_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            test_menu_opt.IconChar = FontAwesome.Sharp.IconChar.Table;
            test_menu_opt.IconColor = Color.FromArgb(0, 192, 0);
            test_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            test_menu_opt.Name = "test_menu_opt";
            test_menu_opt.Size = new Size(155, 30);
            test_menu_opt.Text = "KHÁM BỆNH";
            // 
            // unitPre_exam_menu
            // 
            unitPre_exam_menu.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitPre_exam_menu.Name = "unitPre_exam_menu";
            unitPre_exam_menu.Size = new Size(243, 28);
            unitPre_exam_menu.Text = "ĐƠN THUỐC";
            unitPre_exam_menu.Click += unitPre_exam_menu_Click;
            // 
            // CLS_exam_menu
            // 
            CLS_exam_menu.Font = new Font("Segoe UI", 12.75F);
            CLS_exam_menu.Name = "CLS_exam_menu";
            CLS_exam_menu.Size = new Size(243, 28);
            CLS_exam_menu.Text = "PHIẾU CHỈ ĐỊNH CLS";
            CLS_exam_menu.Click += CLS_exam_menu_Click;
            // 
            // cash_menu_opt
            // 
            cash_menu_opt.AutoSize = false;
            cash_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            cash_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            cash_menu_opt.IconChar = FontAwesome.Sharp.IconChar.Coins;
            cash_menu_opt.IconColor = Color.FromArgb(128, 128, 255);
            cash_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cash_menu_opt.Name = "cash_menu_opt";
            cash_menu_opt.Size = new Size(118, 30);
            cash_menu_opt.Text = "THU CHI";
            cash_menu_opt.Click += cash_menu_opt_Click;
            // 
            // presc_menu_opt
            // 
            presc_menu_opt.AutoSize = false;
            presc_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            presc_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            presc_menu_opt.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleAlt;
            presc_menu_opt.IconColor = Color.IndianRed;
            presc_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            presc_menu_opt.Name = "presc_menu_opt";
            presc_menu_opt.Size = new Size(106, 30);
            presc_menu_opt.Text = "THUỐC";
            presc_menu_opt.Click += presc_menu_opt_Click;
            // 
            // report_menu_opt
            // 
            report_menu_opt.AutoSize = false;
            report_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            report_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            report_menu_opt.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            report_menu_opt.IconColor = Color.Tomato;
            report_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            report_menu_opt.Name = "report_menu_opt";
            report_menu_opt.Size = new Size(123, 30);
            report_menu_opt.Text = "BÁO CÁO";
            report_menu_opt.Click += report_menu_opt_Click;
            // 
            // setting_menu_opt
            // 
            setting_menu_opt.AutoSize = false;
            setting_menu_opt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            setting_menu_opt.ForeColor = Color.FromArgb(9, 64, 103);
            setting_menu_opt.IconChar = FontAwesome.Sharp.IconChar.Gear;
            setting_menu_opt.IconColor = Color.MediumSeaGreen;
            setting_menu_opt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            setting_menu_opt.Name = "setting_menu_opt";
            setting_menu_opt.Size = new Size(114, 30);
            setting_menu_opt.Text = "CÀI ĐẶT";
            setting_menu_opt.Click += setting_menu_opt_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Location = new Point(0, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1384, 711);
            panelMain.TabIndex = 1;
            // 
            // lỊCHHẸNToolStripMenuItem
            // 
            lỊCHHẸNToolStripMenuItem.Name = "lỊCHHẸNToolStripMenuItem";
            lỊCHHẸNToolStripMenuItem.Size = new Size(32, 19);
            lỊCHHẸNToolStripMenuItem.Text = "LỊCH HẸN";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 761);
            Controls.Add(panelMain);
            Controls.Add(menuAdminPage);
            MainMenuStrip = menuAdminPage;
            Name = "AdminPage";
            Text = "AdminPage";
            menuAdminPage.ResumeLayout(false);
            menuAdminPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private MenuStrip menuAdminPage;
        private Panel panelMain;
        private FontAwesome.Sharp.IconMenuItem sys_menu_opt;
        private FontAwesome.Sharp.IconMenuItem patient_menu_opt;
        private FontAwesome.Sharp.IconMenuItem calendar_menu_opt;
        private FontAwesome.Sharp.IconMenuItem test_menu_opt;
        private FontAwesome.Sharp.IconMenuItem cash_menu_opt;
        private FontAwesome.Sharp.IconMenuItem presc_menu_opt;
        private FontAwesome.Sharp.IconMenuItem report_menu_opt;
        private FontAwesome.Sharp.IconMenuItem setting_menu_opt;
        private ToolStripMenuItem unitPre_exam_menu;
        private ToolStripMenuItem CLS_exam_menu;
        private ToolStripMenuItem lỊCHHẸNToolStripMenuItem;
    }
}
