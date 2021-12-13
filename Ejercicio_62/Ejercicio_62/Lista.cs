using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_62
{
    class Lista
    {
        String tiempo;
        String probabilidad;
        String acumulada;
        String rand_min;
        String rand_max;

        public Lista(string tiempo, string probabilidad, string acumulada, string rand_min, string rand_max)
        {
            this.tiempo = tiempo;
            this.probabilidad = probabilidad;
            this.acumulada = acumulada;
            this.rand_min = rand_min;
            this.rand_max = rand_max;
        }

        public string Tiempo { get => tiempo; set => tiempo = value; }
        public string Probabilidad { get => probabilidad; set => probabilidad = value; }
        public string Acumulada { get => acumulada; set => acumulada = value; }
        public string Rand_min { get => rand_min; set => rand_min = value; }
        public string Rand_max { get => rand_max; set => rand_max = value; }
    }
}
