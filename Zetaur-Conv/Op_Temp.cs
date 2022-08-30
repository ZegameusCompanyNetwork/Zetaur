using System;

namespace Zetaur_Conv
{
    /// <summary>
    /// Clase con los métodos de transformación de unidades de temperaturas.
    /// <list type="table">
    /// <listheader><term>Unidad</term><description>Nombre de completo de unidad</description></listheader>
    /// <item><term>ºC</term><description>Grados Celsius</description></item>
    /// <item><term>ºF</term><description>Grados Fahrenheits</description></item>
    /// <item><term>K</term><description>Grados Kelvin</description></item>
    /// <item><term>ºR</term><description>Grados Rankine</description></item>
    /// <item><term>ºRe</term><description>Grados Réaumur</description></item>
    /// </list>
    /// </summary>
    public class Op_Temp
    {
        /// <summary>
        /// Método para la conversión de grados centígrados al resto de unidades contempladas <seealso cref="Op_Temp"/>
        /// </summary>
        /// <param name="i">Valor en grados celsius</param>
        /// <returns>Array con los valores convertidos (Fahr, K, ºR, ºRe) en ese orden </returns>
        public static double[] Celsius(double i)
        {
            double[] o = new double[4];
            o[0] = (i * 9 / 5) + 32; // Fahrenheit
            o[1] = i + 273.15; //Kelvin
            o[2] = (i * 9 / 5) + 491.67; //Rankine
            o[3] = i * 0.8; //Réaumur
            return o;
        }
        /// <summary>
        /// Método para la conversión de grados Fahrenheits al resto de unidades contempladas <seealso cref="Op_Temp"/>
        /// </summary>
        /// <param name="i">Valor en grados centígrados</param>
        /// <returns>Array con los valores convertidos (ºC, K, ºR, ºRe) en ese orden </returns>
        public static double[] Fahr(double i)
        {
            double[] o = new double[4];
            o[0] = (i - 32) * 5 / 9; // Celsius
            o[1] = o[0] + 273.15; //Kelvin
            o[2] = i + 459.67; //Rankine
            o[3] = (i - 32) * 4 / 9; //Réaumur
            return o;
        }
        /// <summary>
        /// Método para la conversión de grados Kelvin al resto de unidades contempladas <seealso cref="Op_Temp"/>
        /// </summary>
        /// <param name="i">Valor en grados celsius</param>
        /// <returns>Array con los valores convertidos (ºC, ºF, ºR, ºRe) en ese orden </returns>
        public static double[] Kelvin(double i)
        {
            double[] o = new double[4];
            o[0] = i - 273.15; //Celsius
            o[1] = (i * 9 / 5) - 459.67; //Fahrenheit
            o[2] = i * 9 / 5; //Rankine
            o[3] = (i - 273.15) * 4 / 5; //Réaumur
            return o;
        }
        /// <summary>
        /// Método para la conversión de grados Rankine al resto de unidades contempladas <seealso cref="Op_Temp"/>
        /// </summary>
        /// <param name="i">Valor en grados celsius</param>
        /// <returns>Array con los valores convertidos (ºC, ºF, K, ºRe) en ese orden </returns>
        public static double[] Rankine(double i)
        {
            double[] o = new double[4];
            o[0] = (i - 491.67) * 5 / 9; //Celsius
            o[1] = i - 459.67; //Fahrenheit
            o[2] = i * 5 / 9; //Kelvin
            o[3] = (o[1] - 32) * 4 / 9; //Réaumur
            return o;
        }
        /// <summary>
        /// Método para la conversión de grados Réamumur al resto de unidades contempladas <seealso cref="Op_Temp"/>
        /// </summary>
        /// <param name="i">Valor en grados celsius</param>
        /// <returns>Array con los valores convertidos (ºC,ºF, K, ºR) en ese orden </returns>
        public static double[] Reaumur(double i)
        {
            double[] o = new double[4];
            o[0] = i * 5 / 4; //Celsius
            o[1] = (i * 9 / 4) + 32; //Fahrenheit
            o[2] = i * 5 / 4 + 273.15; //Kelvin
            o[3] = (i * 9 / 4) + 491.67; //Rankine
            return o;
        }
    }
}
