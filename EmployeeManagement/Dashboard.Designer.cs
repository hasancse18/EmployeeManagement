namespace EmployeeManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            dash_board_IE = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            dash_board_AE = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            dash_board_TE = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 158);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(dash_board_IE);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(567, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(194, 100);
            panel5.TabIndex = 2;
            // 
            // dash_board_IE
            // 
            dash_board_IE.AutoSize = true;
            dash_board_IE.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dash_board_IE.ForeColor = SystemColors.ButtonHighlight;
            dash_board_IE.Location = new Point(174, 0);
            dash_board_IE.Name = "dash_board_IE";
            dash_board_IE.Size = new Size(20, 23);
            dash_board_IE.TabIndex = 4;
            dash_board_IE.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(75, 8, 138);
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(69, 71);
            label6.Name = "label6";
            label6.Size = new Size(125, 16);
            label6.TabIndex = 5;
            label6.Text = "Inactive Employee";
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 66);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(dash_board_AE);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(309, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 100);
            panel4.TabIndex = 1;
            // 
            // dash_board_AE
            // 
            dash_board_AE.AutoSize = true;
            dash_board_AE.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dash_board_AE.ForeColor = SystemColors.ButtonHighlight;
            dash_board_AE.Location = new Point(174, 0);
            dash_board_AE.Name = "dash_board_AE";
            dash_board_AE.Size = new Size(20, 23);
            dash_board_AE.TabIndex = 5;
            dash_board_AE.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(75, 8, 138);
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(77, 69);
            label4.Name = "label4";
            label4.Size = new Size(114, 16);
            label4.TabIndex = 6;
            label4.Text = "Active Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 66);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 8, 138);
            panel2.Controls.Add(dash_board_TE);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(46, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 100);
            panel2.TabIndex = 0;
            // 
            // dash_board_TE
            // 
            dash_board_TE.AutoSize = true;
            dash_board_TE.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dash_board_TE.ForeColor = SystemColors.ButtonHighlight;
            dash_board_TE.Location = new Point(174, 0);
            dash_board_TE.Name = "dash_board_TE";
            dash_board_TE.Size = new Size(20, 23);
            dash_board_TE.TabIndex = 3;
            dash_board_TE.Text = "0";
            dash_board_TE.Click += dash_board_TE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(75, 8, 138);
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(85, 69);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 3;
            label1.Text = "Total Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_employee_card_60px_1;
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 66);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(16, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(823, 302);
            panel3.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(859, 526);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label dash_board_IE;
        private Label label6;
        private Label dash_board_AE;
        private Label label4;
        private Label dash_board_TE;
        private Label label1;
    }
}
