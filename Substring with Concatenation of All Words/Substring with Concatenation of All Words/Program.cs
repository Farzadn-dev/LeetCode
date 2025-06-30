public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        var result = new List<int>();
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0)
            return result;

        int wordLen = words[0].Length;
        int numWords = words.Length;
        int totalLen = wordLen * numWords;
        int n = s.Length;

        // Build frequency map of words
        var target = new Dictionary<string, int>(StringComparer.Ordinal);
        foreach (var w in words)
        {
            if (target.ContainsKey(w))
                target[w]++;
            else
                target[w] = 1;
        }

        // Scan with different offsets
        for (int offset = 0; offset < wordLen; offset++)
        {
            int left = offset;
            int count = 0;
            var windowCount = new Dictionary<string, int>(StringComparer.Ordinal);

            for (int right = offset; right + wordLen <= n; right += wordLen)
            {
                string w = s.Substring(right, wordLen);

                if (target.ContainsKey(w))
                {
                    // Add this word into the window
                    if (windowCount.ContainsKey(w))
                        windowCount[w]++;
                    else
                        windowCount[w] = 1;
                    count++;

                    // If there are too many of this word, move left pointer
                    while (windowCount[w] > target[w])
                    {
                        string leftWord = s.Substring(left, wordLen);
                        windowCount[leftWord]--;
                        left += wordLen;
                        count--;
                    }

                    // If we have a valid window
                    if (count == numWords)
                    {
                        result.Add(left);
                        // Slide window by one word to look for overlapping matches
                        string leftWord = s.Substring(left, wordLen);
                        windowCount[leftWord]--;
                        left += wordLen;
                        count--;
                    }
                }
                else
                {
                    // Reset window
                    windowCount.Clear();
                    count = 0;
                    left = right + wordLen;
                }
            }
        }

        return result;
    }
}

//Copilet Code :)
