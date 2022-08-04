using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new AddBankAccount("Ansar", 10000);
            Console.WriteLine($"Account Number: {account.Number} , Account Name: {account.Owner} , Current Balance: {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Jordans");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new AddBankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            account.MakeWithdrawal(50, DateTime.Now, "NBA 2k23");
            Console.WriteLine(account.Balance);
        }
    }
}
