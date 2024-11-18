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
        List<AgeInterface> objects = new List<AgeInterface>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int Id = Convert.ToInt32(IDTextBox.Text);
          /*  int Id = int.Parse(IDTextBox.Text);
            string personName = NameTextBox.Text;

            Person newPerson = new Person() {ID = Id , Name = personName};

            persons.Add(newPerson);
            MessageBox.Show("Person Added Successfully");


            NameTextBox.Clear();
            IDTextBox.Clear();*/
        }

        private void PersonRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           /* if (PersonRadioBtn.Checked)
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
            }*/
        }

        private void StudentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentRadioBtn.Checked)
            {
                Mark1Label.Visible = true;
                Mark2Label.Visible = true;
                SalaryLabel.Visible = false;

                Mark1TextBox.Visible = true;
                Mark2TextBox.Visible = true;
                SalaryTextBox.Visible = false;

                addStudentBtn.Enabled = true;
                addEmployeeBtn.Enabled = false;
                
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
            int yob = Convert.ToInt32(personYOB.Text);

            Student newStudent = new Student()
            {ID = Id, Name = studentName, Mark1 = mark1, Mark2 = mark2 , YearOfBirth= yob};

            objects.Add(newStudent);

            MessageBox.Show("Student Added Successfully");

            NameTextBox.Clear();
            IDTextBox.Clear();
            Mark1TextBox.Clear();
            Mark2TextBox.Clear();
            personYOB.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IDTextBox.Text);
            string employeeName = NameTextBox.Text;
            int salary = Convert.ToInt32(SalaryTextBox.Text);
            int yob = Convert.ToInt32(personYOB.Text);

            Employee newEmployee = new Employee() 
            { ID = Id, Name = employeeName, Salary = salary, YearOfBirth = yob };

            objects.Add(newEmployee);

            MessageBox.Show("Employee Added Successfully");

            NameTextBox.Clear();
            IDTextBox.Clear();
            SalaryTextBox.Clear();
            personYOB.Clear();

        }

        private void showAllInfoBtn_Click(object sender, EventArgs e)
        {
            if(objects.Count() == 0) {
                MessageBox.Show("Their is No Persons");
            }

            foreach (AgeInterface obj in objects)
            {
                if (obj is Employee)
                {
                    MessageBox.Show(((Employee)obj).GetInfo());
                }
                else if (obj is Student student) {
                    MessageBox.Show(student.GetInfo());
                }
            }
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            string personsCount = objects.Count().ToString();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            personRadioButton.Checked = true;
            StudentRadioBtn.Checked = true;
            showAllMachine.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            machineBox.Visible = !personRadioButton.Checked;
            personBox.Visible = personRadioButton.Checked;

        }

        private void machineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (machineRadioButton.Checked) {
                machineBox.Location = personBox.Location;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addMachine_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(machineId.Text);
            float price = float.Parse(machinePrice.Text);
            int yop = int.Parse(machineYOP.Text);

            Machine newMachine = new Machine()
                {ID = id, Price = price, YearOfProduction = yop };

            objects.Add(newMachine);

            MessageBox.Show("Machine Added Successfully");

            machineId.Clear();
            machinePrice.Clear();
            machineYOP.Clear();

            showAllMachine.Enabled = true;
                        
        }

        int CheckMachinesNumber() {
            int cnt = 0;

            foreach (AgeInterface obj in objects)
            {
                if (obj is Machine machine)
                {
                    cnt++;
                }
            }

            return cnt;
        }

        private void showAllMachine_Click(object sender, EventArgs e)
        {
            foreach (AgeInterface obj in objects)
            {
                if (obj is Machine machine)
                {
                    string machineData = $"Machine\n" +
                        $"ID -> {machine.ID}\n" +
                        $"Price -> {machine.Price}\n" +
                        $"Year of Production -> {machine.YearOfProduction}\n" +
                        $"Machine Age -> {machine.CalcAge()}\n" +
                        $"Final Price -> {machine.CalcFinalPrice()}";

                    MessageBox.Show(machineData);
                }
            }
        }

        private void countMachine_Click(object sender, EventArgs e)
        {
            int cnt = CheckMachinesNumber();

            MessageBox.Show($"Machine Number Equals {cnt}");
        }
    }
}
