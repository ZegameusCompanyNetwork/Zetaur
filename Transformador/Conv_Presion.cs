using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Zetaur_Conv;

namespace Transformador
{
    public class Conv_Presion
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajo
        private const string reop = "Otra unidad a convertir (S/N): ";//Y en este para las medidas de longitud
        private const string vlno = "¿A introducido usted el valor adecuado?";//y esta para el S/N de continuar los bucles en caso de valor no admitido

        #region Presion
        public static void CmdAtm()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Atmósferas a convertir: ");
                try
                {
                    double Atm = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpAtm(Atm);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdBar()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en bares a convertir: ");
                try
                {
                    double Bar = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpBar(Bar);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdmBar()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en milibares a convertir: ");
                try
                {
                    double mBar = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpmBar(mBar);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdPSI()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en PSI a convertir: ");
                try
                {
                    double PSI = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpPSI(PSI);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdPa()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Pascales a convertir: ");
                try
                {
                    double Pa = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpPa(Pa);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdhPa()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Hectopascales a convertir: ");
                try
                {
                    double hPa = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OphPa(hPa);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdmmhgTorr()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Atmósferas a convertir: ");
                try
                {
                    double mmHg = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.OpmmHgTorr(mmHg);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        public static void CmdKpcm2()
        {
            bool r = true;
            while (r)
            {
            Go:
                Console.Write("Inserte una cantidad en Kilopondios por centímetro cuadrado a convertir: ");
                try
                {
                    double kpcm2 = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Op_Presion.Opkpcm2(kpcm2);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                bool r1 = true;
                while (r1)
                {
                    Console.WriteLine(reop);
                    string go = Console.ReadLine();
                    if (go.ToUpper() == "S")
                    {
                        goto Go;
                    }
                    else if (go.ToUpper() == "N")
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(vlno);
                        r1 = true;
                    }
                }
                break;
            }
        }
        #endregion
    }
}
