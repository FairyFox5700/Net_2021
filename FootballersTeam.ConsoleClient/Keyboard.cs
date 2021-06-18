using System;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient
{
    public class FootballerEventArgs
    {
        public  string Message{get;}
        public Footballer Footballer { get; }

        public FootballerEventArgs (string message, Footballer footballer)
        {
            Message = message;
            Footballer = footballer;
        }
    }
        public delegate void PressKeyEventHandler(FootballerEventArgs args);

        public class Keyboard
        {
            public event PressKeyEventHandler PressKeyD;
            private void PressKeyDEvent(FootballerEventArgs args)
            {
                PressKeyD?.Invoke(args);
            }
            
            public void Start(FootballerEventArgs args)
            {
                while (true)
                {
                    var s = Console.ReadLine();

                    switch (s?.ToUpper())
                    {
                        case "H":
                        {
                            PressKeyEventHandler pressKeyHEvent = (footArgs) =>
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"Footballer {footArgs.Footballer?.FirstName} " +
                                                  $"{footArgs.Footballer?.MiddleName} start playing current game");
                            };
                            pressKeyHEvent(args);
                            break;
                        }
                        case "B":
                        {
                            PressKeyEventHandler pressKeyBEvent = (footArgs) =>
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Footballer {footArgs.Footballer?.FirstName} " +
                                                  $"{footArgs.Footballer?.MiddleName} stops playing current game");
                            };
                            pressKeyBEvent(args);
                            break;
                        }
                        case "D":
                            PressKeyDEvent(args);
                            break;
                        case "EXIT":
                        {
                            PressKeyEventHandler handler = delegate(FootballerEventArgs args)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Exit!");
                            };
                            handler(args);
                            break;
                        }
                        default:
                            Console.WriteLine("No event handler for key {0}", s);
                            break;
                    }
                }
                Console.Read();
            }
        }
}