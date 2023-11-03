using System.Runtime.CompilerServices;

namespace OOPs
{
    #region Example to Understand Compile-Time Polymorphism in C#
    //class Program
    //{
    //    public void Add(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }

    //    public void Add(float a, float b)
    //    {
    //        Console.WriteLine(a + b);
    //    }

    //    public void Add(string a, string b)
    //    {
    //        Console.WriteLine(a + b);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();

    //        obj.Add(1, 2);
    //        obj.Add(3.5f, 4.5f);
    //        obj.Add("Demine", "Nguyen");

    //        Console.ReadKey();  
    //    }
    //}
    #endregion

    #region Example to understand Run-Time Polymorphism in C#
    //class Class1
    //{
    //    //Virtual Function (Overridable Method)
    //    public virtual void Show()
    //    {
    //        //Parent Class Logic Same for All Child Classes
    //        Console.WriteLine("Parent Class Show Method");
    //    }
    //}
    //class Class2 : Class1
    //{
    //    //Overriding Method
    //    public override void Show()
    //    {
    //        //Child Class Reimplementing the Logic
    //        Console.WriteLine("Child Class Show Method");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class1 obj1 = new Class2();
    //        obj1.Show(); //Resolve at Runtime

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to Understand Method Overloading in C#
    //class Program
    //{
    //    public void Method()
    //    {
    //        Console.WriteLine("1st method");
    //    }

    //    public void Method(int i)
    //    {
    //        Console.WriteLine("2nd method");
    //    }

    //    public void Method(string s)
    //    {
    //        Console.WriteLine("3rd method");
    //    }

    //    public void Method(int i, string s)
    //    {
    //        Console.WriteLine("4th method");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();

    //        obj.Method();
    //        obj.Method(1);
    //        obj.Method("Demine");
    //        obj.Method(2, "Demine");
    //    }
    //}
    #endregion

    #region What is Inheritance-Based Method Overloading in C#?
    //class Class1
    //{
    //    public void Add(int a, int b)
    //    {
    //        Console.WriteLine(a + b);
    //    }

    //    public void Add(float x, float y)
    //    {
    //        Console.WriteLine(x + y);
    //    }
    //}

    //class Class2 : Class1
    //{
    //    public void Add(string s1, string s2)
    //    {
    //        Console.WriteLine(s1 + " " + s2);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class2 obj = new Class2();

    //        obj.Add(10, 20);
    //        obj.Add(10.5f, 20.7f);
    //        obj.Add("Pranaya", "Rout");

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to understand constructor method overloading in C#
    //class ConstructorOverloading
    //{
    //    int x, y, z;

    //    public ConstructorOverloading(int x)
    //    {
    //        Console.WriteLine("Constructor1 Called");
    //        this.x = 10;
    //    }

    //    public ConstructorOverloading(int x, int y)
    //    {
    //        Console.WriteLine("Constructor2 Called");
    //        this.x = x;
    //        this.y = y;
    //    }

    //    public ConstructorOverloading(int x, int y, int z)
    //    {
    //        Console.WriteLine("Constructor3 Called");
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"X={x}, Y={y}, Z={z}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ConstructorOverloading obj1 = new ConstructorOverloading(10);
    //        obj1.Display();

    //        ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
    //        obj2.Display();

    //        ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
    //        obj3.Display();

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Method Overloading Realtime Example using C# 
    //public class Logger
    //{
    //    public static void Log(string ClassName, string MethodName, string Message)
    //    {
    //        Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
    //    }

    //    public static void Log(string uniqueId, string ClassName, string MethodName, string Message)
    //    {
    //        Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, UniqueId: {uniqueId}, ClassName: {ClassName}, MethodName:{MethodName}, Message:{Message}");
    //    }

    //    public static void Log(string Message)
    //    {
    //        Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, Message: {Message}");
    //    }

    //    public static void Log(string ClassName, string MethodName, Exception ex)
    //    {
    //        Console.WriteLine($"DateTime: {DateTime.Now.ToString()}, ClassName: {ClassName}, MethodName:{MethodName}, Exception Message:{ex.Message}, \nException StackTrace: {ex.StackTrace}");
    //    }
    //    //You create many overloaded versions as per your business requirements
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string ClassName = "Program";
    //        string MethodName = "Main";
    //        string UniqueId = Guid.NewGuid().ToString();

    //        Logger.Log(ClassName, MethodName, "Message 1");
    //        Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
    //        Logger.Log("Message 3");

    //        try
    //        {
    //            int Num1 = 10, Num2 = 0;
    //            int result = Num1 / Num2;
    //            Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
    //        }
    //        catch (Exception ex)
    //        {
    //            Logger.Log(ClassName, MethodName, ex);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Complete Example to add two Complex Numbers in C#:
    //public class Complex
    //{
    //    private int real;
    //    private int img;

    //    public Complex(int r = 0, int i = 0)
    //    {
    //        real = r;
    //        img = i;
    //    }

    //    // Way 1:
    //    //public static Complex Add(Complex a, Complex b)
    //    //{
    //    //    Complex temp = new Complex();
    //    //    temp.real = a.real + b.real;
    //    //    temp.img = a.img + b.img;
    //    //    return temp;
    //    //}

    //    // Way 2:
    //    public static Complex operator +(Complex c1, Complex c2)
    //    {
    //        Complex temp = new Complex();
    //        temp.real = c1.real + c2.real;
    //        temp.img = c1.img + c2.img;
    //        return temp;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"{real} + i{img}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args )
    //    {
    //        Complex c1 = new Complex(3, 7);
    //        c1.Display();

    //        Complex c2 = new Complex(5, 2);
    //        c2.Display();

    //        // Way 1:
    //        //Complex c3 = Complex.Add(c1, c2);

    //        // Way 2:
    //        Complex c3 = c1 + c2;
    //        c3.Display();

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Example to Understand Method Overriding in C#
    //class Class1
    //{
    //    //Virtual Function (Overridable Method)
    //    public virtual void Show()
    //    {
    //        //Parent Class Logic Same for All Child Classes
    //        Console.WriteLine("Parent Class Show Method");
    //    }
    //}

    //class Class2 : Class1
    //{
    //    //Overriding Method
    //    public override void Show()
    //    {
    //        //Child Class Reimplementing the Logic
    //        Console.WriteLine("Child Class Show Method");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class1 obj1 = new Class1();
    //        obj1.Show();

    //        Class2 obj2 = new Class2();
    //        obj2.Show();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Overriding the Virtual Method is Optional in C#:
    //class Class1
    //{
    //    //Virtual Function (Overridable Method)
    //    public virtual void Show()
    //    {
    //        //Parent Class Logic Same for All Child Classes
    //        Console.WriteLine("Parent Class Show Method");
    //    }
    //}

    //class Class3 : Class1
    //{
    //    //Not Overriding the Virtual Method
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class3 obj3 = new Class3();
    //        obj3.Show();

    //        Class1 obj4 = new Class3();
    //        obj4.Show();

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Using the base keyword to call the Parent Class Methods in C#:
    //class Class1
    //{
    //    //Virtual Function (Overridable Method)
    //    public virtual void Show()
    //    {
    //        //Parent Class Logic Same for All Child Classes
    //        Console.WriteLine("Parent Class Show Method");
    //    }
    //}

    //class Class2 : Class1
    //{
    //    //Overriding Method
    //    public override void Show()
    //    {
    //        base.Show(); //Calling Parent Class Show method
    //        Console.WriteLine("Child Class Show Method");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class1 obj1 = new Class2();
    //        obj1.Show();

    //        Class2 obj2 = new Class2();
    //        obj2.Show();
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Calling Parent Class Methods by creating the Parent Class Object under the Child Class:
    class Class1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
    }

    class Class2 : Class1
    {
        public override void Show()
        {
            //Creating an instance of Parent Class
            Class1 class1 = new Class1();
            //Calling Parent Class Show method
            class1.Show();
            Console.WriteLine("Child Class Show Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show();

            Class2 obj2 = new Class2();
            obj2.Show();
            Console.ReadKey();
        }
    }
    #endregion
}