using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples
{
    class Data
    {
        public void Show(string Name)
        {
            lock (this)
            {
                Console.WriteLine("Hello " + Name);
                Thread.Sleep(1000);
                Console.WriteLine(" How Are You "); 
            }
        }
    }
    internal class SyncEx1
    {
        Data data;
        SyncEx1 (Data data)
        {
            this.data = data;
        }
        public void Shiva()
        {
            data.Show("Shiva");
        }
        public void krishna()
        {
            data.Show("Krishna");
        }

        static void Main(string[] args)
        {
            SyncEx1 syncEx1 = new SyncEx1(new Data());
            ThreadStart th1 = new ThreadStart(syncEx1.Shiva);
            ThreadStart th2 = new ThreadStart(syncEx1.krishna);
            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start();
            t2.Start();
        }

        
    }
}
