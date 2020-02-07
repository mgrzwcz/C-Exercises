using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassExercise
{
    class Account
    {
        public decimal Balance { get; set; }

        public Account(decimal InitialBalance)
        {
            if (Balance == 0)
            {
                Balance = InitialBalance;
            }
            
        }

        public bool Credit(decimal amount)
        {
            
            if((Balance + amount) > Balance){
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Debit(decimal amount)
        {

            if ((Balance - amount) < Balance && (Balance - amount) >= 0)
            {
                Balance -=  amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Account balance: {Balance}{Environment.NewLine}Crediting 200 successful? {Credit(200)}{Environment.NewLine}"
                + $"Debiting 500 successful? {Debit(500)}{Environment.NewLine}Final balance: {Balance}{Environment.NewLine}";
        }





    }
}


