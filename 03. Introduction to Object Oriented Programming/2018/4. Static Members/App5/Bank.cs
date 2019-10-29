using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Bank
    {
        public static void WithdrawFunds(int id, List<BankAccount> bankAccounts, double requestedSum)
        {
            int indexOfBA = -1;
            for (int i = 0; i < bankAccounts.Count; i++)
            {

                if (id == bankAccounts[i].ID)
                {
                    indexOfBA = i;
                    break;
                }
            }
            if (indexOfBA == -1)
            {
                Console.WriteLine($"Account with an ID of {id} does not exist.");
            }
            else if (requestedSum > bankAccounts[indexOfBA].Balance)
            {
                Console.WriteLine($"The requested sum is not available in the bank account.");
            }
            else bankAccounts[indexOfBA].Balance -= requestedSum;
        }
        public static void DepositFunds(int id, List<BankAccount> bankAccounts, double requestedSum)
        {
            int indexOfBA = -1;
            for (int i = 0; i < bankAccounts.Count; i++)
            {

                if (id == bankAccounts[i].ID)
                {
                    indexOfBA = i;
                    break;
                }
            }
            if (indexOfBA == -1)
            {
                Console.WriteLine($"Account with an ID of {id} does not exist.");
            }
            else bankAccounts[indexOfBA].Balance += requestedSum;
        }
    }
}
