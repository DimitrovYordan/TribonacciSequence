using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] line = new int[3];
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i <= 2)
                {
                    line[0] = 1;
                    line[1] = 1;
                    Console.Write($"{line[0] + " "}");
                }
                else if (i == 3)
                {
                    line[2] = 2;
                    Console.Write($"{line[2] + " "}");
                }
                else if (i >= 4)
                {
                    result = line[0] + line[1] + line[2];
                    Console.Write($"{result + " "}");
                    line[0] = line[1];
                    line[1] = line[2];
                    line[2] = result;
                }

            }

        }
    }
}
