using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int Id = Convert.ToInt32(IDTextBox.Text);
            int Id = int.Parse(IDTextBox.Text);
            string personName = NameTextBox.Text;

            Person newPerson = new Person() {ID = Id , Name = personName};

            persons.Add(newPerson);
            MessageBox.Show("Person Added Successfully");


            NameTextBox.Clear();
            IDTextBox.Clear();
        }

        private void PersonRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonRadioBtn.Checked)
            {
                Mark1Label.Visible = false;
                Mark2Label.Visible = false;
                SalaryLabel.Visible = false;

                Mark1TextBox.Visible = false;
                Mark2TextBox.Visible = false;
                SalaryTextBox.Visible = false;

                addPersonBtn.Enabled = true;
                addEmployeeBtn.Enabled = false;
                addStudentBtn.Enabled = false;
            }
            else {
                addPersonBtn.Enabled = false;
            }
        }

        private void StudentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentRadioBtn.Checked)
            {
                Mark1Label.Visible = true;
                Mark2Label.Visible = true;

                Mark1TextBox.Visible = true;
                Mark2TextBox.Visible = true;

                addStudentBtn.Enabled = true;
            }
            else {
                Mark1Label.Visible = false;
                Mark2Label.Visible = false;

                Mark1TextBox.Visible = false;
                Mark2TextBox.Visible = false;

                addStudentBtn.Enabled = false;
            }

        }

        private void EmployeeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EmployeeRadioBtn.Checked)
            {
                SalaryLabel.Visible = true;
                SalaryTextBox.Visible = true;

                SalaryLabel.Location = Mark1Label.Location;
                SalaryTextBox.Location = Mark1TextBox.Location;

                addEmployeeBtn.Enabled = true;
            }
            else {
                SalaryLabel.Visible = false;
                SalaryTextBox.Visible = false;

                addEmployeeBtn.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IDTextBox.Text);
            string studentName = NameTextBox.Text;
            int mark1 = int.Parse(Mark1TextBox.Text);
            int mark2 = Convert.ToInt16(Mark2TextBox.Text);

            Student newStudent = new Student() {ID = Id, Name = studentName, Mark1 = mark1, Mark2 = mark2 };

            persons.Add(newStudent);

            MessageBox.Show("Student Added Successfully");

            NameTextBox.Clear();
            IDTextBox.Clear();
            Mark1TextBox.Clear();
            Mark2TextBox.Clear();
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IDTextBox.Text);
            string employeeName = NameTextBox.Text;
            int salary = Convert.ToInt32(SalaryTextBox.Text);

            Employee newEmployee = new Employee() { ID = Id, Name = employeeName, Salary = salary };

            persons.Add(newEmployee);

            MessageBox.Show("Employee Added Successfully");

            NameTextBox.Clear();
            IDTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void showAllInfoBtn_Click(object sender, EventArgs e)
        {
            if(persons.Count() == 0) {
                MessageBox.Show("Their is No Persons");
            }

            foreach (Person person in persons) {
                MessageBox.Show(person.GetInfo());
            }
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            string personsCount = persons.Count().ToString();

            if (Convert.ToInt32(personsCount) == 0)
            {
                MessageBox.Show("There is No Persons in the Comany");
            }
            else
            {
                MessageBox.Show($"The Total Persons in the Company equals to {personsCount}");
            }


/*            string resutl = persons.Count() != 0 ? 
                $"The Total Persons in the Company equals to {Convert.ToInt32(personsCount)}"
                :"There is No Persons in the Comany";

            MessageBox.Show(resutl);*/
        }
    }
}
