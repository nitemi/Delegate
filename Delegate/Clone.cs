using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate bool eventdelegate(Event @event);
    public class Event
    {
        //Delegate

        public string Type { get; set; }
        public string Vendor { get; set; }
        public string Venue { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public static void CloneIt(List<Event> events, eventdelegate planning)
        {
            foreach (Event evn in events)
            {
                if (planning(evn))
                {
                    Console.WriteLine(evn.Venue + "------" + evn.Price + " " + "Medium Price Range");
                }
               // else
                //{
                //    Console.WriteLine("There is no price of that range");
                //}
            }
        }
            
    }
}
