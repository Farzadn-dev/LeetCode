public class Solution
{
    private static Dictionary<char, string> _numberLetters = new()
    {
        ['2'] = "abc",
        ['3'] = "def",
        ['4'] = "ghi",
        ['5'] = "jkl",
        ['6'] = "mno",
        ['7'] = "pqrs",
        ['8'] = "tuv",
        ['9'] = "wxyz"
    };
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        var queue = new Queue<string>();
        queue.Enqueue("");

        foreach (var digit in digits)
        {
            var queueSize = queue.Count;
            for (int i = 0; i < queueSize; i++)
            {
                var currentTemplate = queue.Dequeue();
                foreach (var c in _numberLetters[digit])
                    queue.Enqueue(currentTemplate + c);
            }
        }

        return queue.ToList();
    }
}