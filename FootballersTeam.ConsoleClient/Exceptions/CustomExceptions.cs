using System;
using System.Collections.Generic;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    public class CustomExceptions
    {
        public static void PrintFootballerWithCasting()
        {
            var firstFootballer = new Person( personId:1,firstName: "Ivan", "Ivanovich", "Ukrainian",
                new DateTime(1993, 4, 2), placeOfBirth: "Kiev");
            // Downcasting Person to type of Footballer.
            var castPerson= (Footballer)firstFootballer;
            ConsoleTables.ConsoleTable
                .From<Footballer>(new List<Footballer>() {castPerson})
                .Write();
        }
        public static void CastToDerivedTypeWithException()
        {
            try
            {
                PrintFootballerWithCasting();
            }
            catch (System.InvalidCastException exception)
            {
                Console.WriteLine("Downcasting failed.");
                Console.WriteLine(exception.Message);
            }
        }
        
        /// <summary>
        /// Function that calculates length of string
        /// </summary>
        /// <param name="argument"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">if arg is null</exception>
        /// <exception cref="ArgumentException">if arg length is 0</exception>
        public static int CalculateLengthWithException(string argument)
        {
            try
            {
                // Handle null argument.
                if (argument == null)
                {
                    throw new ArgumentNullException(nameof(argument));
                }
                // Handle invalid argument.
                if (argument.Length == 0)
                {
                    throw new ArgumentException("Zero-length string invalid", nameof(argument));
                }

                return argument.Length;
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
                return 0;
            }
        }


        public static void PrintArrayValues()
        {
            int[] values = null;
            for (int ctr = 0; ctr <= 9; ctr++)
                values[ctr] = ctr * 2;

            foreach (var value in values)
                Console.WriteLine(value);
        }
        public static void PrintValuesWithNRE()
        {
            try
            {
                PrintArrayValues();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException was catched");
                Console.WriteLine(e.Message);
            }
        }

        public static void PrintAtIndex()
        {
            var numbers = new List<int>();
            var index = 0;
            Console.WriteLine("Removing item at index {0}", index);
            numbers.RemoveAt(index);
        }
        public static void ArgumentOutOfRangeExceptionHandling()
        {
            try
            {
                PrintAtIndex();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException was caught");
                Console.WriteLine(ex.Message);
            }
        }
    }
}