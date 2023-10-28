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
    class Employee
    {
        public int id, age;
        public string address, name;
        public bool isPermanent;
    }

    class Test
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Console.WriteLine("Employee Id is: " + e1.id);
            Console.WriteLine("Employee Name is: " + e1.name);
            Console.WriteLine("Employee Age is: " + e1.age);
            Console.WriteLine("Employee Address is: " + e1.address);
            Console.WriteLine("Is Employee Permanent: " + e1.isPermanent);

            Console.ReadKey();
        }
    }

    // User - Defined

    #endregion
    #endregion
}