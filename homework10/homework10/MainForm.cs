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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            OrderService orderService = new OrderService();
            

            InitializeComponent();
            orderBindingSource.DataSource = orderService.GetAllOrders();
            Order order = (Order)orderBindingSource.Current;
            orderItemBindingSource.DataSource = order.OrderItems;
            
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void queryOrder()
        {
            OrderService orderService = new OrderService();
            orderBindingSource.DataSource =
                orderService.GetOrder(textBox1.Text);
            if(orderBindingSource.DataSource==null)
            {
                orderBindingSource.DataSource = orderService.GetAllOrders();
                MessageBox.Show("没有找到订单！");
                //orderItemBindingSource.ResetBindings(false);
            }
            else
            {
                try
                {
                    orderItemBindingSource.DataSource =
                        orderService.GetOrder(textBox1.Text).OrderItems;
                }
                catch
                {
                    MessageBox.Show("没有找到订单！");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryOrder();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                OrderService orderService = new OrderService();
                Order order = (Order)orderBindingSource.Current;              
                orderService.Delete(order.Id);
                orderBindingSource.DataSource = orderService.GetAllOrders();               

            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
