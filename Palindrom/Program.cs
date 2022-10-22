using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        string str;
        Console.WriteLine("\t\t\tПаліндром");
        str = Console.ReadLine();
        char[] chars = str.ToCharArray();
        char[] chars1 = str.ToCharArray();

        Array.Reverse(chars);
        Console.WriteLine(chars);
        for(int i = 0; i < chars1.Length; i++)
        {
            if (chars[i] != chars1[i])
            {
                Console.WriteLine("не Паліндром");
                return;
            }
        }
        Console.WriteLine("Це паліндром");
    }
}
