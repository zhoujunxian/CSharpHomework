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
    
    public partial class DelectOrderForm : Form
    {
        public string Number { get; set; }
        public string Name1 { get; set; }
        public string Buyer { get; set; }
        
        public DelectOrderForm()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", this, "Number");
            textBox2.DataBindings.Add("Text", this, "Name1");
            textBox3.DataBindings.Add("Text", this, "Buyer");
            

        }

        private void DelectOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            ojb.DelectOrderByNum(Number);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            ojb.DelectOrderByName(Name1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderService ojb = new OrderService();
            ojb.DelectOrderByBuyer(Buyer);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DelectOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "DelectOrderForm";
            this.Load += new System.EventHandler(this.DelectOrderForm_Load_1);
            this.ResumeLayout(false);

        }

        private void DelectOrderForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
