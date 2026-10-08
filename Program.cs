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
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== Проверка палиндрома ===");
        Console.WriteLine("Введите строку (или 'exit' для выхода):");
        Console.WriteLine();

        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Пустая строка. Попробуйте ещё раз.");
                continue;
            }

            if (input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                input.Trim().Equals("выход", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("До свидания!");
                break;
            }

            bool result = IsPalindrome(input);

            if (result)
                Console.WriteLine($"✓ \"{input}\" — это палиндром!");
            else
                Console.WriteLine($"✗ \"{input}\" — НЕ палиндром.");

            Console.WriteLine();
        }
    }
}
