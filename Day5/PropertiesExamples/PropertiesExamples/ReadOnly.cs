using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    class Bank
    {
        public int AccountNum { get; } = 434435637;
        public string BranchName { get; } = "Hyderabad";

        public string BankName { get; } = "SBI";
    }
    internal class ReadOnly
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("AccountNo " +bank.AccountNum);
            Console.WriteLine("BranchName " +bank.BranchName);
            Console.WriteLine("BankName " +bank.BankName);
        }
    }
}
