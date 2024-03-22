using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_4
{
    using Microsoft.TeamFoundation.VersionControl.Client;
    using System;
    using System.Runtime.Remoting.Channels;

    public class Calculator
    {
        //Delegate definíciója, amely egy két egész számot váró függvényre mutat
        public delegate int MathOperation(int a, int b);

        //esemény definition amelyet a műveletek végrahajtásakor tűzűnk ki.
        public event EventHandler<OperationEventArgs> OperationPerformed;

        //metódus, amely elvégzi a műveletet a két egész számon
        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            //esemény kiváltása, hogy jelentsük, hogy művelet végrehajtódott
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }

        //Esemény kiváltása
        protected virtual void OnOperationPerformed(OperationEventArgs e)
        {
            OperationPerformed?.Invoke(this, e);
        }

        //Esemény argumentum osztály
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
        //feliratkozó osztály az események kezelésére
        public class EventSubscirber
        {
            //konstruktor, amely feliratkozik az eseményre
            public EventSubscirber(Calculator calculator)
            {
                calculator.OperationPerformed += Calculator_OperationPerformed;
            }
            //eseménykezelő
            private void Calculator_OperationPerformed(object, IChannelSender, OperationEventArgs e)
            {
                Console.WriteLine($"Operation performed: {e.OperationName}({e.Operand1},{e.Operand2})" +
                    $" = {e.Result}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //calculator objektum létrehozása
                Calculator calculator = new Calculator();
                //Event subscriber objektum létrehozása + feliratkozás az eventre
                EventSubscirber subscirber = new EventSubscirber(calculator);

                //összeadás művelet delegált létrehozás
                Calculator.MathOperation addition = (a, b) => a + b;

                Calculator.MathOperation subtraction = (a, b) => a - b;

                Calculator.MathOperation multiplication = (a, b) => a * b;

                int result1 = calculator.PerformOperaton(5, 3, addition);
                int result2 = calculator.PerformOperation(8, 4, subtraction);
            }
        }
    }

}