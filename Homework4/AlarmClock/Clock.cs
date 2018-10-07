using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Media;
namespace AlarmClock
{
    class Clock
    {       
        public TimeSpan myTimeSpan;
        DateTime targetime;
        
        public Clock()
        {            
            try
            {
                Console.WriteLine("Please set a Duration and start counting: ");
                Console.WriteLine("The format of time should be like (hours:minutes:seconds)or(days:hours:minutes:seconds)");
                myTimeSpan = TimeSpan.Parse(Console.ReadLine());
                Console.WriteLine($"your alarmclock has been set to alarm after: {myTimeSpan.Days} days,{myTimeSpan.Hours}hours, {myTimeSpan.Minutes}minutes and {myTimeSpan.Seconds}seconds");
                System.DateTime current = System.DateTime.Now;
                targetime = current + myTimeSpan;
                while(true)
                {
                    if (DateTime.Now.CompareTo(targetime) >= 0)
                    {
                        Console.WriteLine("This is " + DateTime.Now + " now.");
                        Console.Beep(1000, 5000);                      
                        break;
                    }
                }                
            }
            catch
            { Console.WriteLine("Invaild input ,please input the correct format!"); }
        }
    }
}
