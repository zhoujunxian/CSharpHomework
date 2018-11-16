using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Xsl;

namespace homework8
{
    public partial class MainForm : Form
    {
        public string KeyWord { get; set; }
        public MainForm()
        {
            InitializeComponent();
            OrderService ojb = new OrderService();
            ojb.AddOrder("20171226321", "篮球", "李明", 2000,"18932685436");
            ojb.AddOrder("20181026383", "排球", "小明", 8000,"13795403642");
            ojb.AddOrder("20170220333", "足球", "小李", 12000,"18136823947");
            orderBindingSource.DataSource = Order.orders;
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Order.orders.Where(s => s.Number == KeyWord);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new AddOrderForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new DelectOrderForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new ChangeOrderForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Order.orders;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            Order order = Order.orders[0];
            OrderService.XmlSerialize(xmlser, "program.xml", order);
            XslCompiledTransform trans = new XslCompiledTransform();
            trans.Load(@"../../../program.xsl");
            trans.Transform("program.xml", "program.html");
        }
    }
}
