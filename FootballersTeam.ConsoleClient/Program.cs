using System;
using System.Collections.Generic;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
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
    }
}