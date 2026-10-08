using System.Text;

class Program
{
    /// <summary>
    /// Проверяет, является ли строка палиндромом,
    /// игнорируя регистр, пробелы и знаки препинания.
    /// </summary>
    public static bool IsPalindrome(string? input)
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

    static void Main()
    {
        string[] tests =
        {
            "A man, a plan, a canal: Panama",
            "race a car",
            "Was it a car or a cat I saw?",
            "",
            "Madam, I'm Adam",
            "Hello, World!",
            "А роза упала на лапу Азора"
        };

        foreach (var test in tests)
        {
            Console.WriteLine($"\"{test}\"  ->  {IsPalindrome(test)}");
        }
    }
}
