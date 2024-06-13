
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepasoParcial2
{
    internal class Ejerciocio

    {
        int[] vect = new int[50];
        int contNum = 0;
        public void ingresarValor(int valor)
        {

            vect[contNum] = valor;
            contNum++;

        }

        public double calcularPromedio()
        {
            double prom;
            double acum = 0;
            for (int i = 0; i < contNum; i++)
            {
                acum = acum + vect[i];

            }
            prom = acum / contNum;
            return prom;

        }

        public double[] devolverPromedio(ref int contNum)
        {
            double promedio = calcularPromedio();
            double[] mayProm = new double[contNum];
            for (int i = 0; i < contNum; i++)
            {
                if (vect[i] > promedio)
                {
                    mayProm[contNum] = vect[i];
                    contNum++;
                }

            }
            return mayProm;

        }

        public void OrdenarBurbuja(int[] vect, int cantidad)
        {
            int aux, i, j;
            for (i = 0; i < cantidad - 1; i++)
            {
                for (j = i + 1; j < cantidad; j++)
                {
                    if (vect[i] > vect[j])
                    {

                        aux = vect[i];
                        vect[i] = vect[j];
                        vect[j] = aux;

                    }

                }
            }




        }


    }
}
