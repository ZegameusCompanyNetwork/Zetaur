using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Zetaur_Conv;

namespace Transformador
{
    public class Conv_Masa
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajo
        private const string Rp = "Otra unidad a convertir (S/N): ";//Y en este para las medidas de longitud
        private const string vlno = "¿A introducido usted el valor adecuado?";//y esta para el S/N de continuar los bucles en caso de valor no admitido
        #region Masa
        public static void CmdKg()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en Kilogramos a convertir: ");
                try
                {
                    double Kg = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpKg(Kg);//Llamamos al método de Kilogramos
                    Console.WriteLine("{0,20} Kilogramos son:\n",Kg);
                    Console.WriteLine("{0,20} gramos.\n{1,20} tonelada (métrica).\n{2,20} tonelada corta (US t).\n{3,20} tonelada larga (Uk t).\n{4,20} Onzas.\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        public static void CmdGr()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en gramos a convertir: ");
                try
                {
                    double G = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpG(G);//Llamamos al método de Gramos
                    Console.WriteLine("{0,20} Gramos son:\n", G);
                    Console.WriteLine("{0,20} kilogramos.\n{1,20} tonelada (métrica).\n{2,20} tonelada corta (US t).\n{3,20} tonelada larga (Uk t).\n{4,20} Onzas.\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }

        }
        public static void CmdT()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en toneladas a convertir: ");
                try
                {
                    double T = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpT(T);//Llamamos al método de Toneladas
                    Console.WriteLine("{0,20}  son:\n", T);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada corta (US t).\n{3,20} tonelada larga (Uk t).\n{4,20} Onzas.\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
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
                Console.Write("Inserte una cantidad en toneladas cortas (Us t) a convertir: ");
                try
                {
                    double UsT = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpUsT(UsT);//Llamamos al método de Toneladas cortas (Us t)
                    Console.WriteLine("{0,20} Toneladas Cortas (US t) son:\n", UsT);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada (métrica).\n{3,20} tonelada larga (Uk t).\n{4,20} Onzas.\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        public static void CmdUkT()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en toneladas largas (Uk t) a convertir: ");
                try
                {
                    double UkT = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpUkT(UkT);//Llamamos al método de Toneladas Largas
                    Console.WriteLine("{0,20} Toneladas Cortas (US t) son:\n", UkT);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada (métrica).\n{3,20} tonelada cortas (US t).\n{4,20} Onzas.\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        public static void CmdLb()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en libras a convertir: ");
                try
                {
                    double Lb = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpLb(Lb);//Llamamos al método de libras
                    Console.WriteLine("{0,20} Toneladas Cortas (US t) son:\n", Lb);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada (métrica).\n{3,20} tonelada corta (US t).\n{4,20} tonelada larga (Uk t).\n{5,20} Onzas.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        public static void CmdOz()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en onzas a convertir: ");
                try
                {
                    double Oz = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpOz(Oz);//Llamamos al método de Onzas
                    Console.WriteLine("{0,20} Toneladas Cortas (US t) son:\n", Oz);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada (métrica).\n{3,20} tonelada corta (US t).\n{4,20} tonelada larga (Uk t).\n{5,20} Libras.\n{6,20} Stones", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        public static void CmdSt()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en stones a convertir: ");
                try
                {
                    double St = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Masa.OpSt(St);//Llamamos al método de Stones
                    Console.WriteLine("{0,20} Stones son:\n", St);
                    Console.WriteLine("{0,20} Kilogramos.\n{1,20} gramos.\n{2,20} tonelada (métrica).\n{3,20} tonelada corta (US t).\n{4,20} tonelada larga (Uk t).\n{5,20} Onzas.\n{6,20} Libras", o[0], o[1], o[2], o[3], o[4], o[5]);
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
                finally
                {
                    Console.WriteLine(Rp);
                    string go = Console.ReadLine();
                    if (go.ToUpper() != "S" && go.ToUpper() != "Y") { r = false; }
                }
            }
        }
        #endregion
    }
}
