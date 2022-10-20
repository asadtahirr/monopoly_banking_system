using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly_banking_system
{
    public class Player
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Balance { get; set; }

        public Player(int id, string name, int balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetStartingBalance()
        {
            return Balance;
        }

        public void SetStartingBalance(int balance)
        {
            Balance = balance;
        }

        public decimal GetBalanceInDollar()
        {
            decimal balanceInDecimal = Convert.ToDecimal(Balance);
            decimal dividor = 100;

            return balanceInDecimal / dividor;
        }
    }
}
