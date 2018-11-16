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
    public partial class ChangeOrderForm : Form
    {
        public string OldNumber { get; set; }
        public string OldName1 { get; set; }
        public string OldBuyer { get; set; }
        public string NewNumber { get; set; }
        public string NewName1 { get; set; }
        public string NewBuyer { get; set; }
        public ChangeOrderForm()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "OldNumber");
            textBox2.DataBindings.Add("Text", this, "OldName1");
            textBox3.DataBindings.Add("Text", this, "OldBuyer");
            textBox4.DataBindings.Add("Text", this, "NewNumber");
            textBox5.DataBindings.Add("Text", this, "NewName1");
            textBox6.DataBindings.Add("Text", this, "NewBuyer");
        }

        private void ChangeOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            bool flag = ojb.ChangeOrderByNum(OldNumber, NewNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            bool flag = ojb.ChangeOrderByName(OldName1, NewName1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            bool flag = ojb.ChangeOrderByBuyer(OldBuyer, NewBuyer);

        }
    }
}
