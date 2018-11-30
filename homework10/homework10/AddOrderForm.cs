using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework10
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService orderService = new OrderService();
                List<OrderItem> items = new List<OrderItem>() {
                new OrderItem(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), int.Parse(textBox4.Text))};
               
                Order order = new Order(textBox9.Text, textBox5.Text, items);
                orderService.Add(order);
                MessageBox.Show("订单添加成功！");
           
            }
            catch
            {
                MessageBox.Show("请正确输入订单信息信息！");
            }
        }
    }
}
