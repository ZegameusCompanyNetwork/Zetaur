using System;

namespace Zetaur_Conv
{
    /// <summary>
    /// Clase con los métodos de transformación de unidades de longitud.
    /// <list type="table">
    /// <listheader><term>Unidad</term><description>Nombre de completo de unidad</description></listheader>
    /// <item><term>m</term><description>Metros</description></item>
    /// <item><term>Km</term><description>Kilómetros</description></item>
    /// <item><term>Mi</term><description>Millas</description></item>
    /// <item><term>nmi</term><description>Millas Náuticas</description></item>
    /// <item><term>in</term><description>Pulgadas</description></item>
    /// <item><term>yd</term><description>Yardas</description></item>
    /// <item><term>ft</term><description>Pies</description></item>
    /// </list>
    /// </summary>
    public class Op_Long
    {
        static readonly string[] longs = { "Metros (m)", "Kilómetros (Km)", "Millas (Mi)", "Millas Náuticas (nmi)", "Pulgadas (in)", "Yardas (yd)", "pies (ft)" };
        #region Metros-kilometros
        /// <summary>
        /// Transforma Metros (m) al resto de unidades <see cref="Op_Long"/>.
        /// </summary>
        /// <param name="i">m es un número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (Km, Mi, Nmi, in, Yd, ft)</returns>
        public static double[] OpM(double i)
        {
            //escribimos todas las formulas a ejecutar, importante ponerlas como doubles para poder tener decimales
            double[] o = new double[6];
            o[0] = i / 1000;//km
            o[1] = i / 1609;//mi
            o[2] = i / 1852;//Nmi
            o[3] = i * 39.97;//in
            o[4] = i * 1.0936133;//Yd
            o[5] = i * 3.2808399;//ft
            return o;
        }
        /// <summary>
        /// Transforma Kilómetros (Km) al resto de unidades <see cref="Op_Long"/>.
        /// </summary>
        /// <param name="i">km es un número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Mi, Nmi, in, Yd, ft)</returns>
        public static double[] OpKm(double i)
        {
            double[] o = new double[6];
            o[0] = i * 1000;//m
            o[1] = i * 39370;//mi
            o[2] = i / 1.609;//Nmi
            o[3] = i / 1.852;//in
            o[4] = i * 1093.6133;//Yd
            o[5] = i * 3280.8399;//ft

            return o;
        }
        #endregion
        #region Millas
        /// <summary>
        /// Transforma Millas (Mi) al resto de unidades <see cref="Op_Long"/>.
        /// </summary>
        /// <param name="i">Mi es un número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Km, Nmi, in, Yd, ft)</returns>
        public static double[] OpMi(double i)
        {
            double[] o = new double[6];
            o[0] = i * 1609; //m
            o[1] = i * 1.609; //km
            o[2] = i / 1.151; //Nmi
            o[3] = i * 63360; //in
            o[4] = i * 1760;//yd
            o[5] = i * 5280; //ft
            return o;
        }
        /// <summary>
        /// Transforma Millas Náuticas al resto de unidades <see cref="Op_Long"/>.
        /// </summary>
        /// <param name="i">nmi es un número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Km, Mi, in, Yd, ft)</returns>
        public static double[] OpNmi(double i)
        {
            double[] o = new double[6];
            o[0] = i * 1852; //m
            o[1] = i * 1.852; //km
            o[2] = i * 1.151;//mi
            o[3] = i * 72913; //in
            o[4] = i * 2025.37;//yd
            o[5] = i * 6076.12;//ft
            return o;
        }
        #endregion
        #region Pulgadas-Yardas-fts
        /// <summary>
        /// Transforma Pulgadas (in) al resto de unidades <see cref="Op_Long"/>
        /// </summary>
        /// <param name="i">inc es un número double</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Km, Mi, Nmi, Yd, ft)</returns>
        public static double[] OpInc(double i)
        {
            double[] o = new double[6];
            o[0] = i / 39.97;
            o[1] = i / 39970;
            o[2] = i / 63360;
            o[3] = i / 72913;
            o[4] = i / 36;
            o[5] = i / 12;
            return o;
        }
        /// <summary>
        /// Transforma Yardas (yd) al resto de unidades <see cref="Op_Long"/>
        /// </summary>
        /// <param name="i">yd es número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Km, Mi, Nmi, in, ft)</returns>
        public static double[] OpYd(double i)
        {
            double[] o = new double[6];
            o[0] = i / 1.094;//m
            o[1] = i / 1094;//Km
            o[2] = i / 1760;//Mi
            o[3] = i / 2025;//Nmi
            o[4] = i * 36;//in
            o[5] = i * 3;//ft
            return o;
        }
        /// <summary>
        /// Transforma fts (ft) al resto de unidades <see cref="Op_Long"/>
        /// </summary>
        /// <param name="i">ft es un número double.</param>
        /// <returns>Devuelve un array con los valores convertidos (m, Km, Mi, Nmi, in, Yd)</returns>
        public static double[] OpFt(double i)
        {
            double[] o = new double[6];
            o[0] = i / 3.281;
            o[1] = i / 3281;
            o[2] = i / 5280;
            o[3] = i / 6076;
            o[4] = i * 12;
            o[5] = i / 3;
            return o;
        }
        #endregion
    }
}
