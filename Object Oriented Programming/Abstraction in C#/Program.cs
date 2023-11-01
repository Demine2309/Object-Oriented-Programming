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
    public abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }

        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }

    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            // Error, we can't create an instance of an abstract class
            //AbsParent parent = new AbsParent();

            AbsChild absChild = new AbsChild();

            // Creating abstract class reference pointing to child class object
            AbsParent absParent = absChild;

            absChild.Sub(1, 2);
            absChild.Mul(1, 2);
            absChild.Div(1, 2);
            absChild.Add(1, 2);

            Console.WriteLine();

            absParent.Add(5, 10);
            absParent.Sub(5, 10);
            absParent.Div(5, 10);
            absParent.Mul(5, 10);
        }
    }
    #endregion
}