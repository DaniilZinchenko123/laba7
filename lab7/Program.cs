namespace lab7
{
    public class Program
    {
        static void Main()
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine($"Addition: {intCalculator.PerformOperation(5, 3, intCalculator.Addition)}");
            Console.WriteLine($"Subtraction: {intCalculator.PerformOperation(5, 3, intCalculator.Subtraction)}");
            Console.WriteLine($"Multiplication: {intCalculator.PerformOperation(5, 3, intCalculator.Multiplication)}");
            Console.WriteLine($"Division: {intCalculator.PerformOperation(5, 3, intCalculator.Division)}");

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine($"Addition: {doubleCalculator.PerformOperation(5.5, 3.2, doubleCalculator.Addition)}");
            Console.WriteLine($"Subtraction: {doubleCalculator.PerformOperation(5.5, 3.2, doubleCalculator.Subtraction)}");
            Console.WriteLine($"Multiplication: {doubleCalculator.PerformOperation(5.5, 3.2, doubleCalculator.Multiplication)}");
            Console.WriteLine($"Division: {doubleCalculator.PerformOperation(5.5, 3.2, doubleCalculator.Division)}");
        }
    }
}