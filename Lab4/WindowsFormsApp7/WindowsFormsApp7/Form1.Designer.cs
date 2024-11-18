
namespace WindowsFormsApp7
{
    partial class Form1
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
            this.PersonRadioBtn = new System.Windows.Forms.RadioButton();
            this.StudentRadioBtn = new System.Windows.Forms.RadioButton();
            this.EmployeeRadioBtn = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Mark1Label = new System.Windows.Forms.Label();
            this.Mark2Label = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Mark1TextBox = new System.Windows.Forms.TextBox();
            this.Mark2TextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.showAllInfoBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonRadioBtn
            // 
            this.PersonRadioBtn.AutoSize = true;
            this.PersonRadioBtn.Location = new System.Drawing.Point(46, 28);
            this.PersonRadioBtn.Name = "PersonRadioBtn";
            this.PersonRadioBtn.Size = new System.Drawing.Size(84, 24);
            this.PersonRadioBtn.TabIndex = 0;
            this.PersonRadioBtn.TabStop = true;
            this.PersonRadioBtn.Text = "Person";
            this.PersonRadioBtn.UseVisualStyleBackColor = true;
            this.PersonRadioBtn.CheckedChanged += new System.EventHandler(this.PersonRadioBtn_CheckedChanged);
            // 
            // StudentRadioBtn
            // 
            this.StudentRadioBtn.AutoSize = true;
            this.StudentRadioBtn.Location = new System.Drawing.Point(46, 87);
            this.StudentRadioBtn.Name = "StudentRadioBtn";
            this.StudentRadioBtn.Size = new System.Drawing.Size(95, 24);
            this.StudentRadioBtn.TabIndex = 1;
            this.StudentRadioBtn.TabStop = true;
            this.StudentRadioBtn.Text = "Student ";
            this.StudentRadioBtn.UseVisualStyleBackColor = true;
            this.StudentRadioBtn.CheckedChanged += new System.EventHandler(this.StudentRadioBtn_CheckedChanged);
            // 
            // EmployeeRadioBtn
            // 
            this.EmployeeRadioBtn.AutoSize = true;
            this.EmployeeRadioBtn.Location = new System.Drawing.Point(46, 139);
            this.EmployeeRadioBtn.Name = "EmployeeRadioBtn";
            this.EmployeeRadioBtn.Size = new System.Drawing.Size(104, 24);
            this.EmployeeRadioBtn.TabIndex = 2;
            this.EmployeeRadioBtn.TabStop = true;
            this.EmployeeRadioBtn.Text = "Employee";
            this.EmployeeRadioBtn.UseVisualStyleBackColor = true;
            this.EmployeeRadioBtn.CheckedChanged += new System.EventHandler(this.EmployeeRadioBtn_CheckedChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(310, 28);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 20);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "Id";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(310, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // Mark1Label
            // 
            this.Mark1Label.AutoSize = true;
            this.Mark1Label.Location = new System.Drawing.Point(310, 128);
            this.Mark1Label.Name = "Mark1Label";
            this.Mark1Label.Size = new System.Drawing.Size(57, 20);
            this.Mark1Label.TabIndex = 5;
            this.Mark1Label.Text = "Mark 1";
            // 
            // Mark2Label
            // 
            this.Mark2Label.AutoSize = true;
            this.Mark2Label.Location = new System.Drawing.Point(311, 177);
            this.Mark2Label.Name = "Mark2Label";
            this.Mark2Label.Size = new System.Drawing.Size(57, 20);
            this.Mark2Label.TabIndex = 6;
            this.Mark2Label.Text = "Mark 2";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(311, 230);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(53, 20);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Salary";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(417, 28);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.IDTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(417, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.NameTextBox.TabIndex = 9;
            // 
            // Mark1TextBox
            // 
            this.Mark1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark1TextBox.Location = new System.Drawing.Point(417, 128);
            this.Mark1TextBox.Name = "Mark1TextBox";
            this.Mark1TextBox.Size = new System.Drawing.Size(200, 26);
            this.Mark1TextBox.TabIndex = 10;
            // 
            // Mark2TextBox
            // 
            this.Mark2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark2TextBox.Location = new System.Drawing.Point(417, 174);
            this.Mark2TextBox.Name = "Mark2TextBox";
            this.Mark2TextBox.Size = new System.Drawing.Size(200, 26);
            this.Mark2TextBox.TabIndex = 11;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTextBox.Location = new System.Drawing.Point(417, 230);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(200, 26);
            this.SalaryTextBox.TabIndex = 12;
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(12, 330);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(129, 50);
            this.addPersonBtn.TabIndex = 13;
            this.addPersonBtn.Text = "Add Person";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(163, 330);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(129, 50);
            this.addStudentBtn.TabIndex = 14;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(315, 330);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(129, 50);
            this.addEmployeeBtn.TabIndex = 15;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // showAllInfoBtn
            // 
            this.showAllInfoBtn.Location = new System.Drawing.Point(468, 330);
            this.showAllInfoBtn.Name = "showAllInfoBtn";
            this.showAllInfoBtn.Size = new System.Drawing.Size(129, 50);
            this.showAllInfoBtn.TabIndex = 16;
            this.showAllInfoBtn.Text = "Show All Info";
            this.showAllInfoBtn.UseVisualStyleBackColor = true;
            this.showAllInfoBtn.Click += new System.EventHandler(this.showAllInfoBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(623, 330);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(129, 50);
            this.countBtn.TabIndex = 17;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.showAllInfoBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.addPersonBtn);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.Mark2TextBox);
            this.Controls.Add(this.Mark1TextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.Mark2Label);
            this.Controls.Add(this.Mark1Label);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.EmployeeRadioBtn);
            this.Controls.Add(this.StudentRadioBtn);
            this.Controls.Add(this.PersonRadioBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PersonRadioBtn;
        private System.Windows.Forms.RadioButton StudentRadioBtn;
        private System.Windows.Forms.RadioButton EmployeeRadioBtn;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Mark1Label;
        private System.Windows.Forms.Label Mark2Label;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox Mark1TextBox;
        private System.Windows.Forms.TextBox Mark2TextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button showAllInfoBtn;
        private System.Windows.Forms.Button countBtn;
    }
}

