using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод количества бросков
            Console.Write("Input number of tosses: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Coin myCoin = new Coin();

            int headsCount = 0;
            for (int i = 0; i < limit; i++)
            {
                // иммитация броска 
                myCoin.toss();
                if (myCoin.getSideUp() == 0)
                {
                    headsCount++;
                }
            }

            // вывод результатов
            double percent = Math.Round((double)headsCount / limit * 100, 2);
            Console.WriteLine("Heads count: " + headsCount);
            Console.WriteLine("Tails count: " + (limit - headsCount));
            Console.WriteLine("Heads percent: {0}%", percent);

            Console.ReadLine();
        }
    }
}