namespace project_gr.Layout.AdminPage
{
    using FontAwesome.Sharp;
    partial class Control_HOMEPAGE
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
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            item_patien_home = new Panel();
            patient_quantity_value = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            presciption_quantity_value = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            cls_quantity_value = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            invoice_quantity_value = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            item_patien_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Size = new Size(1384, 712);
            splitContainer1.SplitterDistance = 1072;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DeepSkyBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(3, 226);
            label5.Name = "label5";
            label5.Padding = new Padding(2);
            label5.Size = new Size(299, 25);
            label5.TabIndex = 0;
            label5.Text = "Các lô thuốc sẽ hết hạn trong 60 ngày tới";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Location = new Point(45, 254);
            panel5.Name = "panel5";
            panel5.Size = new Size(997, 442);
            panel5.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(item_patien_home);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(45, 39);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(997, 148);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // item_patien_home
            // 
            item_patien_home.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            item_patien_home.BackColor = Color.WhiteSmoke;
            item_patien_home.Controls.Add(patient_quantity_value);
            item_patien_home.Controls.Add(label1);
            item_patien_home.Controls.Add(pictureBox1);
            item_patien_home.Cursor = Cursors.Hand;
            item_patien_home.Location = new Point(3, 2);
            item_patien_home.Margin = new Padding(3, 2, 20, 2);
            item_patien_home.Name = "item_patien_home";
            item_patien_home.Size = new Size(230, 144);
            item_patien_home.TabIndex = 0;
            item_patien_home.Paint += item_patien_home_Paint;
            // 
            // patient_quantity_value
            // 
            patient_quantity_value.AutoSize = true;
            patient_quantity_value.Font = new Font("Segoe UI", 15F);
            patient_quantity_value.Location = new Point(73, 38);
            patient_quantity_value.Name = "patient_quantity_value";
            patient_quantity_value.Size = new Size(56, 28);
            patient_quantity_value.TabIndex = 2;
            patient_quantity_value.Text = "1520";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(73, 83);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 1;
            label1.Text = "BỆNH NHÂN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_patient_64;
            pictureBox1.Location = new Point(3, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(presciption_quantity_value);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(256, 2);
            panel2.Margin = new Padding(3, 2, 20, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 144);
            panel2.TabIndex = 1;
            // 
            // presciption_quantity_value
            // 
            presciption_quantity_value.AutoSize = true;
            presciption_quantity_value.Font = new Font("Segoe UI", 15F);
            presciption_quantity_value.Location = new Point(73, 38);
            presciption_quantity_value.Name = "presciption_quantity_value";
            presciption_quantity_value.Size = new Size(45, 28);
            presciption_quantity_value.TabIndex = 2;
            presciption_quantity_value.Text = "782";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(73, 83);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 1;
            label2.Text = "ĐƠN THUỐC";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_prescription_64;
            pictureBox2.Location = new Point(3, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cls_quantity_value);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(509, 2);
            panel3.Margin = new Padding(3, 2, 20, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 144);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(73, 38);
            label3.Name = "label3";
            label3.Size = new Size(34, 28);
            label3.TabIndex = 2;
            label3.Text = "15";
            // 
            // cls_quantity_value
            // 
            cls_quantity_value.AutoSize = true;
            cls_quantity_value.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cls_quantity_value.Location = new Point(73, 83);
            cls_quantity_value.Name = "cls_quantity_value";
            cls_quantity_value.Size = new Size(118, 38);
            cls_quantity_value.TabIndex = 1;
            cls_quantity_value.Text = "PHIẾU CHỈ ĐỊNH\r\nCLS";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_folder_64;
            pictureBox3.Location = new Point(3, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(invoice_quantity_value);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(762, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(230, 144);
            panel4.TabIndex = 3;
            // 
            // invoice_quantity_value
            // 
            invoice_quantity_value.AutoSize = true;
            invoice_quantity_value.Font = new Font("Segoe UI", 15F);
            invoice_quantity_value.Location = new Point(73, 38);
            invoice_quantity_value.Name = "invoice_quantity_value";
            invoice_quantity_value.Size = new Size(45, 28);
            invoice_quantity_value.TabIndex = 2;
            invoice_quantity_value.Text = "715";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(73, 83);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 1;
            label4.Text = "HÓA ĐƠN";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_invoice_64;
            pictureBox4.Location = new Point(3, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Padding = new Padding(2);
            label6.Size = new Size(181, 25);
            label6.TabIndex = 0;
            label6.Text = "Các hoạt động mới nhất";
            // 
            // Control_HOMEPAGE
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Control_HOMEPAGE";
            Size = new Size(1384, 712);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            item_patien_home.ResumeLayout(false);
            item_patien_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel item_patien_home;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label patient_quantity_value;
        private PictureBox pictureBox2;
        private Label label2;
        private Label presciption_quantity_value;
        private Label cls_quantity_value;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label invoice_quantity_value;
        private Panel panel5;
        private Label label5;
        private Label label6;
    }
}
