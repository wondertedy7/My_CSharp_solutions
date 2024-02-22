using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numN = int.Parse(Console.ReadLine());
            //string currentNum;
            //int singleNum;
            //for (int specialNum = 1111; specialNum <= 9999; specialNum++)
            //{
            //    currentNum = specialNum.ToString();
            //    int counter = 0;

            //    for (int i = 0; i < currentNum.Length; i++)
            //    {

            //        singleNum = int.Parse(currentNum[i].ToString());

            //        if (singleNum == 0)
            //        {
            //            break;
            //        }

            //        if (numN % singleNum == 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter == 4)
            //    {
            //        Console.Write($"{specialNum} ");
            //    }
            int numN = int.Parse(Console.ReadLine());
            string currentNum;

            for (int specialNum = 1111; specialNum <= 9999; specialNum++)
            {
                currentNum = specialNum.ToString();
                int counter = 0;

                for (int i = 0; i < currentNum.Length; i++)
                {
                    char num = currentNum[i];
                    int num1 = (int)num;
                    num1 = currentNum[i] - 48;

                    if (num1 == 0)
                    {
                        break;
                    }
                    if (numN % num1 == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 4)
                {
                    Console.Write($"{specialNum} ");
                }
            }
        }
    }
}
