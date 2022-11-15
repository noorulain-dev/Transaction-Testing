using System;

namespace Passtask3
{
    class Program
    {
        public static void Show(Transaction[] transactions){
            foreach(Transaction t in transactions){
                Console.WriteLine("Transaction No:" + t.TransNo);
                Console.WriteLine("Transaction Date " + t.Date);
                Console.WriteLine("Transaction Amounts: " + t.Amounts);
                Console.WriteLine("Points " + t.Points);
                Console.WriteLine("Transaction mode: " +t.Mode);
                Console.WriteLine (t.PrintInfo());
            }
        }

        static void Main(string[] args)
        {
            Transaction[] myTransactions = new Transaction[2];

            myTransactions[0] = new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online);
            myTransactions[1] = new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline); 
                   
            myTransactions[0].UpdatePoints();
            myTransactions[1].UpdatePoints();

            Show(myTransactions);

        }
    

        
    }
}

