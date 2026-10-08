# PalindromeChecker

Метод на C#, который проверяет, является ли строка палиндромом, игнорируя регистр, пробелы и знаки препинания.

## Метод

```csharp
public static bool IsPalindrome(string input)
```

### Примеры

| Вход | Результат |
|-------|----------|
| `"A man, a plan, a canal: Panama"` | `true` |
| `"race a car"` | `false` |
| `"Was it a car or a cat I saw?"` | `true` |
| `"Madam, I'm Adam"` | `true` |
| `"Hello, World!"` | `false` |

## Как запустить

```bash
dotnet new console -n PalindromeDemo
# скопируйте метод в Program.cs
dotnet run
```

Или просто скомпилируйте файл:

```bash
csc PalindromeChecker.cs
./PalindromeChecker.exe
```
