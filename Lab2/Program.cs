using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string path = @"C:\Users\BelikAE\Desktop\Lab2.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-100, 100));
                }

            }

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                    
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
