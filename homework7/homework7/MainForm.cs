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
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            orderBindingSource.DataSource = Order.orders;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource =
                Order.orders.Where(s => s.Number == KeyWord);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Order.orders;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form form = new AddOrderForm();
            form.TopMost = true;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new DelectOrderForm();
            form.TopMost = true;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new ChangeOrderForm();
            form.TopMost = true;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
