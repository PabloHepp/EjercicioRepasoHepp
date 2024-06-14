using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Controlador
    {
       public string[] Nombres = new string[1000];
        public  int Contador = 0;
        public int[] DNIs = new int[1000];
        public double[] Notas = new double[1000];


        public void AgregarAlumno(string nombre,int dni,double nota)
        {
            Nombres[Contador] = nombre;
            DNIs[Contador] = dni;
            Notas[Contador] = nota;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i = 0; i < Contador; i++)
            {
               acumulador += Notas[i];
            }
            if (Contador > 0)
            {
                promedio = acumulador/ Contador;
            }
            return promedio;
        }

        public string[] NombresProm = new string[1000];
        public int[] DNIsProm = new int[1000];
        public double[] NotasProm = new double[1000];
        public int ContadorProm = 0;
        public void AlumnosQueSuperanAlPromedio()
        {
            ContadorProm = 0;
            double promedio = CalcularPromedio();
            for(int i = 0;i < Contador;i++)
            {
                if (Notas[i] > promedio)
                {
                    NotasProm[ContadorProm] = Notas[i];
                    NombresProm[ContadorProm] = Nombres[i];
                    DNIsProm[ContadorProm] = DNIs[i];
                    ContadorProm++;
                    
                }
            }
        }

        public void OrdenarNotas()
        {
            int i, j,ax;
            double a;
            string au;
            for(i= 0;i< Contador-1;i++)
            {
                for(j= i +1; j< Contador;j++)
                {
                    if (Notas[i] > Notas[j])
                    {
                        a = Notas[j];
                        Notas[j] = Notas[i];
                        Notas[i] = a;
                        au = Nombres[j];
                        Nombres[j] = Nombres[i];
                        Nombres[i] = au;
                        ax = DNIs[j];
                        DNIs[j] = DNIs[i];
                        DNIs[i] = ax;

                    }
                }
            }
        }

        public int BuscarAlummno(int dni)
        {
            int i = 0;
            int pos = -1;
            while ((pos == -1) && (i < Contador))
            {
                if (DNIs[i] == dni)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }
    }
}
