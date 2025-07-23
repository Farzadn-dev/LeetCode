public class Solution//AI help 😅
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";

        int m = num1.Length, n = num2.Length;
        int[] result = new int[m + n];

        // Reverse iterate over each digit
        for (int i = m - 1; i >= 0; i--)
        {
            int digit1 = num1[i] - '0';
            for (int j = n - 1; j >= 0; j--)
            {
                int digit2 = num2[j] - '0';
                int mul = digit1 * digit2;
                int p1 = i + j, p2 = p1 + 1;
                int sum = mul + result[p2];

                result[p2] = sum % 10;
                result[p1] += sum / 10;
            }
        }

        // Find the first non-zero index
        int index = 0;
        while (index < result.Length && result[index] == 0)
        {
            index++;
        }

        // Convert result array to string
        char[] resultArray = new char[result.Length - index];
        for (int i = index; i < result.Length; i++)
        {
            resultArray[i - index] = (char)('0' + result[i]);
        }

        return new string(resultArray);
    }
}
