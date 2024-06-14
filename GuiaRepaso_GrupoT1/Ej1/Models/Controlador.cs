using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    public class Controlador
    {
        public int[] VecEnt = new int[1000];
        public int ContNum = 0;


        public void IngresarValor(int valor)
        {
            VecEnt[ContNum] = valor;
            ContNum++;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;


            int acum = 0;
            for (int i = 0; i < ContNum; i++)
            {
                acum += VecEnt[i];
            }
            if (ContNum > 0)
            {
                promedio = acum / ContNum;
            }
            return promedio;
        }
      

        public int[] DevolverProm(ref int contador)
        {
            int[] VecMayorProm = new int[1000];
            double promedio = CalcularPromedio();

            for (int i = 0; i < ContNum; i++)
            {
                if (VecEnt[i] > promedio)
                {
                    VecMayorProm[contador] = VecEnt[i];
                    contador++;
                }
            }return VecMayorProm;
        }

        public void Burbuja(int[] Valores, int Cantidad)
        {
            int aux;
            int i;
            int j;
            for(i = 0;i < Cantidad -1; i++)
            {
                for (j = i + 1; j < Cantidad; j++)
                {
                    if (Valores[i] > Valores[j])
                    {
                        aux = Valores[i];
                        Valores[i] = Valores[j];
                        Valores[j] = aux;
                    }
                }
            }
        }

    }
}
