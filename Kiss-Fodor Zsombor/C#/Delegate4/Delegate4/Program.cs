using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    public class Calculator
    {
        //
        public delegate int MathOperator(int a, int b);

        //
        public event EventHandler<OperationEventArgs> OperationPerformed;

        //
        public int PerformOperation(int x, int y, MathOperator operation)
        {
            int result = operation(x, y);
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }
public class OperationEventArgs
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
