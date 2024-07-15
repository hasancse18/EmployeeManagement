namespace EmployeeManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            exit = new Label();
            panel2 = new Panel();
            label2 = new Label();
            logout_btn = new Button();
            salary_btn = new Button();
            addEmployee_btn = new Button();
            dashboard_btn = new Button();
            greet_btn = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 35);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(1055, 0);
            exit.Name = "exit";
            exit.Size = new Size(24, 23);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 8, 138);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(addEmployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(greet_btn);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 526);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(65, 484);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 2;
            label2.Text = "Sign Out";
            // 
            // logout_btn
            // 
            logout_btn.BackgroundImageLayout = ImageLayout.None;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.Black;
            logout_btn.Image = Properties.Resources.icons8_logout_rounded_up_filled_25px;
            logout_btn.Location = new Point(12, 474);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(47, 40);
            logout_btn.TabIndex = 2;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.FlatStyle = FlatStyle.Flat;
            salary_btn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salary_btn.ForeColor = Color.White;
            salary_btn.Image = Properties.Resources.icons8_Salary_male_30px;
            salary_btn.ImageAlign = ContentAlignment.MiddleLeft;
            salary_btn.Location = new Point(12, 333);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(195, 37);
            salary_btn.TabIndex = 11;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salary_btn_Click;
            // 
            // addEmployee_btn
            // 
            addEmployee_btn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_btn.Cursor = Cursors.Hand;
            addEmployee_btn.FlatStyle = FlatStyle.Flat;
            addEmployee_btn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addEmployee_btn.ForeColor = Color.White;
            addEmployee_btn.Image = (Image)resources.GetObject("addEmployee_btn.Image");
            addEmployee_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployee_btn.Location = new Point(12, 275);
            addEmployee_btn.Name = "addEmployee_btn";
            addEmployee_btn.Size = new Size(195, 39);
            addEmployee_btn.TabIndex = 10;
            addEmployee_btn.Text = "  ADD EMPLOYEE";
            addEmployee_btn.UseVisualStyleBackColor = false;
            addEmployee_btn.Click += addEmployee_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(33, 11, 97);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = Properties.Resources.icons8_dashboard_30px;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 217);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(195, 37);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // greet_btn
            // 
            greet_btn.AutoSize = true;
            greet_btn.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greet_btn.ForeColor = SystemColors.ButtonHighlight;
            greet_btn.Location = new Point(30, 152);
            greet_btn.Name = "greet_btn";
            greet_btn.Size = new Size(147, 23);
            greet_btn.TabIndex = 2;
            greet_btn.Text = "Welcome User";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.icons8_employee_card_100px;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(54, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(102, 96);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dashboard1);
            panel4.Controls.Add(addEmployee1);
            panel4.Controls.Add(salary1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(225, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(859, 526);
            panel4.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(-1, -1);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(859, 526);
            dashboard1.TabIndex = 3;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(-1, -1);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(859, 526);
            addEmployee1.TabIndex = 3;
            // 
            // salary1
            // 
            salary1.Location = new Point(-1, -1);
            salary1.Name = "salary1";
            salary1.Size = new Size(859, 526);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Panel panel2;
        private Button dashboard_btn;
        private Label greet_btn;
        private Panel panel3;
        private Button logout_btn;
        private Button salary_btn;
        private Button addEmployee_btn;
        private Label label2;
        private Panel panel4;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}