using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    using Microsoft.TeamFoundation.VersionControl.Client;
    using System;
    public class Calculator
    {
        public delegate int MathOperation(int a, int b);

        public event EventHandler<OperationEventArgs> OperationPerformed;

        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
