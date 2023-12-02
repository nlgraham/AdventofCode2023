/* Day1.cs
 * Author: Natasha Graham
 * Date Created: 2023-12-01
 */


int total = 0;

string? input = Console.ReadLine();

while (!input.Equals("end"))
{
    int digit1 = 0;
    int digitlast = 0;

    for(int i = 0; i < input.Length; i++)
    {
        digit1 = input[i] - '0';
        if (digit1 >= 0 && digit1 <= 9)
        {
            break;
        }

        try { digit1 = firstDigit(i, input); }
        catch { continue; }

        if (digit1 != -1)
            break;
    }

    for (int i = input.Length - 1; i >= 0; i--)
    {
        char c = input[i];
        digitlast = c - '0';
        if (digitlast >= 0 && digitlast <= 9)
        {
            break;
        }

        try { digitlast = lastDigit(i, input); }
        catch { continue; }

        if (digitlast != -1)
            break;
    }

    int line = (digit1 * 10) + digitlast;

    total += line;

    input = Console.ReadLine();
}

Console.WriteLine(total);

int firstDigit(int i, string input)
{
    switch (input[i])
    {
        case 'o':
            if (input.Substring(i, 3).Equals("one"))
            { return 1; }
            break;
        case 't':
            if (input.Substring(i, 3).Equals("two"))
            { return 2; }
            else if (input.Substring(i, 5).Equals("three"))
            { return 3; }
            break;
        case 'f':
            if (input.Substring(i, 4).Equals("four"))
            { return 4; }
            if (input.Substring(i, 4).Equals("five"))
            { return 5; }
            break;
        case 's':
            if (input.Substring(i, 3).Equals("six"))
            { return 6; }
            if (input.Substring(i, 5).Equals("seven"))
            { return 7; }
            break;
        case 'e':
            if (input.Substring(i, 5).Equals("eight"))
            { return 8; }
            break;
        case 'n':
            if (input.Substring(i, 4).Equals("nine"))
            { return 9; }
            break;
        default:
            return -1;
    }

    return -1;
}

int lastDigit(int i, string input)
{
    switch (input[i])
    {
        case 'e':
            if (input.Substring(i-2, 3).Equals("one"))
            { return 1; }
            else if (input.Substring(i-4, 5).Equals("three"))
            { return 3; }
            else if (input.Substring(i-3, 4).Equals("five"))
            { return 5; }
            else if (input.Substring(i-3, 4).Equals("nine"))
            { return 9; }
            break;
        case 'o':
            if (input.Substring(i-2, 3).Equals("two"))
            { return 2; }
            break;
        case 'r':
            if (input.Substring(i-3, 4).Equals("four"))
            { return 4; }
            break;
        case 'x':
            if (input.Substring(i-2, 3).Equals("six"))
            { return 6; }
            break;
        case 't':
            if (input.Substring(i-4, 5).Equals("eight"))
            { return 8; }
            break;
        case 'n':
            if (input.Substring(i - 4, 5).Equals("seven"))
            { return 7; }
            break;
        default:
            return -1;
    }

    return -1;
}