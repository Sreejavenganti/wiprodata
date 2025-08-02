using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class MTable
    {
        public void Table(int n)
        {
            lock (this)
            {
                int P;
                for (int i = 1; i <= 10; i++)
                {
                    P = n * i;
                    Console.WriteLine(n + " * " + i + " = " + P);
                    Thread.Sleep(100);
                } 
            }
        }
    }
    internal class MTableSync
    {
        MTable table;
        MTableSync(MTable table)
        {
            this.table = table;
        }
        public void Table1()
        {
            table.Table(7);
        }
        public void Table2()
        {
            table.Table(8);
        }
        public void Table3()
        {
            table.Table(9);
        }
        static void Main(string[] args)
        {
            MTableSync mTableSync = new MTableSync(new MTable());
            ThreadStart th1 = new ThreadStart(mTableSync.Table1);
            ThreadStart th2 = new ThreadStart(mTableSync.Table2);
            ThreadStart th3 = new ThreadStart(mTableSync.Table3);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);
            Thread t3 = new Thread(th3);

            t1.Start();
            t2.Start();
            t3.Start();
        }
                
    }
}
