using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_62
{
    class Pieza
    {
        Int32 id;
        String estado;

        public Pieza(Int32 nro_pieza)
        {
            this.id = nro_pieza;
            this.estado = Estado_Pieza.EFu;
        }

        public int Id { get => id; set => id = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
