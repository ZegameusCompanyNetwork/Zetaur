using System;

namespace Zetaur
{
    class Factoriales
    {
        public void Factorial()
        {
            bool r = true;
            while (r)
            {
                double num;//Para permitir la introducción de valores decimales
                double res = 1;//Este es el valor de salida, (A de ser double para permitir decimales
                Console.Write("Calculadora de factoriales \n Inserta numero a factorizar:\n>> ");
                try
                {
                    num = double.Parse(Console.ReadLine());
                    for (int i = 1; i <= num; i++)
                    {
                        res = res * i;
                    }
                    Console.WriteLine("El factorial de {0} es: {1}", num, res);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducido no es válido, Error {0}", e);
                    r = true;
                }
                r = false;//salimos del bucle
            }
        }
    }
}
