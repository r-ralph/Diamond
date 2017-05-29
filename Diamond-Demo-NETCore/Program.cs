using System;
using System.IO;
using Diamond.Anvil.Init;

namespace Demo.NETCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Please enter which type to load.");
                Console.WriteLine("1. Anvil File Format");
                Console.WriteLine("2. PE Level Format");
                Console.WriteLine("3. Remote connection");
                Console.WriteLine("0. Cancel");
                var readLine = Console.ReadLine();
                if (!int.TryParse(readLine, out n))
                {
                    Console.WriteLine("Please input valid number!");
                    continue;
                }
                break;
            }
            switch (n)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("Anvil File Format is selected.");
                    LoadAnvilFileFormat();
                    break;
                default:
                    Console.WriteLine("Not implemented yet!");
                    break;
            }
        }

        private static void LoadAnvilFileFormat()
        {
            var path = new DirectoryInfo(Path.Combine(new DirectoryInfo(".").FullName, "testdata", "anvil_world"));
            var level = Anvil.LoadFrom(path);
            Console.WriteLine("Load completed.");
            Console.WriteLine(level.LevelName);
            
            Console.Read();
        }
    }
}