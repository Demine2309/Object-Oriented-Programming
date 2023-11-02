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
    class A
    {
        public A(int number)
        {
            Console.WriteLine($"Class A Constructor is Called : {number}");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class B : A
    {
        public B(int num) : base(num)
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            B obj1 = new B(10);
            B obj2 = new B(20);
            B obj3 = new B(30);
            Console.ReadKey();
        }
    }
    #endregion
}