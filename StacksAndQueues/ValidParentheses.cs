namespace StacksAndQueues;

public static class ValidParentheses
{
    public static class Solution
    {
        private static HashSet<char> openingBraces = new HashSet<char>()
            {
                '(',
                '[',
                '{'
            };

        private static HashSet<char> closingBraces = new HashSet<char>()
            {
                ')',
                ']',
                '}'
            };

        private static Dictionary<char, char> openingBracesByClosingBraces = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
        public static bool IsValid(string s)
        {
            var parenthesesStack = new Stack<char>();


            foreach (char c in s)
            {
                if (openingBraces.Contains(c))
                {
                    parenthesesStack.Push(c);
                    continue;
                }

                if (closingBraces.Contains(c))
                {
                    if (parenthesesStack.Count == 0 || parenthesesStack.Pop() != openingBracesByClosingBraces[c])
                    {
                        return false;
                    }
                }
            }
            return parenthesesStack.Count == 0;
        }
    }
}
