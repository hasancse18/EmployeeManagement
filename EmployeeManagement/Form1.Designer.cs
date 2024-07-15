namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            register_btn = new Button();
            label4 = new Label();
            panel2 = new Panel();
            exit = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            login_check = new CheckBox();
            login_btn = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 450);
            panel1.TabIndex = 0;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(75, 8, 138);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            register_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            register_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.Transparent;
            register_btn.Location = new Point(11, 387);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(223, 36);
            register_btn.TabIndex = 10;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(48, 355);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 9;
            label4.Text = "Register Your Account";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.icons8_employee_card_100px;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(73, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(102, 96);
            panel2.TabIndex = 8;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(508, 0);
            exit.Name = "exit";
            exit.Size = new Size(24, 23);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 140);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 216);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(287, 162);
            login_username.Name = "login_username";
            login_username.Size = new Size(203, 25);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(287, 238);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(203, 25);
            login_password.TabIndex = 5;
            // 
            // login_check
            // 
            login_check.AutoSize = true;
            login_check.Cursor = Cursors.Hand;
            login_check.FlatAppearance.BorderColor = Color.Black;
            login_check.FlatAppearance.BorderSize = 2;
            login_check.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            login_check.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            login_check.FlatStyle = FlatStyle.System;
            login_check.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_check.Location = new Point(388, 271);
            login_check.Name = "login_check";
            login_check.Size = new Size(112, 20);
            login_check.TabIndex = 6;
            login_check.Text = "Show Password";
            login_check.UseVisualStyleBackColor = true;
            login_check.CheckedChanged += login_check_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 11, 97);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            login_btn.FlatAppearance.MouseDownBackColor = Color.Red;
            login_btn.FlatAppearance.MouseOverBackColor = Color.Red;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Transparent;
            login_btn.Location = new Point(287, 339);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 36);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 53);
            label3.Name = "label3";
            label3.Size = new Size(184, 31);
            label3.TabIndex = 8;
            label3.Text = "Login Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(label3);
            Controls.Add(login_btn);
            Controls.Add(login_check);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private TextBox login_password;
        private CheckBox login_check;
        private Button login_btn;
        private Panel panel2;
        private Label label3;
        private Button register_btn;
        private Label label4;
    }
}
