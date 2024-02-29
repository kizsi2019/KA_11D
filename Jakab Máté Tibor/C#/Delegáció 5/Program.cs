using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_5
{
    internal class Program
    {
       public class Calculator
        {
            //Delegate definiciója, amely egy két egész számot váró függvényre mutat
            public delegate int MathOperation(int a, int b);

            //Esemény definiciója, amelyet a műveletek végrehajtásakor tűzünk ki
            public event EventHandler<OperationEventArgs> OperationPerformed;

            //Metódus. amely elvégzi a műveletet a két egész szám
            public int PerformOperation(int x, int y, MathOperation operation)
            {
                int result = operation(x,y);
                //Esemény kiváltása, hogy jelentsük, hogy művelet végrehajtódott
                OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
                return result;
            }
            //Esemény kiváltása
            protected virtual void OnOperationPerformed(OperationEventArgs e)
         {
            public int Operand1 { get; }
            public int Operand2 { get; }
            public int OperationName { get; }
            public int Result { get; }
            
            public OperationEventArgs(int operand1, int operand2, string operationName, int result)
            {
                Operand1 = operand1;
                Operand2 = operand2;
                OperationName = operationName; 
                Result = result;
            }
          }
        }
    }
