namespace ConsoleApplication1
{
    public static class SumOfNumbers
    {
      
        public static int SumIteration(int uptoValue)
        {
            int returnValue = 0;
            for (int i = 0; i <= uptoValue; i++)
            {
                returnValue += uptoValue;
            }
            return returnValue;
        }

        public static int sumRecursion(int uptoValue)
        {
            int returnValue = 0;
            if (uptoValue == 1)
            {
                return 1;
            }
            else
            {
                returnValue = uptoValue + sumRecursion(uptoValue -1);
            }

            return returnValue;
        }

    }
}