namespace Classwork_05._04._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string oper = "";
            bool _success = true;
            line = line.Replace(oper, " " + oper + " ");
            value1 = TryParse(_items[0], ref _success);
            oper = _items[1].Trim();
            value2 = TryParse(_items[2], ref _success);


            float TryParse(string line, ref bool success)
            {
                float result = 0f;
                try
                {
                    result = float.Parse(line);
                }
                catch
                {
                    success = false;
                }
                return result;
            }

            List<string> Getitems(string text)
            {
                List<string> items = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in items)
                {
                    if (item == "")
                    {
                        items.RemoveAt(item);
                    }
                }
            }
            float value1 = 0;
            float value2 = 0;
            string oper = "";
            float.TryParse(items[0], out value1);
            oper = items[1].Trim();
            float.TryParse(items[2], out value2);
        }
    }
}