using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _directory = "";
            string _fileName = "Data.txt";
            bool _isCommand = false;
            bool _needExit = false;
            string _fullPath = "";
            List <string> _data = new List<string>();
            string[] _commandsList = new string[]
            {
                "exit","remove","help","?"
            };
            ReadFile();

            while (!_needExit)
            {
                PrintData();
                string line = Console.ReadLine();
                if (CheckCommands(line))
                {
                    ExecuteCommand(line);
                }
                else
                {
                    AppendData(line);
                    WriteDataToFile();
                }
            }
            Console.ReadLine();
            //End of program
            List <string> ReadFile()
            {
                _directory = Directory.GetCurrentDirectory();//Путь до exe-файла
                _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName; //Перейти по каталогу на 3 уровня вверх с помощью parent
                _fullPath = Path.Combine(_directory, _fileName); // Комбинирование пути +папка или +файл
                return _data = File.ReadAllLines(_fullPath).ToList(); // Чтение файла и запись string в переменную
            }
            void ExecuteCommand(string command)
            {
                if (command == "exit")
                {
                    _needExit = true;
                }
                if (command == "remove")
                {
                    Console.WriteLine("Какую строку удаляем?");
                    int lineNumber = int.Parse(Console.ReadLine());
                    try
                    {
                        _data.RemoveAt(lineNumber);
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка, попробуйте ещё раз: ");
                    }
                }
                WriteDataToFile();

            }
            bool CheckCommands(string line)
            {
                line = line.Trim().ToLower();
                return _commandsList.Contains(line);
            }
            void AppendData(string data)
            {
                _data.Add(data);
            }
            void WriteDataToFile()
            {
                File.WriteAllLines(_fullPath, _data); // Запись string данных в файл по пути _fullPath
            }
            void PrintData()
            {
                int i = 0;
                Console.WriteLine("DATA: ");
                foreach (string note in _data)
                {
                    Console.WriteLine($"{i++}. {note}");
                }
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}