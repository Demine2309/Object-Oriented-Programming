namespace OOPs
{
    #region Example to understand inheritance in C#
    //class A
    //{
    //       public A()
    //       {
    //           Console.WriteLine("Class A Constructor is Called");
    //       }

    //       public void Method1()
    //	{
    //		Console.WriteLine("Method 1");
    //	}

    //	public void Method2()
    //	{
    //		Console.WriteLine("Method 2");
    //	}
    //}

    //class B : A
    //{
    //       B()
    //       {
    //           Console.WriteLine("Class B Constructor is Called");
    //       }

    //       public void Method3()
    //	{
    //		Console.WriteLine("Method 3");
    //	}

    //	static void Main()
    //	{
    //		B obj = new B();

    //		obj.Method1();
    //		obj.Method2();
    //		obj.Method3();

    //		Console.WriteLine();
    //		A p;
    //		B q = new B();

    //		p = q;

    //           p.Method1();
    //		p.Method2();
    //		// Error
    //		//obj2.Method3();

    //		Console.WriteLine();
    //           Object obj1 = new Object();
    //           Console.WriteLine($"obj1 type: {obj1.GetType()}");
    //           A obj2 = new A();
    //           Console.WriteLine($"obj2 type: {obj2.GetType()}");
    //           B obj3 = new B();
    //           Console.WriteLine($"obj3 type: {obj3.GetType()}");

    //           Console.ReadKey();
    //	}
    //}
    #endregion

    #region Test
    //class A
    //{
    //    public A(int number)
    //    {
    //        Console.WriteLine($"Class A Constructor is Called : {number}");
    //    }
    //    public void Method1()
    //    {
    //        Console.WriteLine("Method 1");
    //    }
    //    public void Method2()
    //    {
    //        Console.WriteLine("Method 2");
    //    }
    //}
    //class B : A
    //{
    //    public B() : base(10)
    //    {
    //        Console.WriteLine("Class B Constructor is Called");
    //    }
    //    public void Method3()
    //    {
    //        Console.WriteLine("Method 3");
    //    }
    //    static void Main()
    //    {
    //        B obj = new B();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region How to pass dynamic value to Parent class constructor in C#?
    //class A
    //{
    //    public A(int number)
    //    {
    //        Console.WriteLine($"Class A Constructor is Called : {number}");
    //    }
    //    public void Method1()
    //    {
    //        Console.WriteLine("Method 1");
    //    }
    //    public void Method2()
    //    {
    //        Console.WriteLine("Method 2");
    //    }
    //}
    //class B : A
    //{
    //    public B(int num) : base(num)
    //    {
    //        Console.WriteLine("Class B Constructor is Called");
    //    }
    //    public void Method3()
    //    {
    //        Console.WriteLine("Method 3");
    //    }
    //    static void Main()
    //    {
    //        B obj1 = new B(10);
    //        B obj2 = new B(20);
    //        B obj3 = new B(30);
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to understand Single inheritance in C#
    ////Parent class
    //public class Rectangle
    //{
    //    public int length;
    //    public int breadth;

    //    public int Area()
    //    {
    //        return length * breadth;
    //    }

    //    public int Perimeter()
    //    {
    //        return 2 * (length + breadth);
    //    }
    //}

    ////Child Class
    //class Cuboid : Rectangle
    //{
    //    public int height;

    //    public Cuboid(int l, int b, int h)
    //    {
    //        length = l;
    //        breadth = b;
    //        height = h;
    //    }

    //    public int Volume()
    //    {
    //        return length * breadth * height;
    //    }
    //}

    //public class Program
    //{
    //    static void Main()
    //    {
    //        // Creating object of Child class and
    //        // invoke the methods of Parent and Child classes
    //        Cuboid obj = new Cuboid(2, 4, 6);

    //        Console.WriteLine($"Volume is : {obj.Volume()}");
    //        Console.WriteLine($"Area is : {obj.Area()}");
    //        Console.WriteLine($"Perimeter is : {obj.Perimeter()}");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to Understand Multiple Inheritance in C# (Error example)
    //public class Program
    //{
    //    static void Main()
    //    {
    //        // Creating object of Child class and
    //        // invoke the methods of Parent classes and Child class
    //        SmartPhone obj = new SmartPhone(); ;
    //        obj.GetPhoneModel();
    //        obj.GetCameraDetails();
    //        obj.GetDetails();
    //        Console.ReadKey();
    //    }
    //}
    ////Parent Class 1
    //class Phone
    //{
    //    public void GetPhoneModel()
    //    {
    //        Console.WriteLine("Redmi Note 5 Pro");
    //    }
    //}
    ////Parent class2
    //class Camera
    //{
    //    public void GetCameraDetails()
    //    {
    //        Console.WriteLine("24 Mega Pixel Camera");
    //    }
    //}
    ////Child Class derived from more than one Parent class
    //class SmartPhone : Phone, Camera // Compile Time error
    //{
    //    public void GetDetails()
    //    {
    //        Console.WriteLine("Its a RedMi Smart Phone");
    //    }
    //}
    #endregion

    #region Example to Understand IsA Relationship in C#
    //class Rectangle
    //{
    //    //Data Members
    //    public int Length;
    //    public int Breadth;
    //    //Member Functions
    //    public int Area()
    //    {
    //        return Length * Breadth;
    //    }
    //    public int Perimeter()
    //    {
    //        return 2 * (Length + Breadth);
    //    }
    //}
    ////Establishing Parent-Child Relationship
    ////IS-A Relationship i.e. Cuboid IS-A Rectangle
    //class Cuboid : Rectangle
    //{
    //    public int Height;
    //    public Cuboid(int l, int b, int h)
    //    {
    //        Length = l;
    //        Breadth = b;
    //        Height = h;
    //    }
    //    public int Volume()
    //    {
    //        return Length * Breadth * Height;
    //    }
    //}

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Cuboid cuboid = new Cuboid(3, 5, 7);
    //        Console.WriteLine($"Volume is : {cuboid.Volume()}");
    //        Console.WriteLine($"Area is : {cuboid.Area()}");
    //        Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to understand HasA relationship in C#
    //class Address
    //{
    //    public string AddressLine, City, State;

    //    public Address(string addressLine, string city, string state)
    //    {
    //        AddressLine = addressLine;
    //        City = city;
    //        State = state;
    //    }
    //}
    //class Employee
    //{
    //    //Using Address in Employee class
    //    //Establishing Has-A relationship i.e. Employee HAS-A Address   
    //    public Address address;
    //    public int Id;
    //    public string Name;

    //    public Employee(int id, string name, Address adrs)
    //    {
    //        Id = id;
    //        Name = name;
    //        address = adrs;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Employee Id: {Id}");
    //        Console.WriteLine($"Employee Name: {Name}");
    //        Console.WriteLine($"AddressLine: {address.AddressLine}");
    //        Console.WriteLine($"City: {address.City}");
    //        Console.WriteLine($"State: {address.State}");
    //    }
    //}

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Address address = new Address("B1-3029", "BBSR", "Odisha");
    //        Employee employee = new Employee(1001, "Ramesh", address);
    //        employee.Display();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to understand Specialization in C#
    //class Rectangle
    //{
    //    public int Length;
    //    public int Breadth;

    //    public int Area()
    //    {
    //        return Length * Breadth;
    //    }

    //    public int Perimeter()
    //    {
    //        return 2 * (Length + Breadth);
    //    }
    //}

    //class Cuboid : Rectangle
    //{
    //    public int Height;

    //    public Cuboid(int l, int b, int h)
    //    {
    //        Length = l;
    //        Breadth = b;
    //        Height = h;
    //    }

    //    public int Volume()
    //    {
    //        return Length * Breadth * Height;
    //    }
    //}

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Cuboid cuboid = new Cuboid(3, 5, 7);
    //        Console.WriteLine($"Volume is : {cuboid.Volume()}");
    //        Console.WriteLine($"Area is : {cuboid.Area()}");
    //        Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to Understand Generalization in C#
    interface ICar
    {
        void Start();
        void Stop();
    }

    public class Innova : ICar
    {
        public void Start()
        {
            Console.WriteLine($"Innova Start");
        }

        public void Stop()
        {
            Console.WriteLine($"Innova Stop");
        }
    }

    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine($"BMW Start");
        }

        public void Stop()
        {
            Console.WriteLine($"BMW Stop");
        }
    }

    public class Program
    {
        static void Main()
        {
            Innova innova = new Innova();
            innova.Start();
            innova.Stop();

            ICar bmw = new BMW();
            bmw.Start();
            bmw.Stop();

            Console.ReadKey();
        }
    }
    #endregion
}