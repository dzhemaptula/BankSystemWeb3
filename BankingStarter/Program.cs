using System;

namespace BankingStarter {
    class Program {
        static void Main(string[] args) {
            BankAccount myAccount = new BankAccount("123-123123-12");
            myAccount.Balance = 200M;
            myAccount.Deposit(100.0M);
            Console.WriteLine(myAccount.Balance.ToString());

            Console.ReadKey();

        }
    }
}
