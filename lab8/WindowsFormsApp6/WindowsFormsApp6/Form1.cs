using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        List<string> colorList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorList.Count() == 0) {
                colorList.Add("Red");
                colorList.Add("Green");
                colorList.Add("Blue");

                colorsListBox.DataSource = colorList;

            }
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string newColor = inputColor.Text;

            if (newColor != "")
            {
                colorList.Add(newColor);

                colorsListBox.DataSource = null;
                colorsListBox.DataSource = colorList;
            }
            else {
                MessageBox.Show("You Should Enter A Text");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = colorsListBox.SelectedIndex;
            colorList.RemoveAt(selectedIndex);


            MessageBox.Show(selectedIndex.ToString());

            colorsListBox.DataSource = null;
            colorsListBox.DataSource = colorList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorList.Reverse();
            colorsListBox.DataSource = null;
            colorsListBox.DataSource = colorList;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colorList.First());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorsListBox.DataSource = null;
            colorsListBox.DataSource = colorList.OrderBy(element => element).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colorList.Last());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchedText = inputColor.Text.ToLower();
            List<string> matchingItem = colorList.Where(item => item.ToLower().Contains(searchedText)).ToList();


            if (matchingItem.Any()) {

                foreach (string color in matchingItem) {
                    MessageBox.Show(color);
                }
            } else
            {
                MessageBox.Show($"Color {matchingItem} was not Found");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colorList.Count().ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> upperCaseList = colorList.Select(color => color.ToLower()).ToList();

            colorsListBox.DataSource = null;
            colorsListBox.DataSource = upperCaseList;
        }
    }
}
