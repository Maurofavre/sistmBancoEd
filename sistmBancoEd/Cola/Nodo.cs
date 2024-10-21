using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistmBancoEd.Cola
{
        public class Nodo
        {
            public int DNI { get; set; }
            public string Nombre { get; set; }
            public Nodo Siguiente { get; set; }
            public bool Cliente { get; set; }


        public Nodo(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Siguiente = null;
            this.Cliente = false;
        }
    }

    
}
