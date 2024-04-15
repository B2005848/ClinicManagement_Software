namespace project_gr.Control.AdminPage
{
    partial class Control_PATIENT
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btn_add_patient = new Label();
            label1 = new Label();
            panel1 = new Panel();
            MessEmptyData = new Label();
            TableListPatients = new DataGridView();
            label2 = new Label();
            Quantity_of_Patients = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableListPatients).BeginInit();
            SuspendLayout();
            // 
            // btn_add_patient
            // 
            btn_add_patient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add_patient.Cursor = Cursors.Hand;
            btn_add_patient.Image = Properties.Resources.icons8_add_48;
            btn_add_patient.Location = new Point(1320, 3);
            btn_add_patient.Name = "btn_add_patient";
            btn_add_patient.Size = new Size(61, 72);
            btn_add_patient.TabIndex = 1;
            btn_add_patient.TextAlign = ContentAlignment.TopRight;
            btn_add_patient.Click += btn_add_patient_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(534, 50);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH BỆNH NHÂN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(MessEmptyData);
            panel1.Controls.Add(TableListPatients);
            panel1.Location = new Point(3, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 476);
            panel1.TabIndex = 2;
            // 
            // MessEmptyData
            // 
            MessEmptyData.Anchor = AnchorStyles.Top;
            MessEmptyData.FlatStyle = FlatStyle.Flat;
            MessEmptyData.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessEmptyData.Image = Properties.Resources.icons8_empty_glass_96;
            MessEmptyData.ImageAlign = ContentAlignment.TopCenter;
            MessEmptyData.Location = new Point(531, 166);
            MessEmptyData.Name = "MessEmptyData";
            MessEmptyData.Padding = new Padding(5);
            MessEmptyData.Size = new Size(307, 167);
            MessEmptyData.TabIndex = 1;
            MessEmptyData.Text = "Data Empty !";
            MessEmptyData.TextAlign = ContentAlignment.BottomCenter;
            // 
            // TableListPatients
            // 
            TableListPatients.Anchor = AnchorStyles.Top;
            TableListPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TableListPatients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TableListPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            TableListPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            TableListPatients.DefaultCellStyle = dataGridViewCellStyle6;
            TableListPatients.Location = new Point(-1, 0);
            TableListPatients.Name = "TableListPatients";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            TableListPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            TableListPatients.RowsDefaultCellStyle = dataGridViewCellStyle8;
            TableListPatients.Size = new Size(1378, 473);
            TableListPatients.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 95);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 3;
            label2.Text = "TỔNG SỐ BỆNH NHÂN:";
            // 
            // Quantity_of_Patients
            // 
            Quantity_of_Patients.AutoSize = true;
            Quantity_of_Patients.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quantity_of_Patients.Location = new Point(174, 95);
            Quantity_of_Patients.Name = "Quantity_of_Patients";
            Quantity_of_Patients.Size = new Size(50, 20);
            Quantity_of_Patients.TabIndex = 4;
            Quantity_of_Patients.Text = "label3";
            // 
            // Control_PATIENT
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Quantity_of_Patients);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btn_add_patient);
            Name = "Control_PATIENT";
            Size = new Size(1384, 712);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableListPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btn_add_patient;
        private Label label1;
        private Panel panel1;
        private DataGridView TableListPatients;
        private Label MessEmptyData;
        private Label label2;
        private Label Quantity_of_Patients;
    }
}
