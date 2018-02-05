namespace ConsoleApplication1
{
    internal class Palindrome
    {
        public static bool IsPalindromeRecursion(string input)
        {
            if((input.Length % 2 == 0))
            {
                //if even
                string[] x = new string[]
                    {input.Substring(0, input.Length / 2), input.Substring(input.Length / 2, input.Length-1)};
                return (x[0] == x[1]);

            }
            else
            {
                return IsPalindromeRecursion(input.Remove((input.Length +1)/2));
            }
        }
    }
}