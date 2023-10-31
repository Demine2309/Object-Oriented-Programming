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
}