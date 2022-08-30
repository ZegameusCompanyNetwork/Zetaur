using System;

namespace Zetaur_Conv
{
    /// <summary>
    /// Clase con los métodos de transformación de unidades de presión.
    /// <list type="table">
    /// <listheader><term>Unidad</term><description>Nombre de completo de unidad</description></listheader>
    /// <item><term>atm</term><description>Atmósferas Técnicas</description></item>
    /// <item><term>bar</term><description>Bares</description></item>
    /// <item><term>mbar</term><description>Milibares</description></item>
    /// <item><term>PSI</term><description>Libras por pulgada cuadrada</description></item>
    /// <item><term>Pa</term><description>Pascales</description></item>
    /// <item><term>hPa</term><description>Hectopascales</description></item>
    /// <item><term>mmHg</term><description>Milímetros de Mercurio</description></item>
    /// <item><term>kpcm2</term><description>Kilopondios por centímetro cuadrado</description></item>
    /// </list>
    /// </summary>
    public class Op_Presion
    {
        /// <summary>
        /// Convierte Atmosferas al resto de unidades.
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Bar, mBar, PSI, Pa, hPa, mmHg, kpcm2)</returns>
        public static double[] OpAtm(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1.01325;//Bar
            o[1] = i * 1013.25;//mBar
            o[2] = i * 14.6959;//PSI
            o[3] = i * 101325;//Pa
            o[4] = i * 1013.25;//hPa
            o[5] = i * 760; //mmHg
            o[6] = i * 1.03323;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte Bares al resto de unidades.
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, mBar, PSI, Pa, hPa, mmHg, kpcm2)</returns>
        public static double[] Bar(double i)
        {
            double[] o = new double[7];
            o[0] = i / 1.01325;//Atm
            o[1] = i * 1000;//mBar
            o[2] = i * 14.5038;//PSI
            o[3] = i * 100000;//Pa
            o[4] = i * 1000;//hPa
            o[5] = i * 750.062; //mmHg
            o[6] = i * 1.01972;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte mílibares al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, PSI, Pa, hPa, mmHg, kpcm2)</returns>
        public static double[] mBar(double i)
        {
            double[] o = new double[7];
            o[0] = i / 1013.25;//Atm
            o[1] = i / 1000;//Bar
            o[2] = i / 68.9476;//PSI
            o[3] = i * 100;//Pa
            o[4] = i;//hPa
            o[5] = i / 1.33322; //mmHg
            o[6] = i / 980.665;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte Libras por pulgada cuadrada al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, mBar, Pa, hPa, mmHg, kpcm2)</returns>
        public static double[] PSI(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1.01325;//Atm//Bar
            o[1] = i * 1013.25;//mBar
            o[2] = i * 14.6959;
            o[3] = i * 101325;//Pa
            o[4] = i * 1013.25;//hPa
            o[5] = i * 760; //mmHg
            o[6] = i * 1.03323;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte Pascales al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, mBar, PSI, hPa, mmHg, kpcm2)</returns>
        public static double[] Pa(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1.01325;//Atm//Bar
            o[1] = i * 1013.25;//mBar
            o[2] = i * 14.6959;//PSI
            o[3] = i * 101325;//Pa
            o[4] = i * 1013.25;//hPa
            o[5] = i * 760; //mmHg
            o[6] = i * 1.03323;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte HectoPascales al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, mBar, PSI, Pa, mmHg, kpcm2)</returns>
        public static double[] hPa(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1.01325;//Atm//Bar
            o[1] = i * 1013.25;//mBar
            o[2] = i * 14.6959;//PSI
            o[3] = i * 101325;//Pa
            o[4] = i * 1013.25;//hPa
            o[5] = i * 760; //mmHg
            o[6] = i * 1.03323;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte miligramos de Mercurio al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, mBar, PSI, Pa, hPa, mmHg, kpcm2)</returns>
        public static double[] mmHgTorr(double i)
        {
            double[] o = new double[7];
            o[0] = i / 760;//Atm
            o[1] = i / 750.062;//Bar
            o[2] = i * 1.33322;//mbar
            o[3] = i / 51.715;//PSI
            o[4] = i * 133;//Pa
            o[5] = i * 1.33; //hPa
            o[6] = i / 735.559;//kpcm2
            return o;
        }

        /// <summary>
        /// Convierte Kilopondios por centímetro cuadrado al resto de unidades
        /// </summary>
        /// <param name="i">Valor a convertir</param>
        /// <returns>Array con los valores convertidos (Atm, Bar, mBar, PSI, Pa, hPa, mmHg)</returns>
        public static double[] kpcm2(double i)
        {
            double[] o = new double[7];
            o[0] = i / 1.033;//Atm
            o[1] = i / 1.01972;//Bar
            o[2] = i * 1019.72;//mBar
            o[3] = i * 14.223;//PSI
            o[4] = i * 98067;//Pa
            o[5] = i * 980.67; //hPa
            o[6] = i * 735.559;//mmHg
            return o;
        }
    }
}
