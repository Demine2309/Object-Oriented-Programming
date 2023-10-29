using System;

namespace OOPs
{
    #region Test 1
    //class DestructorDemo
    //{
    //	public DestructorDemo()
    //	{
    //		Console.WriteLine("Constructor Object Created");
    //	}

    //	~DestructorDemo()
    //	{
    //		string type = GetType().Name;
    //		Console.WriteLine($"Object {type} is Destroyed");
    //	}
    //}

    //class Program
    //{
    //	static void Main(string[] args)
    //	{
    //		DestructorDemo obj1 = new DestructorDemo();
    //		DestructorDemo obj2 = new DestructorDemo();

    //		// Making obj1 and obj2 for garbage collection
    //		obj1 = null;
    //		obj2 = null;

    //		GC.Collect();
    //           // Now, you can see that the Destructor is executed. This is because we have made the obj1 and obj2 value null. 

    //           Console.ReadKey();
    //	}
    //}
    #endregion

    #region Prove the destructor method is Implicitly called by Garbage Collector
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("DestructorDemo Object Created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("DestructorDemo Object Destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            DestructorDemo obj1 = new DestructorDemo();

            //Making obj1 ready for Garbage Collection
            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some Statement Executed Inside Main Method");

            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some More Statement Executed Inside Main Method");

            GC.Collect();
            Console.WriteLine("Main Method Execution End");
            Console.ReadKey();
        }
    }
    #endregion
}