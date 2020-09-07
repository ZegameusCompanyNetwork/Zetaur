using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Zetaur_Conv;

namespace Transformador
{
    public class Conv_Masa
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajo
        private const string reop = "Otra unidad a convertir (S/N): ";//Y en este para las medidas de longitud
        private const string vlno = "¿A introducido usted el valor adecuado?";//y esta para el S/N de continuar los bucles en caso de valor no admitido
        #region Masa
        public static void CmdKg()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Kilogramos a convertir: ");
                try
                {
                    double Kg = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpKg(Kg);//Llamamos al método de Kilogramos
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;//salimos del segundo bucle while
            }
        }
        public static void CmdGr()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en gramos a convertir: ");
                try
                {
                    double G = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpG(G);//Llamamos al método de Gramos
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }

        }
        public static void CmdT()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en toneladas a convertir: ");
                try
                {
                    double T = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpT(T);//Llamamos al método de Toneladas
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        /// <summary>
        /// Método de conversión pre-configurado de Toneladas cortas (Us t).
        /// </summary>
        public static void CmdUsT()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en toneladas cortas (Us t) a convertir: ");
                try
                {
                    double UsT = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpUsT(UsT);//Llamamos al método de Toneladas cortas (Us t)
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        public static void CmdUkT()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en toneladas largas (Uk t) a convertir: ");
                try
                {
                    double UkT = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpUkT(UkT);//Llamamos al método de Toneladas Largas
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        public static void CmdLb()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en libras a convertir: ");
                try
                {
                    double Lb = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpLb(Lb);//Llamamos al método de libras
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        public static void CmdOz()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en onzas a convertir: ");
                try
                {
                    double Oz = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpOz(Oz);//Llamamos al método de Onzas
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        public static void CmdSt()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en stones a convertir: ");
                try
                {
                    double St = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Masa.OpSt(St);//Llamamos al método de Stones
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

                bool r1 = true;
                while (r1)
                {
                    Console.Write(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta el siguiente fragmento de código
                    {
                        goto Go;//Salimos a la fuerza del bucle 2 para volver al inicio de la operación.
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;//salimos del primer bucle while
                    }
                    else
                    {
                        Console.WriteLine(vlno + reop);
                        r1 = true;
                    }
                }

                break;
            }
        }
        #endregion
    }
}
