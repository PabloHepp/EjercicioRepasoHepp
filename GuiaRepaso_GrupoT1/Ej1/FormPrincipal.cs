using Ej1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class FormPrincipal : Form
    { Controlador objeto= new Controlador();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btAgregarValor_Click(object sender, EventArgs e)
        { 
            FormAgregarValor ventana = new FormAgregarValor();
            if (ventana.ShowDialog() == DialogResult.OK) {
                int valor = Convert.ToInt32(ventana.tbNumero.Text);
                objeto.IngresarValor(valor);
            }
           



        }

        private void BtnCalProm_Click(object sender, EventArgs e)
        {
            double prom= objeto.CalcularPromedio();
            LbMostrarProm.Text = prom.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResultado ventana2= new FormResultado();
            int cualquiera = 0;
            int[] Vector2 = objeto.DevolverProm(ref cualquiera);

            objeto.Burbuja(Vector2, cualquiera);

            int n = 0;
            while (n<cualquiera)
            {
                ventana2.lBListar.Items.Add(Vector2[n].ToString());
                n++;
            }
            ventana2.ShowDialog();
        }
    }
}
