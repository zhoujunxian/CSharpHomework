using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace homework10
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            OrderService orderService = new OrderService();
            

            List<OrderItem> items1 = new List<OrderItem>() {
                new OrderItem("1", "basketball", 80, 2),
                new OrderItem("2", "tennis", 5, 20)
            };
            
            

            Order order1 = new Order("001", "小明", items1);

            

            List<OrderItem> items2 = new List<OrderItem>() {
                new OrderItem("3", "volleyball", 50, 2),
                new OrderItem("4", "football", 100, 5)
            };
            
            Order order2 = new Order("002", "小李", items2);
            
            

            
            orderService.Add(order1);
            orderService.Add(order2);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
