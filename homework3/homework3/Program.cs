using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    interface Chart
    {
         void display();
    }
    class Triangle : Chart
    {
        double bottom, height, area;
        public Triangle()
        {
            this.bottom = 5.6;
            this.height = 7.8;
            this.area = bottom * height/2;
        }
        public void display()
        {
            Console.WriteLine("三角形的面积是："+this.area);
        }
    }

    class Circular:Chart
    {
        double radius, area;
        public Circular()
        {
            this.radius = 6.8;
            this.area = 3.14 * radius * radius;
        }
        public void display()
        {
            Console.WriteLine("圆形的面积是："+this.area);
        }
    }

    class Square: Chart
    {
        double borderLength, area;
        public Square()
        {
            this.borderLength = 5.3;
            this.area = borderLength * borderLength;
        }
        public void display()
        {
            Console.WriteLine("正方形的面积是："+ this.area);
        }
    }

    class Rectangle:Chart
    {
        double length, width, area;
        public Rectangle()
        {
            this.length = 8.3;
            this.width = 5.2;
            this.area = length * width;
        }
        public void display()
        {
            Console.WriteLine("长方形的面积是："+this.area);
        }
    }
    class  ChartFactory
    {
        public static  Chart getChart(string type)
        {
            Chart chart = null;
            if(type.Equals("Triangle"))
            {
                chart = new Triangle();
            }
            else if(type.Equals("Circular"))
            {
                chart = new Circular();
            }
            else if (type.Equals("Square"))
            {
                chart = new Square();
            }
            else if (type.Equals("Rectangle"))
            {
                chart = new Rectangle();
            }
            return chart;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chart chart1 = ChartFactory.getChart("Triangle");
            chart1.display();
            Chart chart2 = ChartFactory.getChart("Circular");
            chart2.display();
            Chart chart3 = ChartFactory.getChart("Square");
            chart3.display();
            Chart chart4 = ChartFactory.getChart("Rectangle");
            chart4.display();
        }
    }
}
