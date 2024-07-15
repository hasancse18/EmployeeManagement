namespace EmployeeManagement
{
    partial class Register
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
            label3 = new Label();
            button1 = new Button();
            signup_check = new CheckBox();
            register_pass = new TextBox();
            register_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            exit = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(273, 54);
            label3.Name = "label3";
            label3.Size = new Size(213, 31);
            label3.TabIndex = 17;
            label3.Text = "Register Account";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(273, 339);
            button1.Name = "button1";
            button1.Size = new Size(109, 36);
            button1.TabIndex = 16;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup_check
            // 
            signup_check.AutoSize = true;
            signup_check.Cursor = Cursors.Hand;
            signup_check.FlatAppearance.BorderColor = Color.Black;
            signup_check.FlatAppearance.BorderSize = 2;
            signup_check.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 11, 97);
            signup_check.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 11, 97);
            signup_check.FlatStyle = FlatStyle.System;
            signup_check.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_check.Location = new Point(374, 271);
            signup_check.Name = "signup_check";
            signup_check.Size = new Size(112, 20);
            signup_check.TabIndex = 15;
            signup_check.Text = "Show Password";
            signup_check.UseVisualStyleBackColor = true;
            signup_check.CheckedChanged += signup_check_CheckedChanged;
            // 
            // register_pass
            // 
            register_pass.BorderStyle = BorderStyle.FixedSingle;
            register_pass.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_pass.Location = new Point(273, 238);
            register_pass.Name = "register_pass";
            register_pass.PasswordChar = '*';
            register_pass.Size = new Size(203, 25);
            register_pass.TabIndex = 14;
            // 
            // register_name
            // 
            register_name.BorderStyle = BorderStyle.FixedSingle;
            register_name.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_name.Location = new Point(273, 162);
            register_name.Name = "register_name";
            register_name.Size = new Size(203, 25);
            register_name.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 216);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 140);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 11;
            label1.Text = "User Name";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(494, 0);
            exit.Name = "exit";
            exit.Size = new Size(24, 23);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 411);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(75, 8, 138);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(11, 362);
            button2.Name = "button2";
            button2.Size = new Size(223, 36);
            button2.TabIndex = 10;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(49, 329);
            label4.Name = "label4";
            label4.Size = new Size(137, 19);
            label4.TabIndex = 9;
            label4.Text = "Login Your Account";
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 411);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(signup_check);
            Controls.Add(register_pass);
            Controls.Add(register_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private CheckBox signup_check;
        private TextBox register_pass;
        private TextBox register_name;
        private Label label2;
        private Label label1;
        private Label exit;
        private Panel panel1;
        private Button button2;
        private Label label4;
        private Panel panel2;
    }
}