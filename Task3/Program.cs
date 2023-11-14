namespace Task3
{
    public class Program
    {
        static void Main()
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>();
            Func<string, int> calculateStringLength = (key) => key.Length;
            FunctionCache<string, int>.FuncDelegate funcDelegate = new FunctionCache<string, int>.FuncDelegate(calculateStringLength);

            int result1 = cache.Execute(funcDelegate, "hello", TimeSpan.FromMinutes(1));
            Console.WriteLine($"Result 1: {result1}");

            int result2 = cache.Execute(funcDelegate, "hello", TimeSpan.FromMinutes(1));
            Console.WriteLine($"Result 2: {result2}");

            Thread.Sleep(10000);

            int result3 = cache.Execute(funcDelegate, "hello", TimeSpan.FromMinutes(1));
            Console.WriteLine($"Result 3: {result3}");
        }
    }
}