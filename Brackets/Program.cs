using System;

namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depht = 0;
            int maxDepht = 0;

            char openBracket = '(';
            char closeBracket = ')';

            string userInput;

            Console.Write($"Наберите скобочное выражение использую символы '{openBracket}' и '{closeBracket}': ");
            userInput = Console.ReadLine();

            Console.WriteLine($"Ваше скобочное выражение: {userInput}.");

            for ( int i = 0; i < userInput.Length; i++)
            {
                if(userInput[i] == openBracket)
                {
                    depht++;
                }
                else if (userInput[i] == closeBracket)
                {
                    depht--;

                    if(depht < 0)
                    {
                        Console.WriteLine("Неверное выражение.");
                        return;
                    }
                }

                if(maxDepht < depht)
                {
                    maxDepht = depht;
                }
            }

            if(depht == 0)
            {
                Console.WriteLine($"Выражение корректно, максимальная глубиа: {maxDepht}.");
            }
            else
            {
                Console.WriteLine("Выражение некорректно.");
            }
        }
    }
}
