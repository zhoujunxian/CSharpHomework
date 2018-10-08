using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    public class ClockEventArgs : EventArgs
    {
        public int year;
        public int month;
        public int day;
        public int hour;
        public int minute;
        public int second;
        
        public ClockEventArgs(int year,int month,int day,int hour, int minute,int second)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public int Year
        {
            get
            { return year; }
            set
            {
                if (value > 2017)
                    year = value;
                else
                    throw new ArgumentOutOfRangeException("Year error");

            }
        }
        public int Month
        {
            get
            { return month; }
            set
            {
                if (value > 0 && value <13)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Month error");

            }
        }
        public int Day
        {
            get
            { return day; }
            set
            {
                if (value > 0 && value < 32)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Day error");

            }
        }
        public int Hour
        {
            get
            { return hour; }
            set
            {
                if (value >= 0 && value <=23)
                    hour = value;
                else
                    throw new ArgumentOutOfRangeException("Hour error");

            }
        }
        public int Minute
        {
            get
            { return minute;}
            set
            {
                if (value >= 0 && value <= 59)
                    minute = value;
                else
                    throw new ArgumentOutOfRangeException("Minute error");

            }
        }
        public int Second
        {
            get
            {return second; }
            set
            {
                if (value >= 0 && value <= 59)
                    second = value;
                else
                    throw new ArgumentOutOfRangeException("Second error");

            }
        }
    }

    public delegate void ClockEventHandler(object sender, ClockEventArgs e);

    public class Clock
    {
        public event ClockEventHandler ClockRemind;
        public void ClockOn(ClockEventArgs args)
        {
            DateTime settime = new DateTime(args.year, args.month,args.day, args.hour, args.minute, args.second);
            if (ClockRemind != null)
            {
                int n = 0;
                while(true)
                {
                    DateTime today = DateTime.Now;
                    while (today > settime)
                    {
                        n++;
                        if(n==1)
                        {
                            break;
                        }
                    }
                    if(n==1)
                    {
                        break;
                    }
                }
                ClockRemind(this, args);
            }    
        }
        
    }

    public class UseClock
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.ClockRemind += ClockRemindFun;
            ClockEventArgs obj = new ClockEventArgs(2018, 10, 7, 10, 10,10);//设置闹钟时间
            clock.ClockOn(obj);
        }


        static void ClockRemindFun(object sender, ClockEventArgs e)
        {
            Console.WriteLine("闹钟时间到！");
        }
    }
    
}
