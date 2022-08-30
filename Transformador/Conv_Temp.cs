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
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Celsius a Fahrenheits y a Kelvins.
        /// </summary>
        public static void TmpCel()
        {
            bool rep = true; //Declaramos un booleano en condicion true para poder ejecutar un while a continuación
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en ºC a convertir:\n>> ");
                try
                {
                    double cels = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    //En caso de no poder por el motivo que sea, pasaremos al bloque catch.
                    double[] o = Op_Temp.Celsius(cels);
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
                string go = Console.ReadLine();
                if (go.ToUpper() != "S" || go.ToUpper() !="Y")//Esto comprueba si el texto introducido en mayúsculas es igual a S, y en caso de ser diferente ejecuta sale del bucle
                {
                    rep = false;
                }
            }

        }
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Fahrenheits a Celsius y a Kelvins.
        /// </summary>
        public static void TmpFahr()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en ºF a convertir:\n>> ");//Entrada en Farhenheit
                try
                {
                    double fahr = double.Parse(Regex.Replace(Console.ReadLine(), "[.,']", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Temp.Fahr(fahr);
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
                if (go.ToUpper() != "S" || go.ToUpper() != "Y") { rep = false; }
            }

        }
        
        /// <summary>
        /// Método pre-creado de conversión de temperaturas. Kelvins a Celsius y a Fahrenheits.
        /// </summary>
        public static void TmpKel()
        {
            bool rep = true;
            while (rep)
            {
                Console.Write($"Introduzca una temperatura en K a convertir:\n>> ");//Entrada en Kelvins
                try
                {
                    double kel = double.Parse(Regex.Replace(Console.ReadLine(), "[.,]", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                    double[] o = Op_Temp.Kelvin(kel);
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
                string go = Console.ReadLine();
                if (go.ToUpper() != "S" || go.ToUpper() != "Y")
                {
                    rep = true;
                }
            }

        }
    }
    #endregion
}
