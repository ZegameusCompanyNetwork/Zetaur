using System;

namespace Zetaur_Conv
{
    /// <summary>
    /// Accede a los métodos de conversión de unidades de masa.
    /// <list type="bullet">
    /// <item><description>Kilogramos</description></item>
    /// <item><description>Gramos</description></item>
    /// <item><description>Toneladas (métricas)</description></item>
    /// <item><description>Toneladas Cortas (Us t)</description></item>
    /// <item><description>Toneladas Largas (Uk t)</description></item>
    /// <item><description>Onzas</description></item>
    /// <item><description>Libras</description></item>
    /// <item><description>Stones</description></item>
    /// </list>
    /// </summary>
    public class Op_Masa
    {
        /// <summary>
        /// 0 = Kg, 1 = g, 2 = t, 3 = US t, 4 = UK t, 5 = Oz, 6 = Lb, 7 = St
        /// </summary>
        static readonly string[] masas = { "Kilogramos (kg)", "Gramos (g)", "Toneladas (t)", "Tonelada Corta (US t)", "Tonelada larga (UK t)", "Onzas (Oz)", "Libras (lb)", "Stones (st)" };
        #region Kilogramos-Gramos
        /// <summary>
        /// Transforma Kilogramos al resto de unidades <see cref="Op_Masa"/>
        /// </summary>
        /// <param name="i">Kg es un número double.</param>
        /// 
        /// <returns>Array con los valores convertidos (g, t, US t, Uk t, Oz, Lb, St)</returns>
        public static double[] OpKg(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1000; //g
            o[1] = i / 1000;//t
            o[2] = i /907.185;//UsT
            o[3] = i / 1016;//Uk t
            o[4] = i * 35.274;//Oz
            o[5] = i * 2.20462;//Lb
            o[6] = i * 6.35029318;//St
            return o;
        }
        /// <summary>
        /// Transforma Gramos (g) al resto de unidades <see cref="Op_Masa"/>
        /// </summary>
        /// <param name="i">g es un número double </param>
        /// 
        /// <returns>Array con los valores convertidos (Kg, t, US t, Uk t, Oz, Lb, St)</returns>
        public static double[] OpG(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1000; //kg
            o[1] = i * Math.Pow(10, -6);//t
            o[2] = i / 907185;//UsT
            o[3] = i / (1.016 * Math.Pow(10, 6));//Uk t
            o[4] = i / 28.3495;//Oz
            o[5] = i / 453.592;//Lb
            o[6] = i / 6350.29318;//St
            return o;
        }
        #endregion
        #region Toneladas
        /// <summary>
        /// Transforma toneladas (métricas) al resto de unidades <see cref="Op_Masa"/>.
        /// </summary>
        /// <param name="i">T es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, US t, Uk t, Oz, Lb, St)</returns>
        public static double[] OpT(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1000; //kg
            o[1] = i * Math.Pow(10, 6);//g
            o[2] = i * 1.10231;//UsT
            o[3] = i / 1.016;//Uk t
            o[4] = i * 35274;//Oz
            o[5] = i * 2204.62;//Lb
            o[6] = i * 157;//St
            return o;
        }
        /// <summary>
        /// Transforma toneladas cortas (Us t) al resto de unidades <see cref="Op_Masa"/>.
        /// </summary>
        /// <param name="i">UsT es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, t, Uk t, Oz, Lb, St)</returns>
        public static double[] OpUsT(double i)
        {
            double[] o = new double[7];

            o[0] = i * 907.185;
            o[1] = i * 907185;
            o[2] = i / 1.10231;
            o[3] = i / 1.12;
            o[4] = i * 32000;
            o[5] = i * 2000;
            o[6] = i * 142.857;
            return o;
        }
        /// <summary>
        /// Transforma Toneladas Largas (Uk T) al resto de unidades <see cref="Op_Masa"/>
        /// </summary>
        /// <param name="i">UkT es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, t, US t, Oz, Lb, St)</returns>
        public static double[] OpUkT(double i)
        {
            double[] o = new double[7];
            o[0] = i * 1026;//Kg
            o[1] = i * 1.016 * Math.Pow(10, -6);//g
            o[2] = i * 1.016;//T
            o[3] = i * 1.12;//US t
            o[4] = i * 35840;//Oz
            o[5] = i * 2240;//Lb
            o[6] = i * 160;//St
            return o;
        }
        #endregion
        #region Libras-Onzas-Stones
        /// <summary>
        /// Transforma Onzas (Oz) al resto de unidades <see cref="Op_Masa"/>.
        /// </summary>
        /// <param name="i">Oz es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, t, US t, Uk t, Lb, St)</returns>
        public static double[] OpOz(double i)
        {
            double[] o = new double[7];

            o[0] = i / 35.274; //Kg
            o[1] = i * 28.3495; //g
            o[2] = i / 35274; //t
            o[3] = i / 35840;//US t
            o[4] = i / 32000;//Uk t
            o[5] = i / 16; //Lb
            o[6] = i / 224;//St
            return o;
        }
        /// <summary>
        /// Transforma Libras (Lb) al resto de unidades <see cref="Op_Masa"/>.
        /// </summary>
        /// <param name="i">Lb es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, t, US t, Uk t, Oz, St)</returns>
        public static double[] OpLb(double i)
        {
            double[] o = new double[7];
            o[0] = i / 2.205;//Kg
            o[1] = i / 454;//g
            o[2] = i / 2205;//t
            o[3] = i / 2240;//US t
            o[4] = i / 2000;//Uk t
            o[5] = i * 16;//Oz
            o[6] = i / 14;//St
            return o;
        }
        /// <summary>
        /// Transforma Stones (St) al resto de unidades <see cref="Op_Masa"/>.
        /// </summary>
        /// <param name="i">St es un número double.</param>
        /// <returns>Array con los valores convertidos (Kg, g, t, US t, Uk t, Oz, Lb)</returns>
        public static double[] OpSt(double i)
        {
            double[] o = new double[7];
            o[0] = i * 6.35029; //Kg
            o[1] = i * 6350.29; //g
            o[2] = i / 157; //t
            o[3] = i / 160; //US t
            o[4] = i / 143; //Uk t
            o[5] = i * 224; //Oz
            o[6] = i * 14; //Lb
            return o;
        }
        #endregion
    }
}
