using System.Net;
using System.Xml.Linq;

namespace OOPs
{
    #region Test 1
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Test obj = new Test();
    //        Console.WriteLine($"i = {obj.i}");
    //        Console.WriteLine($"b = {obj.b}");

    //        if (obj.s == null)
    //        {
    //            Console.WriteLine("s = null");
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //class Test
    //{
    //    public int i;
    //    public bool b;
    //    public string s;
    //}
    #endregion

    #region Test 2: How to define the Constructor Explicitly in C#?
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ExplicitConstructor obj1 = new ExplicitConstructor();
    //        ExplicitConstructor obj2 = new ExplicitConstructor();
    //        ExplicitConstructor obj3 = new ExplicitConstructor();
    //        ExplicitConstructor obj4 = new ExplicitConstructor();


    //        Console.ReadKey();
    //    }
    //}

    //class ExplicitConstructor
    //{
    //    public ExplicitConstructor()
    //    {
    //        Console.WriteLine("Explicit Constructor is Called!");
    //    }
    //}
    #endregion

    #region Types of Constructors in C#
    #region Default or Parameter less Constructor in C#
    // System - Defined 
    //class Employee
    //{
    //    public int id, age;
    //    public string address, name;
    //    public bool isPermanent;
    //}

    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee e1 = new Employee();

    //        Console.WriteLine("Employee Id is: " + e1.id);
    //        Console.WriteLine("Employee Name is: " + e1.name);
    //        Console.WriteLine("Employee Age is: " + e1.age);
    //        Console.WriteLine("Employee Address is: " + e1.address);
    //        Console.WriteLine("Is Employee Permanent: " + e1.isPermanent);

    //        Console.ReadKey();
    //    }
    //}

    // User - Defined
    //class Employee
    //{
    //    public int id, age;
    //    public string address, name;
    //    public bool isPermanent;

    //    public Employee() 
    //    {
    //        id = 2309;
    //        age = 21;
    //        address = "Nghe An";
    //        name = "Demine";
    //        isPermanent = true;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("Employee Id is: " + id);
    //        Console.WriteLine("Employee Name is: " + name);
    //        Console.WriteLine("Employee Age is: " + age);
    //        Console.WriteLine("Employee Address is: " + address);
    //        Console.WriteLine("Is Employee Permanent: " + isPermanent);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee e1 = new Employee();
    //        e1.Display();

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Parameterized Constructor
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ParameterizedConstructor obj1 = new ParameterizedConstructor(23);
    //        obj1.Display();
    //        ParameterizedConstructor obj2 = new ParameterizedConstructor(09);
    //        obj2.Display(); 
    //        CopyConstructor obj3 = new CopyConstructor(2002);
    //        obj3.Display();
    //        CopyConstructor obj4 = new CopyConstructor(obj3);
    //        obj4.Display();

    //        Console.ReadKey();
    //    }
    //}

    //public class ParameterizedConstructor
    //{
    //    int x;

    //    public ParameterizedConstructor(int i)
    //    {
    //        x = i;
    //        Console.WriteLine($"Parameterized Constructor is called: {i}");
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Value of x = {x}");
    //    } 
    //}

    //public class CopyConstructor
    //{
    //    int x;

    //    public CopyConstructor(int i)
    //    {
    //        x = i;
    //    }

    //    //Copy Constructor
    //    public CopyConstructor(CopyConstructor obj)
    //    {
    //        x = obj.x;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Value of X = {x}");
    //    }
    //}
    #endregion

    #region Static Constructors
    //class StaticConstructor
    //{
    //    static StaticConstructor()
    //    {
    //        Console.WriteLine("Static Constructor executed!");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Main Method Execution Started...");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Private Constructors
    //class Program
    //{
    //    private Program()
    //    {
    //        Console.WriteLine("This is private constructor");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        Console.WriteLine("Main method");
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #endregion

    #region Why we need Constructors?
    class Employee
    {
        public int id, age;
        public string address, name;
        public bool isPermanent;

        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
            this.isPermanent = isPermanent;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + this.id);
            Console.WriteLine("Employee age is:  " + this.age);
            Console.WriteLine("Employee Address is:  " + this.address);
            Console.WriteLine("Employee Name is:  " + this.name);
            Console.WriteLine("Is Employee Permanent:  " + this.isPermanent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, 21, "Demine", "Ha Noi", true);
            e1.Display();

            Console.WriteLine();

            Employee e2 = new Employee(2, 21, "Cuong", "Nghe An", false);
            e2.Display();

            Console.ReadKey();
        }
    }
    #endregion
}