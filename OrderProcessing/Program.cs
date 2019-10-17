using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderProcessing
{
    public class Program
    {
        List<InventoryItems> inventory = new List<InventoryItems> {
            new InventoryItems{ product="X",quantity=5},
            new InventoryItems{ product="Y",quantity=1},
            new InventoryItems{ product="Z",quantity=0},

        };
        List<CreditCardDetails> creditcards = new List<CreditCardDetails> {
            new CreditCardDetails{ ccnumber="164781198",available_balance=50},
            new CreditCardDetails{ ccnumber="137214897",available_balance=10},
            new CreditCardDetails{ ccnumber="321749744",available_balance=30},

        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool CheckInventory(string productId, int qty)
        {
            var result = inventory.Where(w => w.product == productId && w.quantity >= qty);
            return result.Any();
        }
        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            decimal fee = 1;
            var result = creditcards.Where(p => p.ccnumber == creditCardNumber).FirstOrDefault();
            if(result.available_balance >= amount + fee)
            {
                result.available_balance = result.available_balance - (amount + fee);
                return true;
            }
            return false;

        }
        public class InventoryItems
        {
            public string product { get; set; }
            public int quantity { get; set; }
        }
        public class CreditCardDetails
        {
            public string ccnumber { get; set; }
            public decimal available_balance { get; set; }
        }
    }
}
