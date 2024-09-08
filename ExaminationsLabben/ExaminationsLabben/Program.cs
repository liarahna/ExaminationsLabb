using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write a string of numbers: ");
        string input = Console.ReadLine();
        HighLight(input);
    }

    public static void HighLight(string input)
    {


        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsDigit(input[i]))
            {
            }
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    string highlighted = input[i] + input.Substring(i + 1, j - i - 1) + input[j];

                    if (Regex.IsMatch(highlighted, "[a-zA-Z]"))
                    {
                        break;
                    }
                    Console.Write(input.Substring(0, i));

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(input[i]);


                    Console.Write(input.Substring(i + 1, j - i - 1));

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(input[j]);

                    Console.ResetColor();
                    Console.WriteLine(input.Substring(j + 1));
                    continue;
                }
            }
        }
    }
}