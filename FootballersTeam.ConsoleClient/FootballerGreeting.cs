using System;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient
{


    public class FootballerGreeting
    {
        public void PressKeyD_Handler(FootballerEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    FOOTBALLER DETAILS    ");
            ConsoleTables.ConsoleTable
                .From<Footballer>(new Footballer[]{args.Footballer})
                .Write();
            Console.WriteLine();
        }

        public void PressKeyD_SecondHandler(FootballerEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(args.Message);
            Console.WriteLine();
        }
    }
}