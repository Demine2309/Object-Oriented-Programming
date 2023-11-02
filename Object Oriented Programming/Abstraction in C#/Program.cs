namespace OOPs
{
    #region Example to understand Abstraction Principle in C#
    #region Without Abstraction Principle
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Transaction doing SBI Bank");
    //        SBI sbi = new SBI();
    //        sbi.ValidateCard();
    //        sbi.WithdrawMoney();
    //        sbi.CheckBalanace();
    //        sbi.BankTransfer();
    //        sbi.MiniStatement();
    //        Console.WriteLine("\nTransaction doing AXIX Bank");
    //        AXIX AXIX = new AXIX();
    //        AXIX.ValidateCard();
    //        AXIX.WithdrawMoney();
    //        AXIX.CheckBalanace();
    //        AXIX.BankTransfer();
    //        AXIX.MiniStatement();

    //        Console.ReadKey();
    //    }
    //}

    //public class SBI
    //{
    //    public void BankTransfer()
    //    {
    //        Console.WriteLine("SBI Bank Bank Transfer");
    //    }

    //    public void CheckBalanace()
    //    {
    //        Console.WriteLine("SBI Bank Check Balanace");
    //    }

    //    public void MiniStatement()
    //    {
    //        Console.WriteLine("SBI Bank Mini Statement");
    //    }

    //    public void ValidateCard()
    //    {
    //        Console.WriteLine("SBI Bank Validate Card");
    //    }

    //    public void WithdrawMoney()
    //    {
    //        Console.WriteLine("SBI Bank Withdraw Money");
    //    }
    //}

    //public class AXIX
    //{
    //    public void BankTransfer()
    //    {
    //        Console.WriteLine("AXIX Bank Bank Transfer");
    //    }

    //    public void CheckBalanace()
    //    {
    //        Console.WriteLine("AXIX Bank Check Balanace");
    //    }

    //    public void MiniStatement()
    //    {
    //        Console.WriteLine("AXIX Bank Mini Statement");
    //    }

    //    public void ValidateCard()
    //    {
    //        Console.WriteLine("AXIX Bank Validate Card");
    //    }

    //    public void WithdrawMoney()
    //    {
    //        Console.WriteLine("AXIX Bank Withdraw Money");
    //    }
    //}
    #endregion

    #region Implement Abstraction Principle in C# using Interface
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Transaction doing SBI Bank");
    //        IBank sbi = BankFactory.GetBankObject("SBI");
    //        sbi.ValidateCard();
    //        sbi.WithdrawMoney();
    //        sbi.CheckBalanace();
    //        sbi.BankTransfer();
    //        sbi.MiniStatement();

    //        Console.WriteLine("\nTransaction doing AXIX Bank");
    //        IBank AXIX = BankFactory.GetBankObject("AXIX");
    //        AXIX.ValidateCard();
    //        AXIX.WithdrawMoney();
    //        AXIX.CheckBalanace();
    //        AXIX.BankTransfer();
    //        AXIX.MiniStatement();

    //        Console.Read();
    //    }
    //}

    //public interface IBank
    //{
    //    void ValidateCard();
    //    void WithdrawMoney();
    //    void CheckBalanace();
    //    void BankTransfer();
    //    void MiniStatement();
    //}

    //public class BankFactory
    //{
    //    public static IBank GetBankObject(string bankType)
    //    {
    //        IBank BankObject = null;

    //        if (bankType == "SBI")
    //        {
    //            BankObject = new SBI();
    //        }
    //        else if (bankType == "AXIX")
    //        {
    //            BankObject = new AXIX();
    //        }

    //        return BankObject;
    //    }
    //}

    //public class SBI : IBank
    //{
    //    public void BankTransfer()
    //    {
    //        Console.WriteLine("SBI Bank Bank Transfer");
    //    }

    //    public void CheckBalanace()
    //    {
    //        Console.WriteLine("SBI Bank Check Balanace");
    //    }

    //    public void MiniStatement()
    //    {
    //        Console.WriteLine("SBI Bank Mini Statement");
    //    }

    //    public void ValidateCard()
    //    {
    //        Console.WriteLine("SBI Bank Validate Card");
    //    }

    //    public void WithdrawMoney()
    //    {
    //        Console.WriteLine("SBI Bank Withdraw Money");
    //    }
    //}

    //public class AXIX : IBank
    //{
    //    public void BankTransfer()
    //    {
    //        Console.WriteLine("AXIX Bank Bank Transfer");
    //    }

    //    public void CheckBalanace()
    //    {
    //        Console.WriteLine("AXIX Bank Check Balanace");
    //    }

    //    public void MiniStatement()
    //    {
    //        Console.WriteLine("AXIX Bank Mini Statement");
    //    }

    //    public void ValidateCard()
    //    {
    //        Console.WriteLine("AXIX Bank Validate Card");
    //    }

    //    public void WithdrawMoney()
    //    {
    //        Console.WriteLine("AXIX Bank Withdraw Money");
    //    }
    //}
    #endregion

    #region Implement Abstraction Principle in C# using Abstract Class and Abstract Methods:
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Transaction doing SBI Bank");
    //        Bank sbi = BankFactory.GetBankObject("SBI");
    //        sbi.ValidateCard();
    //        sbi.WithdrawMoney();
    //        sbi.CheckBalanace();
    //        sbi.BankTransfer();
    //        sbi.MiniStatement();

    //        Console.WriteLine("\nTransaction doing AXIX Bank");
    //        Bank AXIX = BankFactory.GetBankObject("AXIX");
    //        AXIX.ValidateCard();
    //        AXIX.WithdrawMoney();
    //        AXIX.CheckBalanace();
    //        AXIX.BankTransfer();
    //        AXIX.MiniStatement();

    //        Console.Read();
    //    }
    //}
    //public abstract class Bank
    //{
    //    public abstract void ValidateCard();
    //    public abstract void WithdrawMoney();
    //    public abstract void CheckBalanace();
    //    public abstract void BankTransfer();
    //    public abstract void MiniStatement();
    //}

    //public class BankFactory
    //{
    //    public static Bank GetBankObject(string bankType)
    //    {
    //        Bank BankObject = null;

    //        if (bankType == "SBI")
    //        {
    //            BankObject = new SBI();
    //        }
    //        else if (bankType == "AXIX")
    //        {
    //            BankObject = new AXIX();
    //        }

    //        return BankObject;
    //    }
    //}

    //public class SBI : Bank
    //{
    //    public override void BankTransfer()
    //    {
    //        Console.WriteLine("SBI Bank Bank Transfer");
    //    }

    //    public override void CheckBalanace()
    //    {
    //        Console.WriteLine("SBI Bank Check Balanace");
    //    }

    //    public override void MiniStatement()
    //    {
    //        Console.WriteLine("SBI Bank Mini Statement");
    //    }

    //    public override void ValidateCard()
    //    {
    //        Console.WriteLine("SBI Bank Validate Card");
    //    }

    //    public override void WithdrawMoney()
    //    {
    //        Console.WriteLine("SBI Bank Withdraw Money");
    //    }
    //}

    //public class AXIX : Bank
    //{
    //    public override void BankTransfer()
    //    {
    //        Console.WriteLine("AXIX Bank Bank Transfer");
    //    }

    //    public override void CheckBalanace()
    //    {
    //        Console.WriteLine("AXIX Bank Check Balanace");
    //    }

    //    public override void MiniStatement()
    //    {
    //        Console.WriteLine("AXIX Bank Mini Statement");
    //    }

    //    public override void ValidateCard()
    //    {
    //        Console.WriteLine("AXIX Bank Validate Card");
    //    }

    //    public override void WithdrawMoney()
    //    {
    //        Console.WriteLine("AXIX Bank Withdraw Money");
    //    }
    //}
    #endregion
    #endregion

    #region Example to understand Abstract class and Abstract methods in C#
    //public abstract class AbsParent
    //{
    //    public void Add(int x, int y)
    //    {
    //        Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
    //    }

    //    public void Sub(int x, int y)
    //    {
    //        Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
    //    }

    //    public abstract void Mul(int x, int y);
    //    public abstract void Div(int x, int y);
    //}

    //public class AbsChild : AbsParent
    //{
    //    public override void Mul(int x, int y)
    //    {
    //        Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
    //    }

    //    public override void Div(int x, int y)
    //    {
    //        Console.WriteLine($"Division of {x} and {y} is : {x / y}");
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        // Error, we can't create an instance of an abstract class
    //        //AbsParent parent = new AbsParent();

    //        AbsChild absChild = new AbsChild();

    //        // Creating abstract class reference pointing to child class object
    //        AbsParent absParent = absChild;

    //        absChild.Sub(1, 2);
    //        absChild.Mul(1, 2);
    //        absChild.Div(1, 2);
    //        absChild.Add(1, 2);

    //        Console.WriteLine();

    //        absParent.Add(5, 10);
    //        absParent.Sub(5, 10);
    //        absParent.Div(5, 10);
    //        absParent.Mul(5, 10);
    //    }
    //}
    #endregion

    #region How to Use Abstract Classes and Abstract Methods in C# Application
    //public abstract class Shape
    //{
    //    public double Height;
    //    public double Width;
    //    public double Radius;
    //    public const float PI = 3.14f;

    //    public abstract double GetArea();
    //}

    //public class Rectangle : Shape
    //{
    //    public Rectangle(double Height, double Width)
    //    {
    //        this.Height = Height;
    //        this.Width = Width;
    //    }

    //    public override double GetArea()
    //    {
    //        return Width * Height;
    //    }
    //}

    //public class Circle : Shape
    //{
    //    public Circle(double Radius)
    //    {
    //        this.Radius = Radius;
    //    }

    //    public override double GetArea()
    //    {
    //        return PI * Radius * Radius;
    //    }
    //}

    //public class Triangle : Shape
    //{
    //    public Triangle(double Height, double Width)
    //    {
    //        this.Height = Height;
    //        this.Width = Width;
    //    }

    //    public override double GetArea()
    //    {
    //        return (Width * Height) / 2;
    //    }
    //}

    //public class Cone : Shape
    //{
    //    public Cone(double Radius, double Height)
    //    {
    //        this.Radius = Radius;
    //        this.Height = Height;
    //    }

    //    public override double GetArea()
    //    {
    //        return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rectangle rectangle = new Rectangle(10, 20);
    //        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

    //        Triangle triangle = new Triangle(15, 25);
    //        Console.WriteLine($"Area of Triangle: {triangle.GetArea()}");

    //        Circle circle = new Circle(12);
    //        Console.WriteLine($"Area of Circle: {circle.GetArea()}");

    //        Cone cone = new Cone(5, 15);
    //        Console.WriteLine($"Area of Cone: {rectangle.GetArea()}");

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Another example abour abstract class and abstract method
    public abstract class Plan
    {
        protected abstract double getRate();

        public void Calculation(int units)
        {
            double rate = getRate();
            Console.WriteLine($"Bill Amount For {units} Units is: Rs. {rate * units}");
        }
    }

    class CommercialPlan : Plan
    {
        protected override double getRate()
        {
            return 5.00;
        }
    }

    class DomesticlPlan : Plan
    {
        protected override double getRate()
        {
            return 2.50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("Commercial Plan");
            p = new CommercialPlan();
            p.Calculation(250);

            Console.WriteLine("Domesticl Plan");
            p = new DomesticlPlan();
            p.Calculation(150);
            Console.ReadKey();
        }
    }
    #endregion
}