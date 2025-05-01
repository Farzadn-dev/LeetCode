using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        var sb = new StringBuilder();

        while (num > 0)
        {
            switch (num)
            {
                case >= 1000:
                    {
                        sb.Append("M");
                        num -= 1000;
                        break;
                    }
                case >= 900 and <= 999:
                    {
                        sb.Append("CM");
                        num -= 900;
                        break;
                    }
                case >= 500 and <= 899:
                    {
                        sb.Append("D");
                        num -= 500;
                        break;
                    }
                case >= 400 and <= 499:
                    {
                        sb.Append("CD");
                        num -= 400;
                        break;
                    }
                case >= 100 and <= 399:
                    {
                        sb.Append("C");
                        num -= 100;
                        break;
                    }
                case >= 90 and <= 99:
                    {
                        sb.Append("XC");
                        num -= 90;
                        break;
                    }
                case >= 50 and <= 89:
                    {
                        sb.Append("L");
                        num -= 50;
                        break;
                    }
                case >= 40 and <= 49:
                    {
                        sb.Append("XL");
                        num -= 40;
                        break;
                    }
                case >= 10 and <= 39:
                    {
                        sb.Append("X");
                        num -= 10;
                        break;
                    }
                case 9:
                    {
                        sb.Append("IX");
                        num -= 9;
                        break;
                    }
                case >= 5 and <= 8:
                    {
                        sb.Append("V");
                        num -= 5;
                        break;
                    }
                case 4:
                    {
                        sb.Append("IV");
                        num -= 4;
                        break;
                    }
                case >= 1 and <= 3:
                    {
                        sb.Append("I");
                        num -= 1;
                        break;
                    }
                default:
                    return sb.ToString();
            }
        }
        return sb.ToString();
    }
}