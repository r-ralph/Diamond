using System;
using System.IO;
using System.Reflection;
using Diamond;
using Diamond.Anvil.Init;

namespace Demo.NETCore
{
    public class Program
    {
        private static Level _level;
        private static Mode _mode = Mode.Root;

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
            Start();
            Console.WriteLine("Finished");
        }

        private static void LoadAnvilFileFormat()
        {
            var path = new DirectoryInfo(Path.Combine(new DirectoryInfo(".").FullName, "testdata", "anvil_world"));
            _level = Anvil.LoadFrom(path);
            Console.WriteLine("Load completed.");
        }

        private static void Start()
        {
            while (true)
            {
                switch (_mode)
                {
                    case Mode.Exit:
                        return;
                    case Mode.Root:
                        ProcessRootInput();
                        break;
                    case Mode.Level:
                        ProcessLevelInput();
                        break;
                    case Mode.LevelGameRules:
                        ProcessLevelGameRuleInput();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void ProcessRootInput()
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "level":
                    _mode = Mode.Level;
                    break;
                case "exit":
                    _mode = Mode.Exit;
                    break;
                case "help":
                    Console.WriteLine("level: Go to level info viewer.");
                    Console.WriteLine("help: Show help.");
                    Console.WriteLine("exit: Finish this program.");
                    break;
                default:
                    Console.WriteLine("Type \"help\" to show help.");
                    break;
            }
        }

        private static void ProcessLevelInput()
        {
            Console.Write("Level > ");
            var input = Console.ReadLine();
            var inputArr = input.Split(' ');
            switch (inputArr[0].ToLower())
            {
                case "name":
                    Console.WriteLine($"Level Name: {_level.LevelName}");
                    break;
                case "seed":
                    Console.WriteLine($"Seed value: {_level.RandomSeed}");
                    break;
                case "prop":
                    if (inputArr.Length != 2)
                    {
                        Console.WriteLine("Wrong argument.");
                    }
                    else
                    {
                        var propName = inputArr[1];
                        var propertyInfo = _level.GetType().GetProperty(propName);
                        if (propertyInfo == null)
                        {
                            Console.WriteLine($"Unknown property: {propName}");
                        }
                        else
                        {
                            var value = propertyInfo.GetValue(_level);
                            Console.WriteLine($"{propName}: {value}");
                        }
                    }
                    break;
                case "gamerule":
                    _mode = Mode.LevelGameRules;
                    break;
                case "exit":
                    _mode = Mode.Root;
                    break;
                case "help":
                    Console.WriteLine("gamerule: Go to game rule viewer mode.");
                    Console.WriteLine("name: Print this level's name.");
                    Console.WriteLine("seed: Print this level's seed value.");
                    Console.WriteLine("prop <Property>: Show assiciated property value.");
                    Console.WriteLine("help: Show help.");
                    Console.WriteLine("exit: Exit from level info viewer.");
                    break;
                default:
                    Console.WriteLine("Type \"help\" to show help.");
                    break;
            }
        }

        private static void ProcessLevelGameRuleInput()
        {
            Console.Write("Level/GameRule > ");
            var input = Console.ReadLine();
            var inputArr = input.Split(' ');
            switch (inputArr[0].ToLower())
            {
                case "prop":
                    if (inputArr.Length != 2)
                    {
                        Console.WriteLine("Wrong argument.");
                    }
                    else
                    {
                        var propName = inputArr[1];
                        var propertyInfo = _level.GameRules.GetType().GetProperty(propName);
                        if (propertyInfo == null)
                        {
                            Console.WriteLine($"Unknown property: {propName}");
                        }
                        else
                        {
                            var value = propertyInfo.GetValue(_level.GameRules);
                            Console.WriteLine($"{propName}: {value}");
                        }
                    }
                    break;
                case "exit":
                    _mode = Mode.Level;
                    break;
                case "help":
                    Console.WriteLine("prop <Property>: Show assiciated property value.");
                    Console.WriteLine("help: Show help.");
                    Console.WriteLine("exit: Exit from level info viewer.");
                    break;
                default:
                    Console.WriteLine("Type \"help\" to show help.");
                    break;
            }
        }

        private enum Mode
        {
            Exit,
            Root,
            Level,
            LevelGameRules
        }
    }
}