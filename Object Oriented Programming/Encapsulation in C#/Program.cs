namespace OOPs
{
    #region Test 1
    //    class Bank
    //    {
    //        public long accountNumber;
    //        public string name;
    //        public int balance;

    //        public void GetBalance()
    //        {

    //        }

    //        public void WithdrawAmount()
    //        {

    //        }

    //        public void Deposit()
    //        {

    //        }

    //    }

    //    class MainClass
    //    {
    //        static void Main(string[] args)
    //        {
    //            Bank bank = new Bank();

    //            bank.accountNumber = 21345454;
    //            bank.name = "Demine";
    //            bank.GetBalance();
    //            bank.WithdrawAmount();

    //            Console.ReadKey();
    //        }
    //    }
    #endregion

    #region Implementing Data Encapsulation or Data Hiding in C# using Setter and Getter Methods
    //class Bank
    //{
    //    private double balance;

    //    public double GetBalance()
    //    {
    //        return balance;
    //    }

    //    public void SetBalance(double balance)
    //    {
    //        this.balance = balance;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Bank bank = new Bank();

    //        bank.SetBalance(2309);
    //        Console.WriteLine(bank.GetBalance());   

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region What is the Problem if we don’t follow the Encapsulation Principle in C# while Designing a Class?
    //class Bank
    //{
    //    private int amount;

    //    public int GetAmount()
    //    {
    //        return amount;
    //    }

    //    public void SetAmount(int amount)
    //    {
    //        if(amount > 0)
    //            this.amount = amount;   
    //        else
    //            throw new Exception("Please pass a positive value");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Bank bank = new Bank();

    //            bank.SetAmount(2309);
    //            Console.WriteLine(bank.GetAmount());

    //            bank.SetAmount(-154);
    //            Console.WriteLine(bank.GetAmount());
    //        }catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Implementing Data Encapsulation or Data Hiding in C# using Properties
    public class Bank
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                // Validate the value before storing it in the _Amount variable
                if (value < 0)
                {
                    throw new Exception("Please Pass a Positive Value");
                }
                else
                {
                    _Amount = value;
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                //We cannot access the _Amount Variable directly
                //bank._Amount = 50; //Compile Time Error
                //Console.WriteLine(bank._Amount); //Compile Time Error
                //Setting Positive Value using public Amount Property
                bank.Amount = 10;
                //Setting the Value using public Amount Property
                Console.WriteLine(bank.Amount);

                //Setting Negative Value
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
    #endregion
}