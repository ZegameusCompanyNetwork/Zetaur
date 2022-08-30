using System;

namespace Zetaur_Conv
{
    /// <summary>
    /// Clase en construcción
    /// </summary>
    public class Op_Fuerza
    {
        static readonly string[] p = { "Newtons (N)", "Kilogramo fuerza (Kp o kgf)", "Dina (dyn)", "Poundal (pdl)" };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="N"></param>
        private static double[] OpN(double N)
        {
            //con Math.Pow multiplicamos por la potencia de 10 ^ -5
            double kp = N / 9.807, dyn = N * Math.Pow(10, -5), pdl= N*7.23301;
            double[] o = {kp, dyn, pdl};
            //Console.WriteLine($"{N} {p[0]} son:\n{kp} {p[1]}.\n{dyn} {p[2]}.\n{pdl} {p[3]}");
            return o;
        }
    }
}
