using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_bejaras
{
    public class Bejaras
    {
        
        public List<int> Lista { get; private set; }
        public Bejaras(List<int> lista)
        {
            Lista = lista;
        }
        public void Kiiras()
        {
            foreach (var item in Lista)
            {
                Console.Write(item + " ");
            }
        }
    }
}
