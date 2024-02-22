using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    class Esemény : EventArgs
    {
        public string üzenet;
        //aki nem tudja, mit csinál a konstruktor lapozzon vissza!
        public Esemény(string str) : base()
        {
            üzenet = str;
        }
    }
}
