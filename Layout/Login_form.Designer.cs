namespace project_gr
{
    partial class Login_form
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            text_passwd = new TextBox();
            text_username = new TextBox();
            btn_login = new Button();
            Linkhelp = new LinkLabel();
            panel2 = new Panel();
            pageSetupDialog1 = new PageSetupDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(557, 18);
            label2.TabIndex = 1;
            label2.Text = "\"Welcome to ClinicWise, where you can effortlessly manage your clinic operations.\"";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Sans Serif Collection", 39.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(72, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(433, 107);
            label1.TabIndex = 0;
            label1.Text = "clinicwise";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 541);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(text_passwd);
            panel3.Controls.Add(text_username);
            panel3.Controls.Add(btn_login);
            panel3.Controls.Add(Linkhelp);
            panel3.Location = new Point(3, 227);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 306);
            panel3.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(72, 158);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember me?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // text_passwd
            // 
            text_passwd.BorderStyle = BorderStyle.FixedSingle;
            text_passwd.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_passwd.ImeMode = ImeMode.NoControl;
            text_passwd.Location = new Point(71, 107);
            text_passwd.Name = "text_passwd";
            text_passwd.PasswordChar = '*';
            text_passwd.PlaceholderText = "Password";
            text_passwd.Size = new Size(434, 35);
            text_passwd.TabIndex = 1;
            // 
            // text_username
            // 
            text_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text_username.BorderStyle = BorderStyle.FixedSingle;
            text_username.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_username.Location = new Point(71, 43);
            text_username.Name = "text_username";
            text_username.PlaceholderText = "Username";
            text_username.Size = new Size(434, 35);
            text_username.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Highlight;
            btn_login.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(72, 201);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(337, 51);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // Linkhelp
            // 
            Linkhelp.AutoSize = true;
            Linkhelp.Location = new Point(71, 265);
            Linkhelp.Name = "Linkhelp";
            Linkhelp.Size = new Size(141, 17);
            Linkhelp.TabIndex = 3;
            Linkhelp.TabStop = true;
            Linkhelp.Text = "Forget your password!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 218);
            panel2.TabIndex = 4;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(584, 541);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Login_form";
            Text = "                       ";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBox text_username;
        private TextBox text_passwd;
        private PageSetupDialog pageSetupDialog1;
        private Button btn_login;
        private LinkLabel Linkhelp;
        private Panel panel3;
        private Panel panel2;
        private CheckBox checkBox1;
    }
}

