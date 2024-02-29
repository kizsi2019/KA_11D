using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegacio4
{
    using Microsoft.TeamFoundation.VersionControl.Client;
    using Microsoft.VisualStudio.Services.Commerce;
    using System;
    public class Calculator
    {

        public delegate int MathOperation(int a, int b);


        public event EventHandler<OperationEventArgs> OperationPerfomred;


        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);

            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
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

    
    }




        static void Main(string[] args)
        {
        }
    }
}
