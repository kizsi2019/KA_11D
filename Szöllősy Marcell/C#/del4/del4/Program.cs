using del4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del4
{
    using System;
    public class Calculator : CalculatorBase
    {
        public delegate int MathOperation(int a, int b);

        public event EventHandler<MathOperation> OperationPerformed;

        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method, result));
            return result;
        }

        protected virtual void OnOperationPerformed(OperationEventArgs e)
        {
            OperationPerformed?.Invoke(this, e);
        }

    }

    public class OperationEventArgs : EventArgs
    {
        public int Operand1 { get; }
        public int Operand2 { get; }
        public string OperationName { get; }

        public int Result { get; }

        public OperationEventArgs(int operand1, int operand2, string operationName, int result)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            OperationName = operationName;
            Result = result;
        }
    }

    public class EventSubscriber
    {
        Calculator.OperationPerformed += Calculator_OperationPerformed;
    }

    private void Calculator_OperationPerformed(object sender, OperationEventArgs e)
    {
        Console.WriteLine($"Operation Performed: {e.OperationName}({e.Operand1},{e.Operand2}) = {e.Result}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        
        EventSubscriber subscriber = new EventSubscriber(Calculator);

        Calculator.MathOperation addition = (a, b) => a + b;

        Calculator.MathOperation substraction = (a, b) => a - b;
    }
}
