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
    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show(); //Resolve at Runtime

            Console.ReadKey();
        }
    }
    #endregion
}