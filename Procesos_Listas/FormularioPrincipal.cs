using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos_Listas
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            iniciar20();
            iniciar40();
        }

        private void iniciar40()
        {
            short prob = 40;
            int ciclosVacios = 0;
            int procesosMaximos = 0;
            bool primeraVez = false;
            int ciclosAtendidos = 0;
            Random ran = new Random();
            Lista lista = new Lista();
            Proceso hola = null;

            for (int i = 0; i < 200; i++)
            {
                if (ran.Next(1, 101) <= prob)
                    lista.agregar(new Proceso());

                if (lista.Count > 0)
                {
                    if(!primeraVez)
                    {
                        hola = lista.Inicio;
                        primeraVez = true;
                    }                    
                    hola.Ciclos--;

                    if (hola.Ciclos < 1)
                    {
                        lista.eliminar(hola);
                        ciclosAtendidos++;
                    }

                    if (lista.Count > procesosMaximos)
                        procesosMaximos = lista.Count;

                    hola = hola.Siguiente;
                }
                else
                    ciclosVacios++;
            }
            txtProPen40.Text = lista.Count.ToString();

            int ciclosPendientes = 0;
            Proceso tem = lista.Inicio;
            do
            {
                ciclosPendientes += tem.Ciclos;
                tem = tem.Siguiente;
            } while (tem != lista.Inicio);

            txtCicPen40.Text = ciclosPendientes.ToString();
            txtCiclosVacios40.Text = ciclosVacios.ToString();
            txtNumPro40.Text = procesosMaximos.ToString();
            txtCiclosAtendidos40.Text = ciclosAtendidos.ToString();
        }

        public void iniciar20()
        {
            short prob = 20;
            int ciclosVacios = 0;
            int procesosMaximos = 0;
            bool primeraVez = false;
            int ciclosAtendidos = 0;
            Random ran = new Random();
            Lista lista = new Lista();
            Proceso hola = null;

            for (int i = 0; i < 200; i++)
            {
                if (ran.Next(1, 101) <= prob)
                    lista.agregar(new Proceso());

                if (lista.Count > 0)
                {
                    if (!primeraVez)
                    {
                        hola = lista.Inicio;
                        primeraVez = true;
                    }
                    hola.Ciclos--;

                    if (hola.Ciclos < 1)
                    {
                        lista.eliminar(hola);
                        ciclosAtendidos++;
                    }

                    if (lista.Count > procesosMaximos)
                        procesosMaximos = lista.Count;

                    hola = hola.Siguiente;
                }
                else
                    ciclosVacios++;
            }
            txtProPen.Text = lista.Count.ToString();

            int ciclosPendientes = 0;
            Proceso tem = lista.Inicio;
            do
            {
                ciclosPendientes += tem.Ciclos;
                tem = tem.Siguiente;
            } while (tem != lista.Inicio);

            txtCiclPen.Text = ciclosPendientes.ToString();
            txtCiclosVacios.Text = ciclosVacios.ToString();
            txtNumProMax.Text = procesosMaximos.ToString();
            txtCiclosAtendidos.Text = ciclosAtendidos.ToString();
        }
    }
}
