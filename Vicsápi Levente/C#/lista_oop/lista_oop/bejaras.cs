using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_oop
{
    public class bejaras
    {
        private List<int> lista;

        public bejaras(List<int> lista)
        {
            this.lista = lista;
        }

        public List<int> Lista
        {
            get
            {
                return lista;
            }

            set
            {
                foreach (var item in value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
