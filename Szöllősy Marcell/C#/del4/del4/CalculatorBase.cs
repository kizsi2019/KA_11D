namespace del4
{
    public class CalculatorBase
    {

        public int PerformOperation(
            int x,
            int y,
            MathOperation operation)
        {
            int result = operation(x, y);

        }
    }
}