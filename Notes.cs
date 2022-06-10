using System.Linq;

namespace MethodOverriding


{
    //CONSTRUCTOR
    public class Customer


    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
           : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

        // Methods 

        public class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;

            }

            public void Move(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Move(Point newLocation)

            {
                if (newLocation == null)
                    throw new ArgumentNullException("newLocation");
                Move(newLocation.x, newLocation.y);

            }
        }
        public class Calculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach (var number in numbers)
                {
                    sum += number;

                }
                return sum;


            }


            //FIELDS

            public class Customers
            {
                public int Id;
                public string Name;
                public readonly List<Order> Orders = new List<Order>();

                public Customers(int id)
                {
                    this.Id = id;
                }
                public Customers(int id, string name)
                        : this(id) => this.Name = name;

            }
        }


        public class Order
        {

        }

        //ACCESS MODIFIER

        public class Person
        {
            private DateTime _birthdate;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }
            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }


        // PROPERTIES
        public class Persons
        {
            public Persons(DateTime birthdate)
            {
                Birthdate = birthdate;
            }
            public DateTime Birthdate { get; private set; }

            public int Age
            {
                get

                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var years = timeSpan.Days / 365;

                    return years;
                }
            }
        }


        // INDEXERS

        public class HttCookie
        {
            private readonly Dictionary<string, string> _dictionary;

            public HttCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }


        // INHERITANCE
        public class PresentationObject
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public void copy()
            {
                Console.WriteLine("Object copied to clipboard.");

            }

            public void Duplicate()
            {
                Console.WriteLine("Object is Duplicated.");
            }


            //public class Text : PresentationObject

            public int Fontisize { get; set; }
            public string FontName { get; set; }

            public void AddHyperlink(string url)
            {
                Console.WriteLine("We added a link to" + url);
            }
        }

        //CCOMPOSITION

        public class Logger
        {
            public void log(string message)
            {
                Console.WriteLine(message);
            }

            public class DbMigrators
            {
                private readonly Logger _logger;
                public DbMigrators(Logger logger)
                {
                    _logger = logger;

                }

                public void Migrate()
                {
                    _logger.log("We are migrating .");
                }

                public class Installer
                {
                    private readonly Logger _logger;
                    public Installer(Logger logger)
                    {
                        _logger = logger;
                    }

                    public void Install()
                    {
                        _logger.log("We are installing the application");
                    }

                }
            }
        }

        // Acess Modifiers with INHERITANCE

        public class Employee
        {
            public int id { get; set; }
            public string Name { get; set; }

            public void Promote()
            {
                var rating = CalculateRating(excludeOrders: true);
                if (rating == 0)
                    Console.WriteLine("Promoted to level 1");
                else
                    Console.WriteLine("Promoted to level 2");
            }

            private int CalculateRating(bool excludeOrders)
            {
                return 0;
            }

            public class GoldCustomer : Employee
            {
                public void Offervoucher()
                {

                }
            }
        }

        // CONSTRUCTOR INHERITANCE


        public class Vehicle
        {
            private readonly string _registrationNumber;
            //public Vehicle()
            //{ 
            //Console.WriteLine("Vehicle is being initialized,");
            //}
            public Vehicle(string registrationNumber)
            {
                _registrationNumber = registrationNumber;

                Console.WriteLine(" Vehicle is being intialized. {0}", registrationNumber);
            }

        }

        public class Car : Vehicle
        {
            public Car(String registrationNumber)
                : base(registrationNumber)
            {
                Console.WriteLine("Car is being intialized. {0}", registrationNumber);
            }
        }

        // UPCASTING AND DOWNCASTING

        // UPCASTING
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int x { get; set; }
            public int y { get; set; }

            public void Draw()
            {

            }

            public class Texts : Shape
            {
                public int Fontsize { get; set; }
                public int FontName { get; set; }
            }

        }

        // DOWNCASTING
        //public partial class MainWindow : Window
        //{
        //    public MainWindow()
        //    {
        //        InitializeComponent();
        //    }

        //    private void Button_Click(object sender, RoutedEventArgs e)
        //    {
        //        var button = sender as Button;
        //        if (button != null)
        //        {
        //            MessageBox.Show(button.ActualHeight.ToString());
        //        }
        //        MessageBox.Show("Hello World!");
        //    }
        //}

        // METHOD OVERRIDING

        public class Fun
        {
            public int Width { get; set; }
            public int Height { get; set; }


            public virtual void Draw()
            {

            }
        }



        public class Circle : Fun
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a circle");
            }
        }
        public class Rectangle : Fun
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Rectangle");
            }
        }


        public class Canvas

        {
            public void DrawShapes(List<Fun> funs)
            {
                foreach (var fun in funs)
                {
                    fun.Draw();
                }

            }
        }

        // ABSTRACT CLASS AND MEMBERS

        public abstract class Obed
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public abstract void Drawing();
            public void Copy()
            {
                Console.WriteLine("Copy shape into clipboard,");
            }

            public void Select()
            {
                Console.WriteLine("Select the shape");
            }
        }

        public class Circles : Obed
        {
            public override void Drawing()
            {
                Console.WriteLine("Draw a circle");
            }
        }


        public class Rectangles : Obed
        {
            public override void Drawing()
            {
                Console.WriteLine("Draw a Rectangle");
            }
        }
    }
}


// INTERFACE
public class OrderProccesor
{
    private readonly IShippingCalculator _shippingCalculator;
    public OrderProccesor(IShippingCalculator shippingCalculator)
    {
        _shippingCalculator = shippingCalculator;

    }

    public void Process(Orders orders)
    {
        if (orders.IsShipped)
            throw new InvalidOperationException("This Order is already processed");

        orders.Shipped = new Shipment
        {
            Cost = _shippingCalculator.CalculateCost(orders),
            ShippingDate = DateTime.Today.AddDays

        };
    }
}

// INTERFACES AND TESTABILITY
public class Shipment
{

    public int Cost { get; set; }
    public int CalculateCost { get; set; }
    public Func<double, DateTime> ShippingDate { get; internal set; }
}

public class Orders
{
    public int id { get; set; }
    public DateTime DatePlaced { get; set; }
    public Shipment Shipment { get; set; }

    public Shipment Shipped { get; set; }
    public float TotalPrice { get; set; }
    public bool IsShipped
    {
        get { return Shipment != null; }
    }
}

public interface IShippingCalculator
{
    float CalculateShipping(Orders orders);
}
public class ShippingCalculator : IShippingCalculator
{
    public int CalculateCost(Orders orders)
    {
        throw new NotImplementedException();
    }

    public float CalculateShipping(Orders orders)
    {
        if (orders.TotalPrice < 30f)
            return orders.TotalPrice * 0.1f;
        return 0;
    }
}

// INTERFACES AND EXTENSIBILITY



public class ConsoleLogger : ILogger
{
    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }

    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }
}

public interface ILogger
{

    void LogError(string message);
    void LogInfo(string message);
}

public class DbMigrator
{



    public readonly ILogger _logger;
    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo("Migrating started at {0}" + DateTime.Now);

        // Details of migrating the database

        _logger.LogInfo("Migrating finished at {0}" + DateTime.Now);

    }
}
public class FileLogger : ILogger
{
    private readonly String _path;

    public FileLogger(String path)
    {

        _path = path;
      
    }

    public void LogError(string message)
    {

        Log(message, "ERROR");
    }

    public void logInfo(string message)
    {
        Log(message, "INFO");
    }

    private void Log(string message, string messageType)
    {
        using (var streamWriter = new StringWriter(_path, true))
        {
            streamWriter.WriteLine(messageType + ": " + message);
        }
    }

    public void LogInfo(string message)
    {
        Log(message, "INFO");
    }

}




// INTERFACES AND POLYMORPHISM

//public class VideoEncoder
//{
//    private readonly MailService _mailService;

//    public VideioEncoder()
//    {
//        _mailService = new MailService();
//    }

//    public void Encode(Video video)

//        // video encoding logic 
//        //...

//    _mailService.Send(new Mail());
//        }
//     public class MailService
//{
//    public void Send(Mail mail)
//    {
//        Console.WriteLine("Sending email...");
//    }
//}
//}















