using System;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    public class ExceptionFilters
    {
        public static void FilterExceptionExecute()
        {
            try 
            {
                var array1 = new []{1,3,5,8};
                var array2 = new [] {3, 4, 5,0};
                try
                {
                    for (int i=0; i < Math.Min(array1.Length,array2.Length); i++) {
                        int v = (int)Math.Floor((double)(array1[i] / array2[i]));
                        Console.Write(v + " ");
                    }
                }
                catch(DivideByZeroException exp )when (array1[0]==0 && array2[0] == 0)
                {
                    Console.WriteLine("DivideByZeroException caught in 0 element: - ");
                    Console.WriteLine(exp.Message);
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