using Generador.Distribuciones;
using Generador.GeneradoresRandom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_62
{
    class VectorEstado
    {
        IGeneradorRND g_rnd = new Lenguaje();
        List<Lista> e_llegada_pieza;
        IDistribucion e_forjado;
        IDistribucion e_fundido;
        IDistribucion e_terminado;
        String e_enfriado;

        List<Pieza> piezas = new List<Pieza>();

        Int32 nro_pieza = 0;

        String nombreEvento;
        String reloj;

        //Evento Llegada Proxima Pieza
        String rnd_llegada_pieza;
        String tiempo_entre_llegada_pieza;
        String tiempo_proxima_llegada_pieza;

        //Evento Fin Fundicion
        String rnd_fin_fundicion;
        String tiempo_entre_fin_fundicion;
        String tiempo_proximo_fin_fundicion;

        //Evento Fin Forjado
        String rnd_fin_forjado;
        String tiempo_entre_fin_forjado;
        String tiempo_proximo_fin_forjado;

        //Evento Fin Enfriado
        String tiempo_proximo_fin_enfriado;

        //Evento Fin Terminado
        String rnd_fin_terminado;
        String tiempo_entre_fin_terminado;
        String tiempo_proximo_fin_terminado;



        Int32 cola_fundicion = 0;
        Int32 cola_forjado = 0;
        Int32 cola_enfriado = 0;
        Int32 cola_terminado = 0;


        public string NombreEvento { get => nombreEvento; set => nombreEvento = value; }
        public string Reloj { get => reloj; set => reloj = value; }
        public string Rnd_llegada_pieza { get => rnd_llegada_pieza; set => rnd_llegada_pieza = value; }
        public string Tiempo_entre_llegada_pieza { get => tiempo_entre_llegada_pieza; set => tiempo_entre_llegada_pieza = value; }
        public string Tiempo_proxima_llegada_pieza { get => tiempo_proxima_llegada_pieza; set => tiempo_proxima_llegada_pieza = value; }
        internal List<Pieza> Piezas { get => piezas; set => piezas = value; }
        public string Rnd_fin_fundicion { get => rnd_fin_fundicion; set => rnd_fin_fundicion = value; }
        public string Tiempo_entre_fin_fundicion { get => tiempo_entre_fin_fundicion; set => tiempo_entre_fin_fundicion = value; }
        public string Tiempo_proximo_fin_fundicion { get => tiempo_proximo_fin_fundicion; set => tiempo_proximo_fin_fundicion = value; }
        public int Cola_fundicion { get => cola_fundicion; set => cola_fundicion = value; }
        public int Cola_forjado { get => cola_forjado; set => cola_forjado = value; }
        public string Rnd_fin_forjado { get => rnd_fin_forjado; set => rnd_fin_forjado = value; }
        public string Tiempo_entre_fin_forjado { get => tiempo_entre_fin_forjado; set => tiempo_entre_fin_forjado = value; }
        public string Tiempo_proximo_fin_forjado { get => tiempo_proximo_fin_forjado; set => tiempo_proximo_fin_forjado = value; }
        public int Cola_enfriado { get => cola_enfriado; set => cola_enfriado = value; }
        public string Tiempo_proximo_fin_enfriado { get => tiempo_proximo_fin_enfriado; set => tiempo_proximo_fin_enfriado = value; }
        public string Rnd_fin_terminado { get => rnd_fin_terminado; set => rnd_fin_terminado = value; }
        public string Tiempo_entre_fin_terminado { get => tiempo_entre_fin_terminado; set => tiempo_entre_fin_terminado = value; }
        public string Tiempo_proximo_fin_terminado { get => tiempo_proximo_fin_terminado; set => tiempo_proximo_fin_terminado = value; }
        public int Cola_terminado { get => cola_terminado; set => cola_terminado = value; }

        public VectorEstado()
        {
            this.nombreEvento = "Inicio";
            this.reloj = "0";
        }

        public void llegada_pieza(List<Lista> lista)
        {
            this.e_llegada_pieza = lista;
        }

        public void forjado(double A, double B)
        {
            this.e_forjado = new Uniforme(A, B, g_rnd);
        }

        public void fundido(double A, double B)
        {
            this.e_fundido = new Uniforme(A, B, g_rnd);
        }

        public void terminado(double A, double B)
        {
            this.e_terminado = new Uniforme(A, B, g_rnd);
        }

        public void enfriado(double tiempo_enfriado)
        {
            this.e_enfriado = tiempo_enfriado.ToString();
        }

        public Int32 nueva_pieza()
        {
            nro_pieza++;

            Pieza x = new Pieza(nro_pieza);
            this.piezas.Add(x);

            //this.piezas[this.piezas.Count - 1].Id = this.piezas.Count;

            return x.Id;
        }

        public void actualizar_pieza(int id, String estado)
        {
            foreach (Pieza item in this.piezas)
            {
                if (item.Id == id)
                {
                    item.Estado = estado;
                    return;
                }
            }
        }


        public void evento_proxima_llegada()
        {
            double rnd = g_rnd.generar();
            double tiempo_entre = -1;

            foreach (Lista item in this.e_llegada_pieza)
            {
                double min = Convert.ToDouble(item.Rand_min);
                double max = Convert.ToDouble(item.Rand_max);

                if (min <= rnd && max > rnd)
                {
                    tiempo_entre = Convert.ToDouble(item.Tiempo);
                }
            }

            if (tiempo_entre == -1) //Si es -1, entonces, es el ultimo valor
                tiempo_entre = Convert.ToDouble(this.e_llegada_pieza[this.e_llegada_pieza.Count-1].Tiempo);


            this.rnd_llegada_pieza = rnd.ToString();
            this.tiempo_entre_llegada_pieza = tiempo_entre.ToString();
            this.tiempo_proxima_llegada_pieza = (Convert.ToDouble(this.reloj) + Convert.ToDouble(this.tiempo_entre_llegada_pieza)).ToString();
        }

        public void evento_proximo_fin_fundicion()
        {
            double tiempo_entre = this.e_fundido.ObtenerNumero();
            double rnd = this.e_fundido.ObtenerRND();

            this.rnd_fin_fundicion = rnd.ToString();
            this.tiempo_entre_fin_fundicion = tiempo_entre.ToString();
            this.tiempo_proximo_fin_fundicion = (Convert.ToDouble(this.reloj) + Convert.ToDouble(this.tiempo_entre_fin_fundicion)).ToString();
        }

        public int buscar_id_pieza(string estado_pieza)
        {
            foreach (Pieza item in this.piezas)
            {
                if (item.Estado == estado_pieza)
                {
                    return item.Id;
                }
            }

            return -1;
        }


        public void evento_proximo_fin_forjado()
        {
            double tiempo_entre = this.e_forjado.ObtenerNumero();
            double rnd = this.e_forjado.ObtenerRND();

            this.rnd_fin_forjado = rnd.ToString();
            this.tiempo_entre_fin_forjado = tiempo_entre.ToString();
            this.tiempo_proximo_fin_forjado = (Convert.ToDouble(this.reloj) + Convert.ToDouble(this.tiempo_entre_fin_forjado)).ToString();
        }

        public void evento_proximo_fin_enfriado()
        {
            this.tiempo_proximo_fin_enfriado = (Convert.ToDouble(this.reloj) + Convert.ToDouble(this.e_enfriado)).ToString();
        }

        public void evento_proximo_fin_terminado()
        {
            double tiempo_entre = this.e_terminado.ObtenerNumero();
            double rnd = this.e_terminado.ObtenerRND();

            this.rnd_fin_terminado = rnd.ToString();
            this.tiempo_entre_fin_terminado = tiempo_entre.ToString();
            this.tiempo_proximo_fin_terminado = (Convert.ToDouble(this.reloj) + Convert.ToDouble(this.tiempo_entre_fin_terminado)).ToString();
        }

        public void eliminar_pieza(int id_fin)
        {
            for (int i = 0; i < this.piezas.Count; i++)
            {
                if (this.piezas[i].Id == id_fin)
                {
                    this.piezas.RemoveAt(i);
                    return;
                }
            }
        }
    }

}
