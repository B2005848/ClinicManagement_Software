namespace project_gr.Layout.AdminPage
{
    partial class Control_PRESCRIPTION
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
            label1 = new Label();
            dataGrid = new DataGridView();
            btn_add_patient = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(487, 16);
            label1.Name = "label1";
            label1.Size = new Size(328, 37);
            label1.TabIndex = 0;
            label1.Text = "TRANG QUẢN LÍ THUỐC";
            // 
            // dataGrid
            // 
            dataGrid.Anchor = AnchorStyles.Top;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(3, 78);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1294, 579);
            dataGrid.TabIndex = 1;
            // 
            // btn_add_patient
            // 
            btn_add_patient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add_patient.Cursor = Cursors.Hand;
            btn_add_patient.Image = Properties.Resources.icons8_add_48;
            btn_add_patient.Location = new Point(1236, 0);
            btn_add_patient.Name = "btn_add_patient";
            btn_add_patient.Size = new Size(61, 72);
            btn_add_patient.TabIndex = 2;
            btn_add_patient.TextAlign = ContentAlignment.TopRight;
            // 
            // Control_PRESCRIPTION
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_add_patient);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Name = "Control_PRESCRIPTION";
            Size = new Size(1300, 700);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGrid;
        private Label btn_add_patient;
    }
}
