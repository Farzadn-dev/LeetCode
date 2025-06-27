public class Solution
{
    public int StrStr(string haystack, string needle)
    {

        for (int i = 0; i < haystack.Length; i++)
            if (haystack[i] == needle[0])
                if (i + needle.Length < haystack.Length && haystack[i..(i + needle.Length)] == needle)
                    return i;
        return -1;
    }
}


#region Chatgpt Way
//public class Solution
//{
//    public int StrStr(string haystack, string needle)
//    {
//        if (string.IsNullOrEmpty(needle)) return 0;

//        int[] lps = BuildLPS(needle);
//        int i = 0, j = 0;

//        while (i < haystack.Length)
//        {
//            if (haystack[i] == needle[j])
//            {
//                i++;
//                j++;
//                if (j == needle.Length)
//                    return i - j;
//            }
//            else if (j > 0)
//            {
//                j = lps[j - 1];
//            }
//            else
//            {
//                i++;
//            }
//        }

//        return -1;
//    }

//    private int[] BuildLPS(string pattern)
//    {
//        int[] lps = new int[pattern.Length];
//        int length = 0; // length of the previous longest prefix suffix
//        int i = 1;

//        while (i < pattern.Length)
//        {
//            if (pattern[i] == pattern[length])
//            {
//                length++;
//                lps[i] = length;
//                i++;
//            }
//            else if (length > 0)
//            {
//                length = lps[length - 1];
//            }
//            else
//            {
//                lps[i] = 0;
//                i++;
//            }
//        }

//        return lps;
//    }
//}
#endregion

