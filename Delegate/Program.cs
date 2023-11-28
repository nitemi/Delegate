using Delegate;

//public delegate void Delegateoutput(string args);//a field created outside the class, its like a class on it on(it is void because the method it is pointing to is also a void
                                                     // A delegate must have the same signature as the function it is pointing to
    public class Program
    {
        private static void Main(string[] args)
    {
        //Delegateoutput output = new Delegateoutput(Output);//pointing to a method
        //output("Welcome to delegate");
        //Result(3777);
        List<Event> eventsname = new List<Event>();
        eventsname.Add(new Event() { Type = "Wedding", Price = 7000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "B&G Event Centre" });
        eventsname.Add(new Event() { Type = "Corporate Party", Price = 5000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "Oath Event Centre" });
        eventsname.Add(new Event() { Type = "Birthday", Price = 4000000, Vendor = "Caterers, Event planners", Capacity = 1000, Venue = "Podium Event Centre" });
        eventsname.Add(new Event() { Type = "Naming Ceremony", Price = 3000000, Vendor = "Caterers, Event planners", Capacity = 700, Venue = "Ifenit Event Centre" });
        eventsname.Add(new Event() { Type = "Aniversary", Price = 8000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "Adex Event Centre" });

        eventdelegate planning = new eventdelegate(Eventplanning);
        Event.CloneIt(eventsname, planning);
        Console.WriteLine("-------");
        eventdelegate plan = new eventdelegate(Eventplan);
        Event.CloneIt(eventsname, plan);


    }
    //Delegate is a typed save function pointer, it point to a function which is a method and follow strictly the type it is returning.
    public static void Output(string args)
        {
            Console.WriteLine(args);
        }
    public static bool Eventplanning(Event evn)
    { 
        if (evn.Price < 5000000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool Eventplan(Event evn)
    {
        if (evn.Capacity >= 1000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}