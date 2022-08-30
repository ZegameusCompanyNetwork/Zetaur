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

        #region Presion
        public static void CmdAtm()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en Atmósferas a convertir: ");
                try
                {
                    double Atm = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.OpAtm(Atm);
                    Console.WriteLine("{0,20} Atm son:\n", Atm);
                    Console.WriteLine("{0,20} Bar.\n{1,20} mBar\n{2,20} PSI\n{3,20} Pa\n{4,20} hPa\n{5,20} mmHg/Torr\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdBar()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en Bares a convertir: ");
                try
                {
                    double Bar = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.Bar(Bar);
                    Console.WriteLine("{0,20} Bar son:\n", Bar);
                    Console.WriteLine("{0,20} Atm.\n{1,20} mBar\n{2,20} PSI\n{3,20} Pa\n{4,20} hPa\n{5,20} mmHg/Torr\n{5,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdmBar()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en milibares a convertir: ");
                try
                {
                    double mBar = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.mBar(mBar);
                    Console.WriteLine("{0,20} mBar son:\n", mBar);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} PSI\n{3,20} Pa\n{4,20} hPa\n{5,20} mmHg/Torr\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdPSI()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en PSI a convertir: ");
                try
                {
                    double PSI = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.PSI(PSI);
                    Console.WriteLine("{0,20} PSI son:\n", PSI);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} mBar\n{3,20} Pa\n{4,20} hPa\n{5,20} mmHg/Torr\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdPa()
        {
            bool r = true;
            while (r)
            {

                Console.Write("Inserte una cantidad en Pascales a convertir: ");
                try
                {
                    double Pa = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.Pa(Pa);
                    Console.WriteLine("{0,20} Pascales son:\n", Pa);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} mBar\n{3,20} PSI\n{4,20} hPa\n{5,20} mmHg/Torr\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdhPa()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en Hectopascales a convertir: ");
                try
                {
                    double hPa = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.hPa(hPa);
                    Console.WriteLine("{0,20} Hectopascales son:\n", hPa);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} mBar\n{3,20} PSI\n{4,20} Pa\n{5,20} mmHg/Torr\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdmmhgTorr()
        {
            bool r = true;
            while (r)
            {
                Console.Write("Inserte una cantidad en mmHg/Torr a convertir: ");
                try
                {
                    double mmHg = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.mmHgTorr(mmHg);
                    Console.WriteLine("{0,20} Kpcm2 son:\n", mmHg);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} mBar\n{3,20} PSI\n{4,20} Pa\n{5,20} hPa\n{6,20} kpcm2", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        public static void CmdKpcm2()
        {
            bool r = true;
            while (r)
            {

                Console.Write("Inserte una cantidad en Kilopondios por centímetro cuadrado a convertir: ");
                try
                {
                    double kpcm2 = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Presion.kpcm2(kpcm2);
                    Console.WriteLine("{0,20} Kilopondio por cm2 son:\n", kpcm2);
                    Console.WriteLine("{0,20} Atm.\n{1,20} Bar\n{2,20} mBar\n{3,20} PSI\n{4,20} Pa\n{5,20} hPa\n{6,20} mmHg/Torr", o[0], o[1], o[2], o[3], o[4], o[5], o[6]);
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
                Console.WriteLine(reop);
                string go = Console.ReadLine();
                if (go.ToUpper() != "S") { r = false; }
            }
        }
        #endregion
    }
}
