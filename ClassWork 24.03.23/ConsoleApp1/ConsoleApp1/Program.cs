using System.Text;

namespace ClassWrk;
class Program
{

    static void Main(string[] args)
    {
        string _line;
        StringBuilder _valueStringBuilder = new StringBuilder();
        float _value = 0f;
        Console.WriteLine("Введите строку");
        _line = Console.ReadLine();
        for (int i = 0; i < _line.Length; i++)
        {
            char letter = _line[i];
            if (char.IsDigit(letter))
            {

                _valueStringBuilder.Append(letter);
            }
            else if (letter == '.' || letter == ',')
            {
                _valueStringBuilder.Append(',');
            }
        }
        if (_valueStringBuilder.Length == 0)
        {
            Console.WriteLine("Error. Number not found");
        }
        else
        {
            _value = float.Parse(_valueStringBuilder.ToString());
        }
    Console.WriteLine("Number = " + _value);

    }
}