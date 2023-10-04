using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1_U2
{
    internal class Ejercicios
    {

        public void ImprimirNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        public void CalcularMultiplos(int[] numeros, int multiplo)
        {
            int[] resultados = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                resultados[i] = multiplo * numeros[i];
            }
            ImprimirMultiplos(resultados);
        }

        public void ImprimirMultiplos(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
