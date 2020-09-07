using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Zetaur_Conv;

namespace Transformador
{
    public class Conv_Temp
    {
        private const string FrmExc = "Usted ha introducido un valor no númerico, por favor introduzca un número";//Declaro una constante para cuando el usuario cometa un excepción de tipo FormatException, más info abajo
        private const string Rp = "Otra temperatura que calcular? S/N: ";//Vamos a ahorrar espacio creando una constante para las repeticiones, en este caso para temperatura
        private const string vlno = "¿A introducido usted el valor adecuado?\n";//y esta para el S/N de continuar los bucles en caso de valor no admitido
        #region Temperatura
        private const string frmcv = "La formula para convertir de";
        private static readonly string[] temps = { "Grados Celsius", "Fahrenheit", "Kelvins" };//para poder usar el array tenemos que ponerlo como static y para evitar su modificación lo ponemos como readonly
        private static readonly string[] frms = { "ºC = (ºF - 32) * 5 / 9", "ºC = K -273.15", "K = ºC + 273.15", "K = (ºF - 32) * 5 / 9 + 273.15", "ºF = (ºC * 5 / 9) + 32", "ºF = (K - 273.15) * 9 / 5 + 32" };
        #region Celsius-Fahrenheits-Kelvins
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Celsius a Fahrenheits y a Kelvins.
        /// </summary>
        public static void TmpCel()
        {
            bool rep = true; //Declaramos un booleano en condicion true para poder ejecutar un while a continuación
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en {temps[0]} a convertir:\n>> ");
                try
                {
                    double cels = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));//Hacemos que el usuario introduzca una cantidad por la consola, y obligamos a convertirla a double.
                    //En caso de no poder por el motivo que sea, pasaremos al bloque catch.
                    Console.WriteLine("\n{0} {1} a {2} es: {3}", frmcv, temps[0], temps[1], frms[4]);//Para ahorrar espacio utilizamos variables para acortar el código
                    Console.WriteLine("{0} {1} a {2} es: {3}", frmcv, temps[0], temps[2], frms[2]);
                    Op_Temp.OpCelFahrKel(cels);
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))//Aquí creamos un encapsulador que en caso de error va a comprobar que el tipo de excepción producida no sea FormatException.
                //Y en caso de que sea FormatException, el programa ejecutara el código del catch que contenga el argumento FormatException 
                {
                    Console.ForegroundColor = ConsoleColor.Red;//Cambiamos el color para que quede mejor.
                    Console.WriteLine(e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.Green;//Ponemos el color inicial
                }
                catch (FormatException e)//Este es el bloque catch que se ejecutara en caso de que la excepción producida sea FormatException
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(FrmExc);//Llamamos a la constante declarada al principio del programa
                    Console.WriteLine(e.Message + "\n");//e.Message nos permite mostrar una descripción corta del error, sin mostrar código del programa.
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(Rp);
            /*Creamos una condicion if, con un else if y con un else final, ya que este último vendría siendo el while; para mostrar en pantalla la cadena "go"
             con la instrucción go.ToUpper() hacemos que el valor introducido se combierta a mayúsculas, y si no es igual a S (!= "S") hace que el bool rep
             sea false, finalizando el bucle while
             */
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
                    Console.Write(vlno + Rp);
                    goto go;
                }
            }

        }
        #endregion
        #region Fahrenheits-Celsius-Kelvins
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Fahrenheits a Celsius y a Kelvins.
        /// </summary>
        public static void TmpFahr()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en {temps[1]} a convertir:\n>> ");//Entrada en Farhenheit
                try
                {
                    double fahr = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Console.WriteLine("\n{0} {1} a {2} es: {3}", frmcv, temps[1], temps[0], frms[0]);
                    Console.WriteLine("{0} {1} a {2} es: {3}", frmcv, temps[0], temps[2], frms[3]);
                    Op_Temp.OpFahrCelKel(fahr);
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
            go:
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")
                {
                    rep = true;
                }
                else if (go.ToUpper() == "N")
                {
                    rep = false;
                }
                else
                {
                    Console.Write(vlno + Rp);
                    goto go;
                }
            }

        }
        #endregion
        #region Kelvins-Fahrenheits-Celsius
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Kelvins a Celsius y a Fahrenheits.
        /// </summary>
        public static void TmpKel()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en {temps[2]} a convertir:\n>> ");//Entrada en Kelvins
                try
                {
                    double kel = double.Parse(Regex.Replace(Console.ReadLine(), "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    Console.WriteLine("\n{0} {1} a {2} es: {3}", frmcv, temps[2], temps[0], frms[1]);
                    Console.WriteLine("{0} {1} a {2} es: {3}", frmcv, temps[2], temps[1], frms[5]);
                    Op_Temp.OpKelFahrCels(kel);
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
                Console.Write(Rp);
            go:
                string go = Console.ReadLine();
                if (go.ToUpper() == "S")
                {
                    rep = true;
                }
                else if (go.ToUpper() == "N")
                {
                    rep = false;
                }
                else
                {
                    Console.Write(vlno + Rp);
                    goto go;
                }
            }

        }
        #endregion
    }
    #endregion
}
