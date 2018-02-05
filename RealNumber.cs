namespace ConsoleApplication1
{
    public static class RealNumber
    {
        public static bool Isreal(string input)
        {
            decimal x;
            return (decimal.TryParse(input, out x));
        }
    }
}