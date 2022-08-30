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
        private const string Rp = "Otra unidad a convertir (S/N): ";//Y en este para las medidas de longitud

        #region Longitud
        /// <summary>
        /// Método de conversión de metros al resto de unidades disponibles <seealso cref="Op_Long"/> .
        /// </summary>
        public static void CmdM()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write("Inserte una cantidad en metros a convertir:\n>> ");
                try
                {
                    double m = double.Parse(Regex.Replace(Console.ReadLine(), "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Long.OpM(m);
                    Console.WriteLine("{0,20} Metros son:\n", m);
                    Console.WriteLine("{0,20} Km\n{1,20} Mi\n{2,20} Nmi\n{3,20} in\n{4,20} Yd\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double[] o = Op_Long.OpKm(km);//Llamamos al método de kilometros

                    Console.WriteLine("{0,20} Kilometros son:\n", km);
                    Console.WriteLine("{0,20} M\n{1,20} Mi\n{2,20} Nmi\n{3,20} in\n{4,20} Yd\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double[] o = Op_Long.OpMi(Mi);//Llamamos al método de Millas
                    Console.WriteLine("{0,20} Millas son:\n", Mi);
                    Console.WriteLine("{0,20} Km\n{1,20} M\n{2,20} Nmi\n{3,20} in\n{4,20} Yd\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double[] o = Op_Long.OpNmi(Nmi);//Llamamos al método de Millas Náuticas
                    Console.WriteLine("{0,20} Millas son:\n", Nmi);
                    Console.WriteLine("{0,20} Km\n{1,20} M\n{2,20} Mi\n{3,20} in\n{4,20} Yd\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double[] o = Op_Long.OpInc(Inc);//Llamamos al método de Pulgadas
                    Console.WriteLine("{0,20} Millas son:\n", Inc);
                    Console.WriteLine("{0,20} Km\n{1,20} M\n{2,20} Mi\n{3,20} Nmi\n{4,20} Yd\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double[] o = Op_Long.OpYd(Yd);//Llamamos al método de Yardas
                    Console.WriteLine("{0,20} Millas son:\n", Yd);
                    Console.WriteLine("{0,20} Km\n{1,20} M\n{2,20} Mi\n{3,20} Nmi\n{4,20} in\n{5,20} ft", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
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
                    double ft = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Long.OpFt(ft);//Llamamos al método de ft
                    Console.WriteLine("{0,20} Millas son:\n", ft);
                    Console.WriteLine("{0,20} Km\n{1,20} M\n{2,20} Mi\n{3,20} Nmi\n{4,20} in\n{5,20} yd", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { rep = false; }
                }
            }
        }
        #endregion
    }
}
