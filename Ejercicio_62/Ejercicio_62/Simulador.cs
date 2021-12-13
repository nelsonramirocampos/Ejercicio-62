using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_62
{
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();

            dgv_llegada_pieza.Columns.Add("cTiempo", "Tiempo");
            dgv_llegada_pieza.Columns.Add("cProbabilidad", "Pr");
            dgv_llegada_pieza.Columns.Add("cAcumulada", "Acu.");
            dgv_llegada_pieza.Columns.Add("cRandMin", "Rand Min");
            dgv_llegada_pieza.Columns.Add("cRandMax", "Rand Max");
            dgv_llegada_pieza.Columns["cTiempo"].Frozen = true;

        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            cargar_valores();
            generar_grilla();
        }

        private void generar_grilla()
        {
            dgv_grilla.Columns.Add("cEvento", "Evento");
            dgv_grilla.Columns.Add("cReloj", "Reloj");

            dgv_grilla.Columns.Add("cRndLlegadaPieza", "RND");
            dgv_grilla.Columns.Add("cTiempoEntreLlegadaPieza", "Tiempo Entre Llegada");
            dgv_grilla.Columns.Add("cProximaLlegada", "Prox. Llegada");

            dgv_grilla.Columns.Add("cRndFinFundicion", "RND");
            dgv_grilla.Columns.Add("cTiempoEntreFinFundicion", "Tiempo Entre Fin Fundicion");
            dgv_grilla.Columns.Add("cProximoFinFundicion", "Prox. Fin Fundicion");

            dgv_grilla.Columns.Add("cRndFinForjado", "RND");
            dgv_grilla.Columns.Add("cTiempoEntreFinForjado", "Tiempo Entre Fin Forjado");
            dgv_grilla.Columns.Add("cProximoFinForjado", "Prox. Fin Forjado");

            dgv_grilla.Columns.Add("cProximoFinEnfriado", "Prox. Fin Enfriado");

            dgv_grilla.Columns.Add("cRndFinTerminado", "RND");
            dgv_grilla.Columns.Add("cTiempoEntreFinTerminado", "Tiempo Entre Fin Terminado");
            dgv_grilla.Columns.Add("cProximoFinTerminado", "Prox. Fin Terminado");


            dgv_grilla.Columns.Add("cColaFundicion", "Cola Fundir");
            dgv_grilla.Columns.Add("cColaFojado", "Cola Forjar");
            dgv_grilla.Columns.Add("cColaEnfriado", "Cola Enfriar");
            dgv_grilla.Columns.Add("cColaTerminado", "Cola Terminar");
        }

        private void grabar_grilla(VectorEstado vector_estado)
        {
            dgv_grilla.Rows.Add();
            int i = dgv_grilla.Rows.Count-1;


            dgv_grilla["cEvento", i].Value = vector_estado.NombreEvento;
            dgv_grilla["cReloj", i].Value = vector_estado.Reloj;

            dgv_grilla["cRndLlegadaPieza", i].Value = vector_estado.Rnd_llegada_pieza;
            dgv_grilla["cTiempoEntreLlegadaPieza", i].Value = vector_estado.Tiempo_entre_llegada_pieza;
            dgv_grilla["cProximaLlegada", i].Value = vector_estado.Tiempo_proxima_llegada_pieza;


            dgv_grilla["cRndFinFundicion", i].Value = vector_estado.Rnd_fin_fundicion;
            dgv_grilla["cTiempoEntreFinFundicion", i].Value = vector_estado.Tiempo_entre_fin_fundicion;
            dgv_grilla["cProximoFinFundicion", i].Value = vector_estado.Tiempo_proximo_fin_fundicion;


            dgv_grilla["cRndFinForjado", i].Value = vector_estado.Rnd_fin_forjado;
            dgv_grilla["cTiempoEntreFinForjado", i].Value = vector_estado.Tiempo_entre_fin_forjado;
            dgv_grilla["cProximoFinForjado", i].Value = vector_estado.Tiempo_proximo_fin_forjado;


            dgv_grilla["cProximoFinEnfriado", i].Value = vector_estado.Tiempo_proximo_fin_enfriado;


            dgv_grilla["cRndFinTerminado", i].Value = vector_estado.Rnd_fin_terminado;
            dgv_grilla["cTiempoEntreFinTerminado", i].Value = vector_estado.Tiempo_entre_fin_terminado;
            dgv_grilla["cProximoFinTerminado", i].Value = vector_estado.Tiempo_proximo_fin_terminado;



            dgv_grilla["cColaFundicion", i].Value = vector_estado.Cola_fundicion;
            dgv_grilla["cColaFojado", i].Value = vector_estado.Cola_forjado;
            dgv_grilla["cColaEnfriado", i].Value = vector_estado.Cola_enfriado;
            dgv_grilla["cColaTerminado", i].Value = vector_estado.Cola_terminado;


            foreach (Pieza pieza in vector_estado.Piezas)
            {
                if (dgv_grilla.Columns.Contains("cPieza" + pieza.Id) == false)
                {
                    dgv_grilla.Columns.Add("cPieza" + pieza.Id, "Pieza " + pieza.Id);
                }

                dgv_grilla["cPieza" + pieza.Id, i].Value = pieza.Estado;
            }
        }

        private void cargar_valores()
        {
            txt_tiempo_simulacion.Text = "100";
            txt_desde_simular.Text = "0";
            txt_hasta_simular.Text = "20";

            dgv_llegada_pieza.Rows.Add("1", "0,3");
            dgv_llegada_pieza.Rows.Add("2", "0,2");
            dgv_llegada_pieza.Rows.Add("3", "0,2");
            dgv_llegada_pieza.Rows.Add("4", "0,3");
            calcularIntervalo();

            cb_distribucion_fundicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_distribucion_fundicion.Items.Add("Uniforme");
            cb_distribucion_fundicion.SelectedIndex = 0;
            txt_fundicion_A.Text = "2";
            txt_fundicion_B.Text = "4";


            cb_distribucion_forjado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_distribucion_forjado.Items.Add("Uniforme");
            cb_distribucion_forjado.SelectedIndex = 0;
            txt_forjado_A.Text = "3";
            txt_forjado_B.Text = "6";


            cb_distribucion_terminado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_distribucion_terminado.Items.Add("Uniforme");
            cb_distribucion_terminado.SelectedIndex = 0;
            txt_terminado_A.Text = "3";
            txt_terminado_B.Text = "7";


            txt_tiempo_enfriado.Text = "10";
        }

        private void calcularIntervalo()
        {
            double acu = 0;
            double rand_min = 0;
            double rand_max = 0;

            for (int i = 0; i < dgv_llegada_pieza.Rows.Count; i++)
            {
                acu = acu + Convert.ToDouble(dgv_llegada_pieza["cProbabilidad", i].Value);
                dgv_llegada_pieza["cAcumulada", i].Value = acu;

                //rand_max = acu - 0.001;
                rand_max = acu;

                dgv_llegada_pieza["cRandMin", i].Value = rand_min;
                dgv_llegada_pieza["cRandMax", i].Value = rand_max;


                rand_min = acu;
            }
        }

        private void Btn_simular_Click(object sender, EventArgs e)
        {
            dgv_grilla.Rows.Clear();
            dgv_grilla.Columns.Clear();
            generar_grilla();

            VectorEstado vector = new VectorEstado();
            cargarVariables(vector);

            double tiempo_simular = Convert.ToDouble(txt_tiempo_simulacion.Text);
            double tiempo_desde = Convert.ToDouble(txt_desde_simular.Text);
            double tiempo_hasta = Convert.ToDouble(txt_hasta_simular.Text);


            //Fila inicial
            vector.evento_proxima_llegada();
            //grabar_grilla(vector);


            for (double i = 0; i < tiempo_simular; i = Convert.ToDouble(vector.Reloj))
            {
                if (tiempo_desde <= i && tiempo_hasta >= i)
                {
                    grabar_grilla(vector);
                }

                String nom_columna = proximoEvento(vector);

                switch (nom_columna)
                {
                    case "cProximaLlegada":
                        evento_proxima_llegada(vector);
                        break;

                    case "cProximoFinFundicion":
                        evento_fin_fundicion(vector);
                        break;

                    case "cProximoFinForjado":
                        evento_fin_forjado(vector);
                        break;

                    case "cProximoFinEnfriado":
                        evento_fin_enfriado(vector);
                        break;

                    case "cProximoFinTerminado":
                        evento_fin_terminado(vector);
                        break;
                }                
            }

            vector.NombreEvento = "FIN SIMULACION";
            grabar_grilla(vector);
        }

        private void evento_fin_terminado(VectorEstado vector)
        {
            int id_fin = vector.buscar_id_pieza(Estado_Pieza.Te);
            vector.eliminar_pieza(id_fin);

            vector.NombreEvento = "Fin Terminado " + id_fin;
            vector.Reloj = vector.Tiempo_proximo_fin_terminado;


            vector.Rnd_llegada_pieza = "";
            vector.Tiempo_entre_llegada_pieza = "";

            vector.Rnd_fin_fundicion = "";
            vector.Tiempo_entre_fin_fundicion = "";

            vector.Rnd_fin_forjado = "";
            vector.Tiempo_entre_fin_forjado = "";

            vector.Tiempo_proximo_fin_enfriado = "";

            vector.Rnd_fin_terminado = "";
            vector.Tiempo_entre_fin_terminado = "";
            vector.Tiempo_proximo_fin_terminado = "";


            vector.Cola_terminado--;
            if (vector.Cola_terminado < 0) vector.Cola_terminado = 0;



            if (vector.Cola_terminado > 0)
            {
                if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_terminado))
                {
                    vector.Cola_terminado--;

                    vector.evento_proximo_fin_terminado();

                    int id = vector.buscar_id_pieza(Estado_Pieza.ETe);
                    vector.actualizar_pieza(id, Estado_Pieza.Te);
                }
            }

        }

        private void evento_fin_enfriado(VectorEstado vector)
        {
            int id_fin = vector.buscar_id_pieza(Estado_Pieza.En);
            vector.actualizar_pieza(id_fin, Estado_Pieza.ETe);

            vector.NombreEvento = "Fin Enfriado " + id_fin;
            vector.Reloj = vector.Tiempo_proximo_fin_enfriado;


            vector.Rnd_llegada_pieza = "";
            vector.Tiempo_entre_llegada_pieza = "";

            vector.Rnd_fin_fundicion = "";
            vector.Tiempo_entre_fin_fundicion = "";

            vector.Rnd_fin_forjado = "";
            vector.Tiempo_entre_fin_forjado = "";

            vector.Tiempo_proximo_fin_enfriado = "";

            vector.Rnd_fin_terminado = "";
            vector.Tiempo_entre_fin_terminado = "";
            //vector.Tiempo_proximo_fin_terminado = "";


            vector.Cola_terminado++;
            //vector.Cola_enfriado--;
            //if (vector.Cola_enfriado < 0) vector.Cola_enfriado = 0;


            if (vector.Cola_terminado > 0)
            {
                if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_terminado))
                {
                    vector.Cola_terminado--;

                    vector.evento_proximo_fin_terminado();

                    int id = vector.buscar_id_pieza(Estado_Pieza.ETe);
                    vector.actualizar_pieza(id, Estado_Pieza.Te);
                }
            }

            if (vector.Cola_enfriado > 0)
            {
                vector.Cola_enfriado--;

                vector.evento_proximo_fin_enfriado();

                int id = vector.buscar_id_pieza(Estado_Pieza.EEn);
                vector.actualizar_pieza(id, Estado_Pieza.En);
            }
        }

        private void evento_fin_forjado(VectorEstado vector)
        {
            int id_fin = vector.buscar_id_pieza(Estado_Pieza.Fo);
            vector.actualizar_pieza(id_fin, Estado_Pieza.EEn);

            vector.NombreEvento = "Fin Forjado " + id_fin;
            vector.Reloj = vector.Tiempo_proximo_fin_forjado;


            vector.Rnd_llegada_pieza = "";
            vector.Tiempo_entre_llegada_pieza = "";

            vector.Rnd_fin_fundicion = "";
            vector.Tiempo_entre_fin_fundicion = "";

            vector.Rnd_fin_forjado = "";
            vector.Tiempo_entre_fin_forjado= "";
            vector.Tiempo_proximo_fin_forjado = "";


            vector.Cola_enfriado++;
            //vector.Cola_forjado--;
            //if (vector.Cola_forjado < 0) vector.Cola_forjado = 0;


            if (vector.Cola_enfriado > 0)
            {
                if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_enfriado))
                {
                    vector.Cola_enfriado--;

                    vector.evento_proximo_fin_enfriado();

                    int id = vector.buscar_id_pieza(Estado_Pieza.EEn);
                    vector.actualizar_pieza(id, Estado_Pieza.En);
                }
            }

            if (vector.Cola_forjado > 0)
            {
                vector.Cola_forjado--;

                vector.evento_proximo_fin_forjado();

                int id = vector.buscar_id_pieza(Estado_Pieza.EFo);
                vector.actualizar_pieza(id, Estado_Pieza.Fo);

            }
        }

        private void evento_fin_fundicion(VectorEstado vector)
        {
            int id_fin = vector.buscar_id_pieza(Estado_Pieza.Fu);
            vector.actualizar_pieza(id_fin, Estado_Pieza.EFo);

            vector.NombreEvento = "Fin Fundicion " + id_fin;
            vector.Reloj = vector.Tiempo_proximo_fin_fundicion;


            vector.Rnd_llegada_pieza = "";
            vector.Tiempo_entre_llegada_pieza = "";

            vector.Rnd_fin_fundicion = "";
            vector.Tiempo_entre_fin_fundicion = "";
            vector.Tiempo_proximo_fin_fundicion = "";

            vector.Rnd_fin_forjado = "";
            vector.Tiempo_entre_fin_forjado = "";
            //vector.Tiempo_proximo_fin_forjado= "";



            vector.Cola_forjado++;
            //vector.Cola_fundicion--;
            //if (vector.Cola_fundicion < 0) vector.Cola_fundicion = 0;


            if (vector.Cola_forjado > 0)
            {
                if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_forjado))
                {
                    vector.Cola_forjado--;

                    vector.evento_proximo_fin_forjado();

                    vector.actualizar_pieza(id_fin, Estado_Pieza.Fo);
                }
            }

            if (vector.Cola_fundicion > 0)
            {
                vector.Cola_fundicion--;

                vector.evento_proximo_fin_fundicion();

                int id = vector.buscar_id_pieza(Estado_Pieza.EFu);
                vector.actualizar_pieza(id, Estado_Pieza.Fu);
            }
        }

        private void evento_proxima_llegada(VectorEstado vector)
        {
            Int32 indice_nueva_pieza = vector.nueva_pieza();

            vector.NombreEvento = "Llegada Pieza " + indice_nueva_pieza;
            vector.Reloj = vector.Tiempo_proxima_llegada_pieza;

            vector.evento_proxima_llegada();

            vector.Cola_fundicion++;


            vector.Rnd_fin_forjado = "";
            vector.Tiempo_entre_fin_forjado = "";

            vector.Rnd_fin_terminado = "";
            vector.Tiempo_entre_fin_terminado = "";


            //Calcula el proximo tiempo de fundicion
            if (vector.Cola_fundicion > 0)
            {
                if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_fundicion) == true)
                {
                    vector.Cola_fundicion--;

                    vector.evento_proximo_fin_fundicion();
                    vector.actualizar_pieza(indice_nueva_pieza, Estado_Pieza.Fu);
                }
                else
                {
                    vector.Rnd_fin_fundicion = "";
                    vector.Tiempo_entre_fin_fundicion = "";
                }
            }
        }

        private string proximoEvento(VectorEstado vector)
        {
            double reloj = Convert.ToDouble(vector.Reloj);

            List<Evento> eventos = new List<Evento>();

            if (String.IsNullOrWhiteSpace(vector.Tiempo_proxima_llegada_pieza) == false)
                eventos.Add(new Evento("cProximaLlegada", Convert.ToDouble(vector.Tiempo_proxima_llegada_pieza)));

            if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_fundicion) == false)
                eventos.Add(new Evento("cProximoFinFundicion", Convert.ToDouble(vector.Tiempo_proximo_fin_fundicion)));

            if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_forjado) == false)
                eventos.Add(new Evento("cProximoFinForjado", Convert.ToDouble(vector.Tiempo_proximo_fin_forjado)));

            if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_enfriado) == false)
                eventos.Add(new Evento("cProximoFinEnfriado", Convert.ToDouble(vector.Tiempo_proximo_fin_enfriado)));

            if (String.IsNullOrWhiteSpace(vector.Tiempo_proximo_fin_terminado) == false)
                eventos.Add(new Evento("cProximoFinTerminado", Convert.ToDouble(vector.Tiempo_proximo_fin_terminado)));


            eventos = eventos.OrderBy(t => t.Tiempo).ToList();

            return eventos[0].Nombre_columna;
        }

        private void cargarVariables(VectorEstado vector)
        {
            //Evento proxima llegada
            List<Lista> lista = new List<Lista>();
            for (int i = 0; i < dgv_llegada_pieza.Rows.Count; i++)
            {
                lista.Add(new Lista(
                    dgv_llegada_pieza["cTiempo", i].Value.ToString(),
                    dgv_llegada_pieza["cProbabilidad", i].Value.ToString(),
                    dgv_llegada_pieza["cAcumulada", i].Value.ToString(),
                    dgv_llegada_pieza["cRandMin", i].Value.ToString(),
                    dgv_llegada_pieza["cRandMax", i].Value.ToString()
                 ));
            }
            vector.llegada_pieza(lista);


            //Evento Forjado
            vector.forjado(
                Convert.ToDouble(txt_forjado_A.Text), 
                Convert.ToDouble(txt_forjado_B.Text)
            );


            //Evento Fundido
            vector.fundido(
                Convert.ToDouble(txt_fundicion_A.Text),
                Convert.ToDouble(txt_fundicion_B.Text)
            );


            //Evento terminado
            vector.terminado(
                Convert.ToDouble(txt_terminado_A.Text),
                Convert.ToDouble(txt_terminado_B.Text)
            );


            //Evento enfriado
            vector.enfriado(
                Convert.ToDouble(txt_tiempo_enfriado.Text)
            );
        }
    }
}
