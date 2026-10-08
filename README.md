# PalindromeChecker

Программа на C#, которая проверяет, является ли введённая строка палиндромом.

Игнорирует регистр, пробелы и знаки препинания.

## Как запустить

```bash
git clone https://github.com/def-lt/PalindromeChecker.git
cd PalindromeChecker
dotnet run
```

Или откройте папку в Visual Studio / Rider и нажмите F5.

## Как пользоваться

1. Запусти программу
2. Введи любую строку
3. Программа скажет, палиндром это или нет
4. Для выхода напиши `exit` или `выход`

### Примеры

```
> A man, a plan, a canal: Panama
✓ "A man, a plan, a canal: Panama" — это палиндром!

> А роза упала на лапу Азора
✓ "А роза упала на лапу Азора" — это палиндром!

> Привет
✗ "Привет" — НЕ палиндром.
```

## Метод

```csharp
public static bool IsPalindrome(string? input)
```
