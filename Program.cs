using System;

namespace T05Ejercicio3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Escriba el número que desea saber si es primo (true) o no (false):");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EsPrimo(numero));
        }

        static Boolean EsPrimo(int numero)
        {
            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            //Si se ha podido dividir solo dos veces es primo (por 1 y por sí mismo)
            //en caso de que el contador sea mayor de 2 no es primo.
            if (contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}