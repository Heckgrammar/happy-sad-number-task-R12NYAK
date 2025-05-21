
      using System;

class Program
{
    static int GetSumOfSquares(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum = sum + (digit * digit);
            num = num / 10;
        }
        return sum;
    }

    static bool happyNum(int num)
    {
        int tries = 0;
        while (num != 1 && tries < 175) // avoiding endless loops :)
        {
            num = GetSumOfSquares(num);
            tries = tries + 1;
        }

        if (num == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("enter a number to determine if it's a happy one :) or a sad one :(");
        int number = Convert.ToInt32(Console.ReadLine());

        if (happyNum(number))
        {
            Console.WriteLine(number + " is a Happy Number");
        }
        else
        {
            Console.WriteLine(number + " is a Sad Number");
        }
    }
}
                 /*There are said to be happy numbers and sad numbers.
            Happy numbers will reduce to 1 when the digits belonging to the numbers are squared and added together to produce another number and the process is repeated. e.g. when we take 19
            1 squared is 1 , 9 squared is 81. 81 +1 = 82
            8 squared is 64, 2 squared is 4.  64 + 4 = 68
            6 squared is 36, 8 squared is 64, 36 + 64 = 100 
            1 squared is 1, 0 squared is 0 and thus the original number is reduced to 1
            Sad numbers will not reduce to 1 and will loop endlessly. e.g. when we take 20
            2 squared is 4, 0 squared is 0, 4 + 0 = 4
            4 squared is 16, 0 squared is 0, 16 + 0 = 16
            1 squared is 1, 6 squared is 36, 1 + 36 = 37
            3 squared is 9, 7 squared is 49, 9 + 49 = 58
            5 squared is 25, 8 squared is 64, 25 + 64 = 89
            8 squared is 64, 9 squared is 81, 64 + 81 = 145
            1 squared is 1, 4 squared is 16, 5 squared is 25, 1 + 16 + 25 = 42
            4 squared is 16, 2 squared is 4, 16 + 4 = 20
            20 will loop endlessly
            */
            //write a program to determine if a number is happy or sad
            //The program should take a number as input and output whether the number is happy or sad
            //test your program with the inputs of 19 and 20
            //show your output in the readme file
        }
    }
}
