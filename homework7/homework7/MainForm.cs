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
    
    public partial class MainForm : Form
    {
        public string KeyWord { get; set; }
        public MainForm()
        {
            InitializeComponent();
            OrderService ojb = new OrderService();
            ojb.AddOrder("20171226321","篮球","李明",2000);
            ojb.AddOrder("20181026383", "排球", "小明", 8000);
            ojb.AddOrder("20170220333", "足球", "小李", 12000);
            orderBindingSource.DataSource = Order.orders;
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddOrderForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new DelectOrderForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new ChangeOrderForm();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Order.orders.Where(s => s.Number == KeyWord);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Order.orders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
