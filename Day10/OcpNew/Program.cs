using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpNew
{
    internal class Program
    {
        public static void ShowBillInfo(int meterId, string personName,IElectricity electricity )
        {
            Console.WriteLine("Meter id " + meterId);
            Console.WriteLine("Payment from Mr/Miss/Mrs " + personName);
            Console.WriteLine("Paymode is " + electricity.Payment(2000));
        }
        static void Main(string[] args)
        {
            IElectricity billSource;

            billSource = new NetBanking();
            ShowBillInfo(4787, "Abyansh ", billSource);

            billSource = new CreditCard();
            ShowBillInfo(7687, "Sreeja ", billSource );

            billSource = new DebitCard();
            ShowBillInfo(8734, "Avyaan ", billSource);

            billSource = new Phonepe();
            ShowBillInfo(8748, "Shlesha ", billSource);
        }
    }
}
