using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _directory = "";
            string _fileName = "Data.txt";
            string _fullPath = "";
            List <string> _data = new List<string>();
            ReadFile();

            while (true)
            {
                PrintData();
                string line = Console.ReadLine();
                if (line == "exit")
                {
                    Console.WriteLine("Файл сохранён");
                    break;
                }
                if (line == "remove")
                {
                    Console.WriteLine("Какую строку удаляем? Аааа? (номер от нуля пж)");
                    int lineNumber = int.Parse(Console.ReadLine());
                    _data.RemoveAt(lineNumber);
                    continue;
                }
                AppendData(line);
                
                Console.Clear();
            }

            WriteDataToFile();
            Console.ReadLine();
            List <string> ReadFile()
            {
                _directory = Directory.GetCurrentDirectory();//Путь до exe-файла
                _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName; //Перейти по каталогу на 3 уровня вверх с помощью parent
                _fullPath = Path.Combine(_directory, _fileName); // Комбинирование пути +папка или +файл
                return _data = File.ReadAllLines(_fullPath).ToList(); // Чтение файла и запись string в переменную
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
                Console.WriteLine("DATA: ");
                Console.WriteLine(string.Join(Environment.NewLine, _data));
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}