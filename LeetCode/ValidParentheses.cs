namespace LeetCode
{
    public static class ValidParentheses
    {
        public static bool IsValidSolution(string s)
        {
            Stack<char> stack = new();
            Dictionary<char, char> parents = new()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            foreach (var c in s)
            {
                if (parents.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (parents.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != parents[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
