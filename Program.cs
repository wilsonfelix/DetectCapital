using System;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        return word == word.ToUpper() || word == word.ToLower() ||
               (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower());
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        while (true)
        {
            Console.Write("Digite uma palavra (ou 'sair' para encerrar): ");
            string word = Console.ReadLine();

            if (word.ToLower() == "sair")
                break;

            bool result = solution.DetectCapitalUse(word);
            Console.WriteLine($"Palavra: {word}");
            Console.WriteLine($"Está correta de acordo com as regras? {result}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
