/* Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. 
 * Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, 
 * а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).
 */

Console.WriteLine("Enter password: ");

string password = Console.ReadLine();

if (password.Length < 8) // Перевірка на мінімальну довжину
{
    Console.WriteLine("Password must contain at least 8 symbols");
}
else
{
    bool hasDigits = false;
    bool hasSpecialChar = false;
    int index = 0; // Змінна для перебору символів в рядку пароля

    while (index < password.Length)
    {
        // Використав таку конструкцію для доступу до символа в рядку пароля для подальшої його(символа) перевірки
        char currentChar = password[index];

        if (currentChar >= '0' && currentChar <= '9')
        {
            hasDigits = true;
        }

        // Прийшлось перераховувати усі спеціальні символи вручну так як ми ще не проходили масиви
        else if (currentChar == '!' || currentChar == '@' || currentChar == '#' ||
                 currentChar == '$' || currentChar == '%' || currentChar == '^' ||
                 currentChar == '&' || currentChar == '*' || currentChar == '(' ||
                 currentChar == ')' || currentChar == '-' || currentChar == '_' ||
                 currentChar == '=' || currentChar == '+' || currentChar == '[' ||
                 currentChar == ']' || currentChar == '{' || currentChar == '}' ||
                 currentChar == ';' || currentChar == ':' || currentChar == '\''||
                 currentChar == '"' || currentChar == ',' || currentChar == '.' ||
                 currentChar == '/' || currentChar == '<' || currentChar == '>' ||
                 currentChar == '?' || currentChar == '\\'|| currentChar == '|' ||
                 currentChar == '`' || currentChar == '~')
        {
            hasSpecialChar = true;
        }
        if (hasSpecialChar && hasDigits)
        {
            break;
        }
        index++;
    }
    if (hasDigits && hasSpecialChar)
    {
        Console.WriteLine("The password is acceptable");
    }
    else
    {
        Console.WriteLine("Not acceptable, password must contain at least one number and one symbol");
    }
}
