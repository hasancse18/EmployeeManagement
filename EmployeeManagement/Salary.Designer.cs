namespace EmployeeManagement
{
    partial class Salary
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
            salary_emp_position = new ComboBox();
            salary_clear_btn = new Button();
            salary_update_btn = new Button();
            salary_data = new TextBox();
            label1 = new Label();
            label2 = new Label();
            salary_full_name = new TextBox();
            label5 = new Label();
            salary_emp_id = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(salary_emp_position);
            panel1.Controls.Add(salary_clear_btn);
            panel1.Controls.Add(salary_update_btn);
            panel1.Controls.Add(salary_data);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(salary_full_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_emp_id);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(22, 34);
            panel1.Margin = new Padding(5, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 458);
            panel1.TabIndex = 0;
            // 
            // salary_emp_position
            // 
            salary_emp_position.FormattingEnabled = true;
            salary_emp_position.Items.AddRange(new object[] { "Manager", "Engineer" });
            salary_emp_position.Location = new Point(36, 177);
            salary_emp_position.Name = "salary_emp_position";
            salary_emp_position.Size = new Size(138, 23);
            salary_emp_position.TabIndex = 18;
            // 
            // salary_clear_btn
            // 
            salary_clear_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_clear_btn.Cursor = Cursors.Hand;
            salary_clear_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            salary_clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salary_clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salary_clear_btn.FlatStyle = FlatStyle.Flat;
            salary_clear_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_clear_btn.ForeColor = SystemColors.ButtonHighlight;
            salary_clear_btn.Location = new Point(119, 342);
            salary_clear_btn.Name = "salary_clear_btn";
            salary_clear_btn.Size = new Size(100, 31);
            salary_clear_btn.TabIndex = 17;
            salary_clear_btn.Text = "Clear";
            salary_clear_btn.UseVisualStyleBackColor = false;
            salary_clear_btn.Click += salary_clear_btn_Click;
            // 
            // salary_update_btn
            // 
            salary_update_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_update_btn.Cursor = Cursors.Hand;
            salary_update_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            salary_update_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salary_update_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salary_update_btn.FlatStyle = FlatStyle.Flat;
            salary_update_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_update_btn.ForeColor = SystemColors.ButtonHighlight;
            salary_update_btn.Location = new Point(3, 342);
            salary_update_btn.Name = "salary_update_btn";
            salary_update_btn.Size = new Size(100, 31);
            salary_update_btn.TabIndex = 15;
            salary_update_btn.Text = "Update";
            salary_update_btn.UseVisualStyleBackColor = false;
            salary_update_btn.Click += salary_update_btn_Click;
            // 
            // salary_data
            // 
            salary_data.BorderStyle = BorderStyle.FixedSingle;
            salary_data.Location = new Point(36, 245);
            salary_data.Name = "salary_data";
            salary_data.Size = new Size(138, 23);
            salary_data.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 219);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 12;
            label1.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 151);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 10;
            label2.Text = "Position";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salary_full_name
            // 
            salary_full_name.BorderStyle = BorderStyle.FixedSingle;
            salary_full_name.Location = new Point(36, 111);
            salary_full_name.Name = "salary_full_name";
            salary_full_name.Size = new Size(138, 23);
            salary_full_name.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 85);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 8;
            label5.Text = "Full Name";
            label5.Click += label5_Click;
            // 
            // salary_emp_id
            // 
            salary_emp_id.BorderStyle = BorderStyle.FixedSingle;
            salary_emp_id.Location = new Point(36, 50);
            salary_emp_id.Name = "salary_emp_id";
            salary_emp_id.Size = new Size(138, 23);
            salary_emp_id.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 24);
            label3.Margin = new Padding(5, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 6;
            label3.Text = "Employee Id";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(265, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 458);
            panel2.TabIndex = 1;
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
            dataGridView1.Location = new Point(16, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(523, 388);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 3;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(859, 526);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox salary_full_name;
        private Label label5;
        private TextBox salary_emp_id;
        private Label label3;
        private TextBox salary_data;
        private Label label1;
        private Label label2;
        private Button salary_clear_btn;
        private Button salary_update_btn;
        private Label label4;
        private DataGridView dataGridView1;
        private ComboBox salary_emp_position;
    }
}
