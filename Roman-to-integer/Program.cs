public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            // Якщо поточний символ менший за наступний, віднімаємо його значення
            if (i < s.Length - 1 && romanMap[s[i]] < romanMap[s[i + 1]])
            {
                result -= romanMap[s[i]];
            }
            else
            {
                // В іншому випадку додаємо його значення
                result += romanMap[s[i]];
            }
        }

        return result;
    }
}
