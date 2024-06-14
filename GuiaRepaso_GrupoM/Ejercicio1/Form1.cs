using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Controlador ejemplo = new Controlador();

        public Form1()
        {
            InitializeComponent();
            ejemplo.AgregarAlumno("c",3,90);
            ejemplo.AgregarAlumno("a", 1, 99);
            ejemplo.AgregarAlumno("b", 2, 85);
            ejemplo.AgregarAlumno("d", 4, 0);
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
          
            if (registro.ShowDialog() == DialogResult.OK)
            {
                string nombre = registro.tbNombre.Text;
                int dni = Convert.ToInt32(registro.tbDni.Text);
                double nota = Convert.ToDouble(registro.tbNota.Text);
                ejemplo.AgregarAlumno(nombre, dni, nota); 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text=Convert.ToString(ejemplo.CalcularPromedio());
           
        }

        private void button2_Click(object sender, EventArgs e)
{
            FormVer formVer = new FormVer();
            if ( rbSuperaronPromedio.Checked== true)

            {
                ejemplo.AlumnosQueSuperanAlPromedio();
                for (int i = 0; i < ejemplo.ContadorProm; i++)
                {
                    string nombre = ejemplo.NombresProm[i];
                    int dni = ejemplo.DNIsProm[i];
                    double nota = ejemplo.NotasProm[i];
                    formVer.lbxResultados.Items.Add($"{nombre}-{dni}-{nota}");
                }
            }
            else if (rbTodos.Checked == true)
            {
                ejemplo.OrdenarNotas();
                for (int i = 0; i < ejemplo.Contador; i++)
                {
                    string nombre = ejemplo.Nombres[i];
                    int dni = ejemplo.DNIs[i];
                    double nota = ejemplo.Notas[i];
                    formVer.lbxResultados.Items.Add($"{nombre}-{dni}-{nota}");
                }
            }
            formVer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVer buscar = new FormVer();
            int pos = ejemplo.BuscarAlummno(Convert.ToInt32(tbBuscar.Text));
            if (pos > -1)
            {
                    string nombre = ejemplo.Nombres[pos];
                    int dni = ejemplo.DNIs[pos];
                    double nota = ejemplo.Notas[pos];
                    buscar.lbxResultados.Items.Add($"Nombre: {nombre}");
                    buscar.lbxResultados.Items.Add($"Documento: {dni}");
                    buscar.lbxResultados.Items.Add($"Nota: {nota:f2}");
            }
            buscar.ShowDialog();
        }
    }
}
