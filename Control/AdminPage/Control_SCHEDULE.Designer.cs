namespace project_gr.Layout.AdminPage
{
    partial class Control_SCHEDULE
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            label1 = new Label();
            panel4 = new Panel();
            btn_schl_moring_new = new Label();
            btn_schl_moring_old = new Label();
            time_morning = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btn_schl_night_new = new Label();
            btn_schl_night_old = new Label();
            time_night = new Label();
            panel2 = new Panel();
            btn_schl_afternoon_new = new Label();
            btn_schl_afternoon_old = new Label();
            time_afternoon = new Label();
            dataGrid_Schedule = new DataGridView();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Schedule).BeginInit();
            SuspendLayout();
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(32, 19);
            iconMenuItem2.Text = "iconMenuItem2";
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(32, 19);
            iconMenuItem3.Text = "iconMenuItem3";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(572, 122);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH LỊCH HẸN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btn_schl_moring_new);
            panel4.Controls.Add(btn_schl_moring_old);
            panel4.Controls.Add(time_morning);
            panel4.Location = new Point(50, 37);
            panel4.Margin = new Padding(50, 3, 30, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 38);
            panel4.TabIndex = 8;
            // 
            // btn_schl_moring_new
            // 
            btn_schl_moring_new.AutoSize = true;
            btn_schl_moring_new.Cursor = Cursors.Hand;
            btn_schl_moring_new.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_moring_new.ForeColor = Color.SeaGreen;
            btn_schl_moring_new.Location = new Point(252, 8);
            btn_schl_moring_new.Name = "btn_schl_moring_new";
            btn_schl_moring_new.Size = new Size(116, 21);
            btn_schl_moring_new.TabIndex = 7;
            btn_schl_moring_new.Text = "Bệnh nhân mới";
            btn_schl_moring_new.Click += btn_schl_moring_new_Click;
            // 
            // btn_schl_moring_old
            // 
            btn_schl_moring_old.AutoSize = true;
            btn_schl_moring_old.Cursor = Cursors.Hand;
            btn_schl_moring_old.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_moring_old.ForeColor = Color.SeaGreen;
            btn_schl_moring_old.Location = new Point(160, 8);
            btn_schl_moring_old.Name = "btn_schl_moring_old";
            btn_schl_moring_old.Size = new Size(71, 21);
            btn_schl_moring_old.TabIndex = 6;
            btn_schl_moring_old.Text = "Tái khám";
            // 
            // time_morning
            // 
            time_morning.AutoSize = true;
            time_morning.Location = new Point(3, 11);
            time_morning.Name = "time_morning";
            time_morning.Size = new Size(151, 16);
            time_morning.TabIndex = 6;
            time_morning.Text = "18/04/2024 - 7:00 ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 116);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btn_schl_night_new);
            panel3.Controls.Add(btn_schl_night_old);
            panel3.Controls.Add(time_night);
            panel3.Location = new Point(962, 37);
            panel3.Margin = new Padding(50, 3, 30, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 38);
            panel3.TabIndex = 10;
            // 
            // btn_schl_night_new
            // 
            btn_schl_night_new.AutoSize = true;
            btn_schl_night_new.Cursor = Cursors.Hand;
            btn_schl_night_new.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_night_new.ForeColor = Color.SeaGreen;
            btn_schl_night_new.Location = new Point(252, 8);
            btn_schl_night_new.Name = "btn_schl_night_new";
            btn_schl_night_new.Size = new Size(116, 21);
            btn_schl_night_new.TabIndex = 7;
            btn_schl_night_new.Text = "Bệnh nhân mới";
            btn_schl_night_new.Click += btn_schl_night_new_Click;
            // 
            // btn_schl_night_old
            // 
            btn_schl_night_old.AutoSize = true;
            btn_schl_night_old.Cursor = Cursors.Hand;
            btn_schl_night_old.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_night_old.ForeColor = Color.SeaGreen;
            btn_schl_night_old.Location = new Point(160, 8);
            btn_schl_night_old.Name = "btn_schl_night_old";
            btn_schl_night_old.Size = new Size(71, 21);
            btn_schl_night_old.TabIndex = 6;
            btn_schl_night_old.Text = "Tái khám";
            // 
            // time_night
            // 
            time_night.AutoSize = true;
            time_night.Location = new Point(3, 11);
            time_night.Name = "time_night";
            time_night.Size = new Size(151, 16);
            time_night.TabIndex = 6;
            time_night.Text = "18/04/2024 - 7:00 ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_schl_afternoon_new);
            panel2.Controls.Add(btn_schl_afternoon_old);
            panel2.Controls.Add(time_afternoon);
            panel2.Location = new Point(508, 37);
            panel2.Margin = new Padding(50, 3, 30, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 38);
            panel2.TabIndex = 10;
            // 
            // btn_schl_afternoon_new
            // 
            btn_schl_afternoon_new.AutoSize = true;
            btn_schl_afternoon_new.Cursor = Cursors.Hand;
            btn_schl_afternoon_new.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_afternoon_new.ForeColor = Color.SeaGreen;
            btn_schl_afternoon_new.Location = new Point(252, 8);
            btn_schl_afternoon_new.Name = "btn_schl_afternoon_new";
            btn_schl_afternoon_new.Size = new Size(116, 21);
            btn_schl_afternoon_new.TabIndex = 7;
            btn_schl_afternoon_new.Text = "Bệnh nhân mới";
            btn_schl_afternoon_new.Click += btn_schl_afternoon_new_Click;
            // 
            // btn_schl_afternoon_old
            // 
            btn_schl_afternoon_old.AutoSize = true;
            btn_schl_afternoon_old.Cursor = Cursors.Hand;
            btn_schl_afternoon_old.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_schl_afternoon_old.ForeColor = Color.SeaGreen;
            btn_schl_afternoon_old.Location = new Point(160, 8);
            btn_schl_afternoon_old.Name = "btn_schl_afternoon_old";
            btn_schl_afternoon_old.Size = new Size(71, 21);
            btn_schl_afternoon_old.TabIndex = 6;
            btn_schl_afternoon_old.Text = "Tái khám";
            // 
            // time_afternoon
            // 
            time_afternoon.AutoSize = true;
            time_afternoon.Location = new Point(3, 11);
            time_afternoon.Name = "time_afternoon";
            time_afternoon.Size = new Size(151, 16);
            time_afternoon.TabIndex = 6;
            time_afternoon.Text = "18/04/2024 - 7:00 ";
            // 
            // dataGrid_Schedule
            // 
            dataGrid_Schedule.Anchor = AnchorStyles.Top;
            dataGrid_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_Schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid_Schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_Schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid_Schedule.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_Schedule.Location = new Point(3, 166);
            dataGrid_Schedule.Name = "dataGrid_Schedule";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGrid_Schedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGrid_Schedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid_Schedule.Size = new Size(1378, 543);
            dataGrid_Schedule.TabIndex = 10;
            // 
            // Control_SCHEDULE
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(dataGrid_Schedule);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Control_SCHEDULE";
            Size = new Size(1384, 712);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_Schedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private Label label1;
        private Panel panel4;
        private Label btn_schl_moring_new;
        private Label btn_schl_moring_old;
        private Label time_morning;
        private Panel panel1;
        private Panel panel3;
        private Label btn_schl_night_new;
        private Label btn_schl_night_old;
        private Label time_night;
        private Panel panel2;
        private Label btn_schl_afternoon_new;
        private Label btn_schl_afternoon_old;
        private Label time_afternoon;
        private DataGridView dataGrid_Schedule;
    }
}
