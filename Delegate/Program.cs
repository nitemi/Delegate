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
        eventsname.Add(new Event() { Department = "Physics, Chemistry, Biology, PHE, Geography" , School = "School of Science", Level= "100 to 500", SchoolFees = 7500000, Type = "Wedding", Price = 7000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "B&G Event Centre" });
        eventsname.Add(new Event() { Department = "Economics, Social Studies, Fine & Applied Art,Theartre Art" , School = "School of Art & Social SCience", Level = "100 to 500", SchoolFees = 5000000, Type = "Corporate Party", Price = 5000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "Oath Event Centre" });
        eventsname.Add(new Event() { Department = "Adult & Non-Formal Education, Primary Education, Early Childhood Education", School = "School of Education", Level = "100 to 500", SchoolFees = 3900000, Type = "Birthday", Price = 4000000, Vendor = "Caterers, Event planners", Capacity = 1000, Venue = "Podium Event Centre" });
        eventsname.Add(new Event() { Department = "Home Economics, Political Science", School = "School of Vocational Studies", Level = "100 to 500", SchoolFees = 3500000, Type = "Naming Ceremony", Price = 3000000, Vendor = "Caterers, Event planners", Capacity = 700, Venue = "Ifenit Event Centre" });
        eventsname.Add(new Event() { Department = "Theatre Art", School = "School of Theatre Art", Level = "100 to 500", SchoolFees = 3600000, Type = "Aniversary", Price = 8000000, Vendor = "Caterers, Event planners", Capacity = 1500, Venue = "Adex Event Centre" });
        
        var find = eventsname.Select(e => e.Price > 7000000).ToList();
        foreach (var item in find)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------");
        var result = eventsname.Select (e => new { price = e.Price, venue = e.Venue, capacity = e.Capacity , vendors = e.Vendor, type = e.Type}).ToList();
        foreach (var item in result)
        {
            Console.WriteLine( "Venue:" + item.venue  + "\n" + "Type of Event:" + item.type + "\n" + "Price: " + item.price );// if i want to specify which info neeeded
       
            //Console.WriteLine(item.venue);
            //Console.WriteLine(item.type);
        }
        Console.WriteLine("------------");
        var view = eventsname.Where(e => e.Capacity > 1000).ToList();
        foreach (var item in view)
        {
            Console.WriteLine(item.Venue);// To check the venue that has more than 1000 capacity
        }
        Console.WriteLine("----------");
        var total = eventsname.Sum(e => e.Price);
        Console.WriteLine(total);

        Console.WriteLine("------------");
        var school = eventsname.Select(x => new { x.School, x.Level, x.SchoolFees, x.Department }).ToList();
        foreach (var item in school)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------");
        var totalFees = eventsname.Sum(x => x.SchoolFees);
        Console.WriteLine(totalFees);
        Console.ReadKey();



    }
}