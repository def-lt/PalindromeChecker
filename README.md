# PalindromeChecker

Метод на C#, который проверяет, является ли строка палиндромом, игнорируя регистр, пробелы и знаки препинания.

## Как запустить

```bash
git clone https://github.com/def-lt/PalindromeChecker.git
cd PalindromeChecker
dotnet run
```

## Метод

```csharp
public static bool IsPalindrome(string? input)
```

### Примеры

| Вход | Результат |
|-------|----------|
| `"A man, a plan, a canal: Panama"` | `true` |
| `"race a car"` | `false` |
| `"Was it a car or a cat I saw?"` | `true` |
| `"Madam, I'm Adam"` | `true` |
| `"Hello, World!"` | `false` |
| `"А роза упала на лапу Азора"` | `true` |

## Как работает

1. Убирает все символы, кроме букв и цифр
2. Приводит к нижнему регистру
3. Сравнивает символы с начала и с конца
