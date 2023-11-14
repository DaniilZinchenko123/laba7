namespace lab7
{
    public class Calculator<T>
    {
        public delegate T ArithmeticOperationDelegate(T x, T y);

        public ArithmeticOperationDelegate Addition { get; } = (x, y) => (dynamic)x + y;
        public ArithmeticOperationDelegate Subtraction { get; } = (x, y) => (dynamic)x - y;
        public ArithmeticOperationDelegate Multiplication { get; } = (x, y) => (dynamic)x * y;
        public ArithmeticOperationDelegate Division { get; } = (x, y) =>
        {
            if (y.Equals((dynamic)0))
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (dynamic)x / y;
        };

        public T PerformOperation(T operand1, T operand2, ArithmeticOperationDelegate operation)
        {
            return operation(operand1, operand2);
        }
    }
}