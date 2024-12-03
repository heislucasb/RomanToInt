public class Solution
{
    public static int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && LetterToInt(s[i]) > LetterToInt(s[i - 1]))
            {
                result += LetterToInt(s[i]) - 2 * LetterToInt(s[i - 1]);
            }
            else
            {
                result += LetterToInt(s[i]);
            }
        }
        return result;
    }

    public static int LetterToInt(char a)
    {
        return a switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0,
        };
    }

    public static bool IsRomanNumbers(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        s = s.ToUpper();

        if (s.Length == 0)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (LetterToInt(s[i]) == 0)
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        //string numbers = "X";

        Console.WriteLine("Please type a Roman number and press Enter:");

        string numbers = Console.ReadLine();


        if (IsRomanNumbers(numbers))
            Console.WriteLine($"The Roman number represents {RomanToInt(numbers)}");
        else Console.WriteLine($"The value {numbers} is not a Roman number");
    }
}