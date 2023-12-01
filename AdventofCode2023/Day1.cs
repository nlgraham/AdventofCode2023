/* Day1.cs
 * Author: Natasha Graham
 * Date Created: 2023-12-01
 */


int total = 0;

string input = Console.ReadLine();

while (!input.Equals("end"))
{
    int digit1 = 0;
    int digitlast = 0;

    foreach (Char c in input)
    {
        digit1 = c - '0';
        if (digit1 >= 0 && digit1 <= 9)
        {
            digit1 *= 10;
            break;
        }
    }

    for (int i = input.Length - 1; i >= 0; i--)
    {
        char c = input[i];
        digitlast = c - '0';
        if (digitlast >= 0 && digitlast <= 9)
        {
            break;
        }
    }

    int line = digit1 + digitlast;

    total += line;

    input = Console.ReadLine();
}

Console.WriteLine(total);