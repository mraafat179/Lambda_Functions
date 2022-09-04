internal class Program
{
    private static void Main(string[] args)
    {
        Action<int> factorial = (num) =>
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        };

        Func<int, int> factorial2 = (num) =>
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        };

        Predicate<int> facrorial3 = (num) =>
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact == 120;
        };

        factorial.Invoke(5);
        Console.WriteLine(factorial2.Invoke(5));
        Console.WriteLine(facrorial3.Invoke(5));
    }
}