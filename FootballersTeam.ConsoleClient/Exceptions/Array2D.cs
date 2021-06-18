using System;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    public class Array2D
    {
        public static void Calculate(int []aArray, int []bArray )
        {
            for (int i = 0; i < aArray.Length; i++) {
                int x = (int)Math.Floor((double)(aArray[i] / bArray[i]));
                Console.Write(x + " ");
            }
        }
        public static void ApplyCalculationWithoutCheck()
        {
            var array1 = new []{1,3,5,8,2,1,4};
            var array2 = new [] {3, 4, 5, 2};
            Calculate(array1, array2);
        }
        
        public static void ApplyCalculationWithCheck()
        {
            try 
            {
                var array1 = new []{1,3,5,8,2,1,1};
                var array2 = new [] {3, 4, 5, 2};
                try
                {
                    Calculate(array1, array2);
                }
                catch(DivideByZeroException exp)   
                {
                    Console.WriteLine("DivideByZeroException caught in the nested catch block: - ");
                    Console.WriteLine(exp.Message);
                }
            }
            catch(IndexOutOfRangeException exp)  			
            {
                Console.WriteLine("IndexOutOfRangeException caught in the outer catch block: ");
                Console.WriteLine(exp.Message);
            }
        }
    }
}