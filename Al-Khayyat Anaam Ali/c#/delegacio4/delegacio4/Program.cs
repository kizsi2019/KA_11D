using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegacio4
{
    internal class Calculator
    {
        // delegate def. amely egy két egész szánot váró függvéynre mutat
        public delegate int MathOperation(int a, int b);

        // esemény def. amelyet a műveletek végrehajtásakor tűzűnk ki
        public event EventHandler<OperationEventArgs> OperationPerformed;

        // metódus, amely elvégzni a műveletet a két egész számon
        public int PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            // esemény kiváltása, hogy jelentsük, hogy a művelet végrehajtódott
            OnOperationPerformed(new OperationEventArgs(x, y, operation.Method.Name, result));
            return result;
        }

      }