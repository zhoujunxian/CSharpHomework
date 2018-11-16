using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class AddOrderForm : Form
    {
        public string Number { get; set; }
        public string Name1 { get; set; }
        public string Buyer { get; set; }
        public double Cost { get; set; }
        public AddOrderForm()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "Number");
            textBox2.DataBindings.Add("Text", this, "Name1");
            textBox3.DataBindings.Add("Text", this, "Buyer");
            textBox4.DataBindings.Add("Text", this, "Cost");


        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder(Number, Name1, Buyer, Cost);
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
