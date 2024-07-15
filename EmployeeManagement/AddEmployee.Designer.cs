namespace EmployeeManagement
{
    partial class AddEmployee
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            employee_picture = new PictureBox();
            status = new ComboBox();
            label7 = new Label();
            emp_position = new ComboBox();
            label2 = new Label();
            emp_clear_btn = new Button();
            emp_delete_btn = new Button();
            emp_update_btn = new Button();
            emp_add_btn = new Button();
            button1 = new Button();
            employee_phone = new TextBox();
            label6 = new Label();
            employee_name = new TextBox();
            label5 = new Label();
            gender = new ComboBox();
            label4 = new Label();
            employee_id = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employee_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 218);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(16, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(740, 157);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(employee_picture);
            panel2.Controls.Add(status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(emp_position);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(emp_clear_btn);
            panel2.Controls.Add(emp_delete_btn);
            panel2.Controls.Add(emp_update_btn);
            panel2.Controls.Add(emp_add_btn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(employee_phone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(employee_name);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(employee_id);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(41, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 238);
            panel2.TabIndex = 1;
            // 
            // employee_picture
            // 
            employee_picture.BorderStyle = BorderStyle.FixedSingle;
            employee_picture.Location = new Point(656, 53);
            employee_picture.Name = "employee_picture";
            employee_picture.Size = new Size(100, 96);
            employee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            employee_picture.TabIndex = 18;
            employee_picture.TabStop = false;
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Active", "Absent" });
            status.Location = new Point(502, 126);
            status.Name = "status";
            status.Size = new Size(138, 23);
            status.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(363, 126);
            label7.Name = "label7";
            label7.Size = new Size(62, 23);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // emp_position
            // 
            emp_position.FormattingEnabled = true;
            emp_position.Items.AddRange(new object[] { "Manager", "Engineer" });
            emp_position.Location = new Point(502, 80);
            emp_position.Name = "emp_position";
            emp_position.Size = new Size(138, 23);
            emp_position.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 80);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 14;
            label2.Text = "Position";
            // 
            // emp_clear_btn
            // 
            emp_clear_btn.BackColor = Color.FromArgb(33, 11, 97);
            emp_clear_btn.Cursor = Cursors.Hand;
            emp_clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            emp_clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            emp_clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            emp_clear_btn.FlatStyle = FlatStyle.Flat;
            emp_clear_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_clear_btn.ForeColor = SystemColors.ButtonHighlight;
            emp_clear_btn.Location = new Point(528, 191);
            emp_clear_btn.Name = "emp_clear_btn";
            emp_clear_btn.Size = new Size(100, 31);
            emp_clear_btn.TabIndex = 13;
            emp_clear_btn.Text = "Clear";
            emp_clear_btn.UseVisualStyleBackColor = false;
            emp_clear_btn.Click += emp_clear_btn_Click;
            // 
            // emp_delete_btn
            // 
            emp_delete_btn.BackColor = Color.FromArgb(33, 11, 97);
            emp_delete_btn.Cursor = Cursors.Hand;
            emp_delete_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            emp_delete_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            emp_delete_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            emp_delete_btn.FlatStyle = FlatStyle.Flat;
            emp_delete_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_delete_btn.ForeColor = SystemColors.ButtonHighlight;
            emp_delete_btn.Location = new Point(399, 191);
            emp_delete_btn.Name = "emp_delete_btn";
            emp_delete_btn.Size = new Size(100, 31);
            emp_delete_btn.TabIndex = 12;
            emp_delete_btn.Text = "Delete";
            emp_delete_btn.UseVisualStyleBackColor = false;
            emp_delete_btn.Click += emp_delete_btn_Click;
            // 
            // emp_update_btn
            // 
            emp_update_btn.BackColor = Color.FromArgb(33, 11, 97);
            emp_update_btn.Cursor = Cursors.Hand;
            emp_update_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            emp_update_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            emp_update_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            emp_update_btn.FlatStyle = FlatStyle.Flat;
            emp_update_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_update_btn.ForeColor = SystemColors.ButtonHighlight;
            emp_update_btn.Location = new Point(278, 191);
            emp_update_btn.Name = "emp_update_btn";
            emp_update_btn.Size = new Size(100, 31);
            emp_update_btn.TabIndex = 11;
            emp_update_btn.Text = "Update";
            emp_update_btn.UseVisualStyleBackColor = false;
            emp_update_btn.Click += emp_update_btn_Click;
            // 
            // emp_add_btn
            // 
            emp_add_btn.BackColor = Color.FromArgb(33, 11, 97);
            emp_add_btn.Cursor = Cursors.Hand;
            emp_add_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            emp_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            emp_add_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            emp_add_btn.FlatStyle = FlatStyle.Flat;
            emp_add_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_add_btn.ForeColor = SystemColors.ButtonHighlight;
            emp_add_btn.Location = new Point(149, 191);
            emp_add_btn.Name = "emp_add_btn";
            emp_add_btn.Size = new Size(100, 31);
            emp_add_btn.TabIndex = 10;
            emp_add_btn.Text = "ADD";
            emp_add_btn.UseVisualStyleBackColor = false;
            emp_add_btn.Click += emp_add_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(656, 155);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 9;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // employee_phone
            // 
            employee_phone.BorderStyle = BorderStyle.FixedSingle;
            employee_phone.Location = new Point(502, 34);
            employee_phone.Name = "employee_phone";
            employee_phone.Size = new Size(138, 23);
            employee_phone.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(363, 34);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 6;
            label6.Text = "Phone Number";
            // 
            // employee_name
            // 
            employee_name.BorderStyle = BorderStyle.FixedSingle;
            employee_name.Location = new Point(187, 80);
            employee_name.Name = "employee_name";
            employee_name.Size = new Size(138, 23);
            employee_name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 80);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "First Name";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(187, 126);
            gender.Name = "gender";
            gender.Size = new Size(138, 23);
            gender.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 126);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 2;
            label4.Text = "Gender";
            // 
            // employee_id
            // 
            employee_id.BorderStyle = BorderStyle.FixedSingle;
            employee_id.Location = new Point(187, 34);
            employee_id.Name = "employee_id";
            employee_id.Size = new Size(138, 23);
            employee_id.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 34);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 0;
            label3.Text = "Employee Id";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(859, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employee_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox employee_id;
        private Label label3;
        private Label label4;
        private TextBox employee_phone;
        private Label label6;
        private TextBox employee_name;
        private Label label5;
        private ComboBox gender;
        private Button button1;
        private Button emp_clear_btn;
        private Button emp_delete_btn;
        private Button emp_update_btn;
        private Button emp_add_btn;
        private ComboBox emp_position;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox status;
        private Label label7;
        private PictureBox employee_picture;
    }
}
