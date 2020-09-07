/*#########################################################
 *#    Copyright 2019 Zegameus Company Network Records    #
 *#                     Licencia MIT                      #
 *#########################################################
 */
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Zetaur_Conv;

namespace Transformador
{
    public class Conv_Long
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajoprivate const string Rp = "Otra temperatura que calcular? S/N: ";//Vamos a ahorrar espacio creando una constante para las repeticiones, en este caso para temperatura
        private const string reop = "Otra unidad a convertir (S/N): ";//Y en este para las medidas de longitud
        private const string vlno = "¿A introducido usted el valor adecuado?";//y esta para el S/N de continuar los bucles en caso de valor no admitido

        #region Longitud
        /// <summary>
        /// Método de conversión de metros al resto de unidades disponibles (véase en el método Op_Long).
        /// </summary>
        public static void CmdM()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en metros a convertir: ");
                try
                {
                    double m = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpM(m);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);//llamamos a la constante reop declarada al inicio de la region Longitud, usamos solo Write para que se muestre a continuación el valor de S o N
            go:
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void Cmdkm()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en metros a convertir: ");
                try
                {
                    double km = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpKm(km);//Llamamos al método de kilometros
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);
            go:
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void CmdMi()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en Millas a convertir: ");
                try
                {
                    double Mi = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpMi(Mi);//Llamamos al método de Millas
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);
            go:
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void CmdNmi()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en Millas Náuticas a convertir: ");
                try
                {
                    double Nmi = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpNmi(Nmi);//Llamamos al método de Millas Náuticas
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);
            go:
                Console.Write(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    Console.Clear();
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void CmdInc()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en Pulgadas a convertir: ");
                try
                {
                    double Inc = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpInc(Inc);//Llamamos al método de Pulgadas
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);
            go:
                Console.Write(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    Console.Clear();
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void CmdYd()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en Yardas a convertir: ");
                try
                {
                    double Yd = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpYd(Yd);//Llamamos al método de Yardas
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
                Console.Write(reop);
            go:
                Console.Write(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    Console.Clear();
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        public static void CmdPie()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en Pies a convertir: ");
                try
                {
                    double pie = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Long.OpPie(pie);//Llamamos al método de pie
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(FrmExc);
                    Console.WriteLine(e.Message + "\n");
                }
            go:
                Console.Write(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                {
                    rep = true;//mantenemos en true para poder ejecutar el bucle while de nuevo
                }
                else if (go.ToUpper() == "N")
                {
                    Console.Clear();
                    rep = false;//Cambiamos de true a false
                }
                else
                {
                    Console.WriteLine(vlno);
                    goto go;
                }
            }
        }
        #endregion
    }
}
