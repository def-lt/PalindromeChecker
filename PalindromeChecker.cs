using System;
using System.Linq;
using System.Text;

public static class PalindromeChecker
{
    /// <summary>
    /// Проверяет, является ли строка палиндромом,
    /// игнорируя регистр, пробелы и знаки препинания.
    /// </summary>
    /// <param name="input">Входная строка</param>
    /// <returns>true, если строка является палиндромом</returns>
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        // Оставляем только буквы и цифры, приводим к нижнему регистру
        var cleaned = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleaned.Append(char.ToLowerInvariant(c));
            }
        }

        string s = cleaned.ToString();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }

        return true;
    }

    // Пример использования
    public static void Main(string[] args)
    {
        string[] tests = {
            "A man, a plan, a canal: Panama",
            "race a car",
            "Was it a car or a cat I saw?",
            "",
            "Madam, I'm Adam",
            "Hello, World!"
        };

        foreach (var test in tests)
        {
            Console.WriteLine($"\"{test}\" -> {IsPalindrome(test)}");
        }
    }
}
