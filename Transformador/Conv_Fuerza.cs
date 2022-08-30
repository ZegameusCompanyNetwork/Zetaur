using System;
using System.Collections.Generic;
using System.Globalization;
using Zetaur_Conv;
using System.Text.RegularExpressions;

namespace Transformador
{
    class Conv_Fuerza
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajo
        private const string Rp = "Otra temperatura que calcular? S/N: ";//Vamos a ahorrar espacio creando una constante para las repeticiones, en este caso para temperatura
        public static void FN()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write($"Introduzca una fuerza en Newtons (N) a convertir:\n>> ");//Entrada en Newtons
                try
                {
                    double N = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    //Op_Fuerza.OpN(N);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(Rp);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { rep = false; }
            }
        }
    }
}
