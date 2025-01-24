using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class bankaccount
    {
        public int id { get; set; }
        public double balance { get; set; }
        public bankaccount(int accountnumber,double initialbalance)
        {
            id = accountnumber;
            balance = initialbalance;
        }
        public void displayDetails()
        {
            Console.WriteLine($"id:{id}");
            Console.WriteLine($"name:{balance}");
        }
        public class savingaccount : bankaccount
        {
            public savingaccount(int accountnumber,double balance) : base(accountnumber,balance)
            {

            }
        }
    }
}
internal class sealedclass
{
    static void Main()
    {
        bankaccount acc = new bankaccount(1, 500);
        acc.displayDetails();
    }
}

