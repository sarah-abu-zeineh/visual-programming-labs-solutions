using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = textBox1.Text == "" ? 
                "Deafult name" : textBox1.Text;
            string level = listBox1.SelectedItem != null ? 
                listBox1.SelectedItem.ToString(): "Graduated";
            string specialization = comboBox1.SelectedItem != null ?
                comboBox1.SelectedItem.ToString() : "CS";
            string gender = "";

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }


            string favSubjects = "";

;            foreach (object item in checkedListBox1.CheckedItems) {
                favSubjects += item.ToString() +"\n";
            }

            //gender = radioButton1.Checked ? radioButton1.Text : radioButton1.Text;

            string studentInfo = $"Student Name: {studentName}\n" +
                $"Level of Education: {level}\n" +
                $"specialization: {specialization}\n" +
                $"Gender: {gender}\n" +
                $"Favourite Subject:\n {favSubjects}";


            MessageBox.Show(studentInfo);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();
            form2.Show();
        }
    }
}
