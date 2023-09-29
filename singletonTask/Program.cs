using System;

namespace Singleton.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Counter counter1 = Counter.GetInstance();
            Counter counter2 = Counter.GetInstance();

            counter1.Increase();
            counter1.Increase();
            counter2.Decrease();

            Console.WriteLine("Counter 1 count: " + counter1.GetCurrentCount()); // This will print "Counter 1 count: 1"
            Console.WriteLine("Counter 2 count: " + counter2.GetCurrentCount()); // This will also print "Counter 2 count: 1"


        }
    }

    public class Counter
    {
        private static Counter instance;
        private int count = 0;

        private Counter()
        {
        }

        public static Counter GetInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }

        public int GetCurrentCount()
        {
            return count;
        }

        public void Increase()
        {
            count++;
        }

        public void Decrease()
        {
            if (count > 0)
            {
                count--;
            }
        }
    }
}
