using System;
namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public void Harm(int num)
        {
            int count;
            double result = 0;
            for (count = 1; count <= num; count++)
            {
                Console.WriteLine("1/{0}+ ", count);
                result += 1 / (float)count;
            }
            Console.WriteLine("Harmonic value of " + num + " is " + result);
            Console.ReadKey();
        }
    }
}