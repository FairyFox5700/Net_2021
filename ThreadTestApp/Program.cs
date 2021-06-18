using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTestApp
{

    public class FileManager
    {
        private readonly string _file;
      
        public FileManager(string file)
        {
            _file = file;
        }

        public string ReadAllFile()
        {
            if (File.Exists(_file))
            {
                    string readText = File.ReadAllText(_file);
                    return readText;
            }

            return "";
        }
        public void WriteToFile(object appendText)
        {
            if (File.Exists(_file))
            {
                File.AppendAllText(_file, appendText + Environment.NewLine, Encoding.UTF8);
            }
        }
    }
    class Program
    {

        private  const string path = @"D:\Предмети\MyProject\FootballersConsole2021\FootballersTeam\ThreadTestApp\fish.txt";
        static  FileManager manager = new FileManager(path);
        private  static Semaphore sem = new Semaphore(1, 2);
        private static void DoAppendTextAndRead(object stringText)
        {
            sem.WaitOne();
            manager.WriteToFile(stringText);
            Console.WriteLine(manager.ReadAllFile());
            sem.Release();
        }
        static void Main(string[] args)
        {
           
            Thread t = new Thread(new ParameterizedThreadStart( DoAppendTextAndRead));
            t.Start("Товарищи!");
            Thread t2 = new Thread(new ParameterizedThreadStart( DoAppendTextAndRead));
            t2.Start("Поздравляю!");
            Thread t3 = new Thread(new ParameterizedThreadStart( DoAppendTextAndRead));
            t3.Start("С Новым годом!");
            Thread t4 = new Thread(new ParameterizedThreadStart( DoAppendTextAndRead));
            t4.Start("С Новым счастьем!");
            Thread t5 = new Thread(new ParameterizedThreadStart( DoAppendTextAndRead));
            t5.Start("Друзья!");
            //array calculation in threads
            /*
              int[] arr = Enumerable.Range(1, 100000000).ToArray();
             Thread thread1 = new Thread(TotalCount);
            Thread thread2 = new Thread(TotalCount);
            
            var timeSpan= Time(() =>
            {
                TotalCount(arr);
                thread1.Start(arr);
                thread2.Start(arr); 
            });
            Console.WriteLine("Calculated in: {0}h {1}m {2}s {3}ms", 
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds, 
                timeSpan.Milliseconds);
            Console.WriteLine($"TatalMiliseconds {timeSpan.TotalMilliseconds}");*/
        }

        private const int  totalCount = 10000;
        
        public static void TotalCount(object arr)
        {
            long  total = 0l;
            foreach (int num in (int[])arr)
            {
               total += num;
            }
        }
        public static TimeSpan Time(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}