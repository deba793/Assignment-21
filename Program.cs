using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment_21
{
    internal class Program
    {
        public static void NameOfDays(List<string> days)
        {
            Console.WriteLine("Days of Week");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
        }
        public static void AllMonths(List<string> months)
        {
            Console.WriteLine("Months of Year");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
        }
        public static void DisplayFruits(List<string> fruits)
        {
            Console.WriteLine("Fruits");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
        public static void DisplayMeanings(Dictionary<string, string> meanings)
        {
            Console.WriteLine("Words with Meanings");
            foreach (var meaning in meanings)
            {
                Console.WriteLine(meaning);
            }
        }
        static void Main(string[] args)
        {
            List<string> Fruits = new List<string>()
            { "Apple", "Mango", "WaterMelon", "Gauva", "Banana", "Strawberry", "Kiwi", "Fig", "DragonFruit", "Avocado"};
            List<string> Days = new List<string>()
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            List<string> Months = new List<string>()
            { "January", "Febrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            Dictionary<string, string> Meanings = new Dictionary<string, string>();
            Meanings.Add("Dictionary", "A generic collection which is generally used to store key/value pairs");
            Meanings.Add("List", "A collection of strongly typed objects");
            Meanings.Add("Thread", "A basic unit of execution within the process, and it is responsible for executing the application logic");
            Meanings.Add("Breakpoint", "An intentional stop marked in the code of an application where execution pauses for debugging");
            Meanings.Add("Async", "An async method runs synchronously until it reaches its first await expression, at which point the method is suspended until the awaited task is complete");
            Console.WriteLine("-----------------Welcome to Learning-------------------");
            var startTime = DateTime.Now;
            NameOfDays(Days);
            var endTime = DateTime.Now;
            Console.WriteLine("Start time: " + startTime + " end time: " + endTime);
            Thread.Sleep(5000);
            var startTime1 = DateTime.Now;
            AllMonths(Months);
            var endTime1 = DateTime.Now;
            Console.WriteLine("Start time: " + startTime1 + " end time: " + endTime1);
            Thread thread1 = new Thread(() => DisplayFruits(Fruits));
            Thread thread2 = new Thread(() => DisplayMeanings(Meanings));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }
    }
}