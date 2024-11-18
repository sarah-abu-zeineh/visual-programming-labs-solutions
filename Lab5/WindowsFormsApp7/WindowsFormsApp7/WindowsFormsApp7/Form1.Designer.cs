
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
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.showAllInfoBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.personBox = new System.Windows.Forms.GroupBox();
            this.personYOB = new System.Windows.Forms.TextBox();
            this.YOB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.machineRadioButton = new System.Windows.Forms.RadioButton();
            this.personRadioButton = new System.Windows.Forms.RadioButton();
            this.machineBox = new System.Windows.Forms.GroupBox();
            this.showAllMachine = new System.Windows.Forms.Button();
            this.addMachine = new System.Windows.Forms.Button();
            this.machineYOP = new System.Windows.Forms.TextBox();
            this.machinePrice = new System.Windows.Forms.TextBox();
            this.machineId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countMachine = new System.Windows.Forms.Button();
            this.personBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.machineBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentRadioBtn
            // 
            this.StudentRadioBtn.AutoSize = true;
            this.StudentRadioBtn.Location = new System.Drawing.Point(22, 25);
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
            this.EmployeeRadioBtn.Location = new System.Drawing.Point(25, 55);
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
            this.IDLabel.Location = new System.Drawing.Point(142, 25);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 20);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "Id";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(142, 75);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // Mark1Label
            // 
            this.Mark1Label.AutoSize = true;
            this.Mark1Label.Location = new System.Drawing.Point(142, 157);
            this.Mark1Label.Name = "Mark1Label";
            this.Mark1Label.Size = new System.Drawing.Size(57, 20);
            this.Mark1Label.TabIndex = 5;
            this.Mark1Label.Text = "Mark 1";
            // 
            // Mark2Label
            // 
            this.Mark2Label.AutoSize = true;
            this.Mark2Label.Location = new System.Drawing.Point(143, 206);
            this.Mark2Label.Name = "Mark2Label";
            this.Mark2Label.Size = new System.Drawing.Size(57, 20);
            this.Mark2Label.TabIndex = 6;
            this.Mark2Label.Text = "Mark 2";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(143, 259);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(53, 20);
            this.SalaryLabel.TabIndex = 7;
            this.SalaryLabel.Text = "Salary";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Location = new System.Drawing.Point(208, 25);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.IDTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(208, 72);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.NameTextBox.TabIndex = 9;
            // 
            // Mark1TextBox
            // 
            this.Mark1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark1TextBox.Location = new System.Drawing.Point(208, 157);
            this.Mark1TextBox.Name = "Mark1TextBox";
            this.Mark1TextBox.Size = new System.Drawing.Size(200, 26);
            this.Mark1TextBox.TabIndex = 10;
            // 
            // Mark2TextBox
            // 
            this.Mark2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark2TextBox.Location = new System.Drawing.Point(208, 203);
            this.Mark2TextBox.Name = "Mark2TextBox";
            this.Mark2TextBox.Size = new System.Drawing.Size(200, 26);
            this.Mark2TextBox.TabIndex = 11;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTextBox.Location = new System.Drawing.Point(208, 259);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(200, 26);
            this.SalaryTextBox.TabIndex = 12;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(6, 282);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(129, 50);
            this.addStudentBtn.TabIndex = 14;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(144, 282);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(129, 50);
            this.addEmployeeBtn.TabIndex = 15;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // showAllInfoBtn
            // 
            this.showAllInfoBtn.Location = new System.Drawing.Point(147, 344);
            this.showAllInfoBtn.Name = "showAllInfoBtn";
            this.showAllInfoBtn.Size = new System.Drawing.Size(129, 50);
            this.showAllInfoBtn.TabIndex = 16;
            this.showAllInfoBtn.Text = "Show All Info";
            this.showAllInfoBtn.UseVisualStyleBackColor = true;
            this.showAllInfoBtn.Click += new System.EventHandler(this.showAllInfoBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(279, 282);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(129, 50);
            this.countBtn.TabIndex = 17;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // personBox
            // 
            this.personBox.Controls.Add(this.personYOB);
            this.personBox.Controls.Add(this.YOB);
            this.personBox.Controls.Add(this.StudentRadioBtn);
            this.personBox.Controls.Add(this.addStudentBtn);
            this.personBox.Controls.Add(this.showAllInfoBtn);
            this.personBox.Controls.Add(this.addEmployeeBtn);
            this.personBox.Controls.Add(this.countBtn);
            this.personBox.Controls.Add(this.EmployeeRadioBtn);
            this.personBox.Controls.Add(this.IDTextBox);
            this.personBox.Controls.Add(this.IDLabel);
            this.personBox.Controls.Add(this.NameLabel);
            this.personBox.Controls.Add(this.Mark1Label);
            this.personBox.Controls.Add(this.SalaryTextBox);
            this.personBox.Controls.Add(this.Mark2Label);
            this.personBox.Controls.Add(this.Mark2TextBox);
            this.personBox.Controls.Add(this.SalaryLabel);
            this.personBox.Controls.Add(this.Mark1TextBox);
            this.personBox.Controls.Add(this.NameTextBox);
            this.personBox.Location = new System.Drawing.Point(234, 12);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(420, 404);
            this.personBox.TabIndex = 18;
            this.personBox.TabStop = false;
            this.personBox.Text = "Person";
            // 
            // personYOB
            // 
            this.personYOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personYOB.Location = new System.Drawing.Point(208, 113);
            this.personYOB.Name = "personYOB";
            this.personYOB.Size = new System.Drawing.Size(200, 26);
            this.personYOB.TabIndex = 16;
            // 
            // YOB
            // 
            this.YOB.AutoSize = true;
            this.YOB.Location = new System.Drawing.Point(140, 115);
            this.YOB.Name = "YOB";
            this.YOB.Size = new System.Drawing.Size(43, 20);
            this.YOB.TabIndex = 15;
            this.YOB.Text = "YOB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.machineRadioButton);
            this.groupBox2.Controls.Add(this.personRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 98);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // machineRadioButton
            // 
            this.machineRadioButton.AutoSize = true;
            this.machineRadioButton.Location = new System.Drawing.Point(7, 70);
            this.machineRadioButton.Name = "machineRadioButton";
            this.machineRadioButton.Size = new System.Drawing.Size(94, 24);
            this.machineRadioButton.TabIndex = 1;
            this.machineRadioButton.TabStop = true;
            this.machineRadioButton.Text = "Machine";
            this.machineRadioButton.UseVisualStyleBackColor = true;
            this.machineRadioButton.CheckedChanged += new System.EventHandler(this.machineRadioButton_CheckedChanged);
            // 
            // personRadioButton
            // 
            this.personRadioButton.AutoSize = true;
            this.personRadioButton.Location = new System.Drawing.Point(7, 35);
            this.personRadioButton.Name = "personRadioButton";
            this.personRadioButton.Size = new System.Drawing.Size(84, 24);
            this.personRadioButton.TabIndex = 0;
            this.personRadioButton.TabStop = true;
            this.personRadioButton.Text = "Person";
            this.personRadioButton.UseVisualStyleBackColor = true;
            this.personRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // machineBox
            // 
            this.machineBox.Controls.Add(this.countMachine);
            this.machineBox.Controls.Add(this.showAllMachine);
            this.machineBox.Controls.Add(this.addMachine);
            this.machineBox.Controls.Add(this.machineYOP);
            this.machineBox.Controls.Add(this.machinePrice);
            this.machineBox.Controls.Add(this.machineId);
            this.machineBox.Controls.Add(this.label3);
            this.machineBox.Controls.Add(this.label2);
            this.machineBox.Controls.Add(this.label1);
            this.machineBox.Location = new System.Drawing.Point(442, 12);
            this.machineBox.Name = "machineBox";
            this.machineBox.Size = new System.Drawing.Size(338, 297);
            this.machineBox.TabIndex = 20;
            this.machineBox.TabStop = false;
            this.machineBox.Text = "Machine";
            // 
            // showAllMachine
            // 
            this.showAllMachine.Location = new System.Drawing.Point(176, 171);
            this.showAllMachine.Name = "showAllMachine";
            this.showAllMachine.Size = new System.Drawing.Size(144, 47);
            this.showAllMachine.TabIndex = 7;
            this.showAllMachine.Text = "Show Machines";
            this.showAllMachine.UseVisualStyleBackColor = true;
            this.showAllMachine.Click += new System.EventHandler(this.showAllMachine_Click);
            // 
            // addMachine
            // 
            this.addMachine.Location = new System.Drawing.Point(17, 171);
            this.addMachine.Name = "addMachine";
            this.addMachine.Size = new System.Drawing.Size(132, 45);
            this.addMachine.TabIndex = 6;
            this.addMachine.Text = "Add Machine";
            this.addMachine.UseVisualStyleBackColor = true;
            this.addMachine.Click += new System.EventHandler(this.addMachine_Click);
            // 
            // machineYOP
            // 
            this.machineYOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineYOP.Location = new System.Drawing.Point(80, 104);
            this.machineYOP.Name = "machineYOP";
            this.machineYOP.Size = new System.Drawing.Size(167, 26);
            this.machineYOP.TabIndex = 5;
            // 
            // machinePrice
            // 
            this.machinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machinePrice.Location = new System.Drawing.Point(80, 72);
            this.machinePrice.Name = "machinePrice";
            this.machinePrice.Size = new System.Drawing.Size(167, 26);
            this.machinePrice.TabIndex = 4;
            // 
            // machineId
            // 
            this.machineId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineId.Location = new System.Drawing.Point(80, 34);
            this.machineId.Name = "machineId";
            this.machineId.Size = new System.Drawing.Size(167, 26);
            this.machineId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "YOP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // countMachine
            // 
            this.countMachine.Location = new System.Drawing.Point(103, 231);
            this.countMachine.Name = "countMachine";
            this.countMachine.Size = new System.Drawing.Size(132, 45);
            this.countMachine.TabIndex = 8;
            this.countMachine.Text = "Count Machines";
            this.countMachine.UseVisualStyleBackColor = true;
            this.countMachine.Click += new System.EventHandler(this.countMachine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.machineBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.personBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.personBox.ResumeLayout(false);
            this.personBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.machineBox.ResumeLayout(false);
            this.machineBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button showAllInfoBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.GroupBox personBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton machineRadioButton;
        private System.Windows.Forms.RadioButton personRadioButton;
        private System.Windows.Forms.GroupBox machineBox;
        private System.Windows.Forms.TextBox machineYOP;
        private System.Windows.Forms.TextBox machinePrice;
        private System.Windows.Forms.TextBox machineId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personYOB;
        private System.Windows.Forms.Label YOB;
        private System.Windows.Forms.Button showAllMachine;
        private System.Windows.Forms.Button addMachine;
        private System.Windows.Forms.Button countMachine;
    }
}

