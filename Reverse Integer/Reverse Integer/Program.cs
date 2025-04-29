public class Solution
{
    public int Reverse(int x)
    {
        var number = x.ToString();
        var isNegative = number.StartsWith('-');
        var reversedNumber = string.Join("", number.Replace("-", "").Reverse());
        var converted = int.TryParse(isNegative ? "-" + reversedNumber : reversedNumber, out var result);
        return converted ? result : 0;
    }
}