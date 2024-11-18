using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Stock newStock = new Stock("ABCD");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newStock.PriceChanged += NotifyMe;
            button1.Click += Show;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal newPrice = Convert.ToDecimal(textBox1.Text);

            newStock.Price = newPrice;
        }
        private void Show(object sender, EventArgs e) {
            MessageBox.Show("Click event Subscriber");
        }

        void NotifyMe(decimal oldPrice, decimal newPrice)
        {
            if (oldPrice > newPrice) {
                MessageBox.Show("The old price is grater than the new price");
            } else {
                MessageBox.Show("The old price is smaller than the new price");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newStock.PriceChanged -= NotifyMe;
        }
    }
}
