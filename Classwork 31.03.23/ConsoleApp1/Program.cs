using System.Data;

namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime finishDateTime = new DateTime(2023, 3, 31, 21, 20, 0);
            DateTime _diffDateTime;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"День: {GetDays()}\nМесяц: {GetMonth()}\nГод: {GetYears()}");
                Console.WriteLine($"Время: {GetHours()}:{GetMinutes(DateTime.Now)}:{GetSeconds(DateTime.Now)}");
                _diffDateTime = new DateTime(finishDateTime.Ticks - DateTime.Now.Ticks);
                Console.WriteLine($"Время до конца пары: {GetMinutes(_diffDateTime)}: {GetSeconds(_diffDateTime)}");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
            //END
            int GetSeconds(DateTime dateTimeParam)
            {
                return dateTimeParam.Second;
            }
            int GetMinutes(DateTime dateTimeParam)
            {
                return dateTimeParam.Minute;
            }
            int GetHours()
            {
                return DateTime.Now.Hour;
            }
            int GetDays()
            {
                return DateTime.Now.Day;
            }
            int GetMonth()
            {
                return DateTime.Now.Month;
            }
            int GetYears()
            {
                return DateTime.Now.Year;
            }
        }
    }
}