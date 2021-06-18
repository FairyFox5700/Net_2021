using System;
using System.Collections.Generic;
using System.IO.Pipes;
using FootballersTeam.ConsoleClient.Exceptions;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient
{
    class Program
    {    
        const  float DefaultSalary = 200;
        static void Main(string[] args)
        {
            //EventsAndDelegates();
           //2 arrays wit error handling
            //Array2D.ApplyCalculationWithoutCheck();
            Array2D.ApplyCalculationWithCheck();
            // Null reference Exception handling
            //CustomExceptions.PrintArrayValues();
            CustomExceptions.PrintValuesWithNRE();
            //CustomExceptions.CalculateLengthWithException(argument:null);
            //Invalid Casting exception
            //CustomExceptions.PrintFootballerWithCasting();
            CustomExceptions.CastToDerivedTypeWithException();
            //Argument Exception handling
            CustomExceptions.CalculateLengthWithException("");
            //Argument out of range
            //CustomExceptions.PrintAtIndex();
            CustomExceptions.ArgumentOutOfRangeExceptionHandling();
            GeneratedExceptions.ConstructFootballerWithValidation();
        }
        
        #region events and delagates

        public static void EventsAndDelegates()
        {
            Console.WriteLine("Current WindowWidth: {0}",
                Console.WindowWidth);
            Console.WriteLine("======Лабораторна робота №6======", ConsoleColor.Red);
            Console.WriteLine("Виконала студентка групи IТ-81");
            Console.WriteLine("Тищенко Iрина IТ-8124", ConsoleColor.DarkCyan);
            
            //initialisation with default constructor
            var defaultRole = new Role(1,"player");
            var goalkeeperRole = new Role(2, "goalkeeper");
            var defenderRole = new Role(3, "defender");
            //initialisation with constructor with argument
            var firstFootballer = new Footballer(firstName: "Ivan", "Ivanovich", "Ukrainian",
                new DateTime(1993, 4, 2), placeOfBirth: "Kiev", height: 170, weight: 50, role: defaultRole);
            var secondFootballer = new Footballer(firstName: "Petya", "Kirilovich", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 180, weight: 60, role: goalkeeperRole);
            var thirdFootballer = new Footballer(firstName: "Vasya", "Dovbush", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 190, weight: 60, role: defenderRole);
            Console.WriteLine("Footballers before any operations");
            var footballers = new List<Footballer>() {firstFootballer, secondFootballer, thirdFootballer};
            ConsoleTables.ConsoleTable
                .From<Footballer>(footballers)
                .Write();
            
            //delegates example
            foreach (var footballer in footballers)
            {
                FootballerSalary.SalaryCalculation formula =  FootballerSalary.GetSalaryFormula(footballer);
                float salary= formula(DefaultSalary);
                Console.WriteLine("Salary for footballer {0} {1}= {2}", footballer.FirstName, footballer.MiddleName, salary);
            }
            Console.Read();
            //events example
            Keyboard keyboard = new Keyboard();
            FootballerGreeting footballerGreeting = new FootballerGreeting();
            var events = new FootballerEventArgs("Footballer start playing", firstFootballer);
            // methods to event.
            keyboard.PressKeyD += new PressKeyEventHandler(footballerGreeting.PressKeyD_SecondHandler);
            keyboard.PressKeyD+= new PressKeyEventHandler(footballerGreeting.PressKeyD_Handler);
            while (true)
            {
                keyboard.Start(events);
            }
        }
                 
        #endregion
        #region upcasting_downcasting

        public static void UpcatingDowncosting()
        {
            Console.WriteLine("Current WindowWidth: {0}",
                Console.WindowWidth);
            Console.WriteLine("======Лабораторна робота №5======", ConsoleColor.Red);
            Console.WriteLine("Виконала студентка групи IТ-81");
            Console.WriteLine("Тищенко Iрина IТ-8124", ConsoleColor.DarkCyan);

            //ABSTRACT classs
            //var person = new Person() -- error can not initailize

            //initialisation with default constructor
            var defaultRole = new Role();
            //initialisation with constructor with argument
            var firstFootballer = new Footballer(firstName: "Ivan", "Ivanovich", "Ukrainian",
                new DateTime(1993, 4, 2), placeOfBirth: "Kiev", height: 170, weight: 50, role: defaultRole);
            var secondFootballer = new Footballer(firstName: "Petya", "Kirilovich", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 180, weight: 60, role: defaultRole);
            var thirdFootballer = new Footballer(firstName: "Vasya", "Dovbush", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 190, weight: 60, role: defaultRole);
            Console.WriteLine("Footballers before any operations");
            ConsoleTables.ConsoleTable
                .From<Footballer>(new List<Footballer>() {firstFootballer, secondFootballer, thirdFootballer})
                .Write();

            //UPCASTING
            Person upcastedFirstFootballer = firstFootballer;
            Person upcastedSecondFootballer = secondFootballer;
            Person upcastedThirdFootballer = thirdFootballer;
            Console.WriteLine("Upcasted to Person footballers");
            ConsoleTables.ConsoleTable
                .From<Person>(new List<Person>()
                    {upcastedFirstFootballer, upcastedSecondFootballer, upcastedThirdFootballer})
                .Write();

            //DOWNCAST
            Footballer downCastedFirstFootballer = (Footballer) upcastedFirstFootballer;
            Footballer downCastedSecondFootballer = (Footballer) upcastedSecondFootballer;
            Footballer downCastedThirdFootballer = (Footballer) upcastedThirdFootballer;
            Console.WriteLine("Downcasted to Footballer persons");
            ConsoleTables.ConsoleTable
                .From<Footballer>(new List<Footballer>()
                    {downCastedFirstFootballer, downCastedSecondFootballer, downCastedThirdFootballer})
                .Write();
        }

        #endregion
        
        #region operator overloading

        public static void OperatorOverloading()
        {
            Console.WriteLine("======Лабораторна робота №3======", ConsoleColor.Red);
            Console.WriteLine("Виконала студентка групи IТ-81");
            Console.WriteLine("Тищенко Iрина IТ-8124", ConsoleColor.DarkCyan);
            var score = new Score();
            score.ScoreId = 1;
            score.MissedGoals = 2;
            score.ScoredGoals = 3;
            var score2 = new Score();
            score2.ScoreId = 2;
            score2.MissedGoals = 5;
            score2.ScoredGoals = 7;
            Console.WriteLine("Перевантаження бiнарного  оператора");
            var score3 = score2 + score;
            score3.ScoreId = 3;
            ConsoleTables.ConsoleTable
                .From<Score>(new List<Score>() { score, score2, score3 })
                .Write();
            Console.WriteLine("Перевантаження унарного оператора");
            score += score2;
            ConsoleTables.ConsoleTable
                .From<Score>(new List<Score>() { score, score2, score3 })
                .Write();
            Console.WriteLine("Перевантаження логiчних  операторiв");
            var result = score == score2;
            Console.WriteLine($"Score {score.ScoreId} == Score {score2.ScoreId} : {result}");
            result = score != score2;
            Console.WriteLine($"Score {score.ScoreId} != Score {score2.ScoreId} : {result}");
            var score4 = new Score();
            score4.MissedGoals = score2.MissedGoals;
            score4.ScoredGoals = score2.ScoredGoals;
            score4.ScoreId = 4;
            result = score2 == score4;
            Console.WriteLine($"Score {score2.ScoreId} == Score {score4.ScoreId} : {result}");
            result = score2 != score4;
            Console.WriteLine($"Score {score2.ScoreId} != Score {score4.ScoreId} : {result}");
            Console.WriteLine("Перевантаження операторiв порiвняння");
            result = score >= score2;
            Console.WriteLine($"Score {score.ScoreId} >= Score {score2.ScoreId} : {result}");
            result = score <= score2;
            Console.WriteLine($"Score {score.ScoreId} <= Score {score2.ScoreId} : {result}");
            result = score > score2;
            Console.WriteLine($"Score {score.ScoreId} > Score {score2.ScoreId} : {result}");
            result = score < score2;
            Console.WriteLine($"Score {score.ScoreId} < Score {score2.ScoreId} : {result}");
            result = score4 >= score2;
            Console.WriteLine($"Score {score4.ScoreId} >= Score {score2.ScoreId} : {result}");
            result = score4 <= score2;
            Console.WriteLine($"Score {score4.ScoreId} <= Score {score2.ScoreId} : {result}");
            result = score4 > score2;
            Console.WriteLine($"Score {score4.ScoreId} > Score {score2.ScoreId} : {result}");
            result = score4 < score2;
            Console.WriteLine($"Score {score4.ScoreId} < {score2.ScoreId} : {result}");
        }
        #endregion
    }

}