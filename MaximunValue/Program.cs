class Solution 
{
    public int solution(int N) 
    { 
        string numberString = N.ToString();
        if (N >= 0)
        {
            for (int i = 0; i < numberString.Length; i++)
            {
                if (numberString[i] < '5')
                {
                    return int.Parse(numberString.Substring(0, i) + '5' + numberString.Substring(i));
                }
            }
            return int.Parse(numberString + '5');
        }
        else
        {
            for (int i = 1; i < numberString.Length; i++)
            {
                if (numberString[i] > '5')
                {
                    return int.Parse(numberString.Substring(0, i) + '5' + numberString.Substring(i));
                }
            }
            return int.Parse(numberString + '5');
        }
    }

    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine("Given N = 268. Result = " + solution.solution(268));
        Console.WriteLine("Given N = 670. Result = " + solution.solution(670));
        Console.WriteLine("Given N = 0. Result = " + solution.solution(0));
        Console.WriteLine("Given N = -999. Result = " + solution.solution(-999));
    }
}