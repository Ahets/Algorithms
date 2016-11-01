using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApplication1
{
    interface ISort
    {
        void Sort();
    }
    class Bubble:ISort
    {
        Random r;
        int[] masBub = new int[6];
        public Bubble()
        {
            for (var i = 0; i < masBub.Count(); i++)
            {
                r = new Random();
                Thread.Sleep(100);
                int rand = r.Next(100);
                masBub[i] = rand;
            }
            foreach (var iter in masBub)
                Console.WriteLine(iter);
            Sort();
            showSortMas();
        }
        public void Sort()
        {
            for (var i = 0; i < masBub.Count(); i++)
            {
                for (var j = i + 1; j < masBub.Count(); j++)
                {
                    if (masBub[i] > masBub[j])
                    {
                        int t = masBub[i];
                        masBub[i] = masBub[j];
                        masBub[j] = t;
                    }
                }
            }
        }
        private void showSortMas()
        {
            Console.WriteLine("Sort mass--------");
            foreach (var iter in masBub)
            {
                Console.WriteLine(iter);
            }
        }
        class Merge
        {

        }
        class Quick
        {

        }
        class Program
        {
            static void Main(string[] args)
            {
                Bubble b = new Bubble();
                Console.Read();

            }
        }
    }
}

