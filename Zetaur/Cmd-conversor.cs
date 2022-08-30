/*#########################################################
 *#    Copyright 2019 Zegameus Company Network Records    #
 *#                     Licencia MIT                      #
 *#########################################################
 */
using System;
using Transformador;

namespace Zetaur
{
    class Cmd_conversor
    {
        #region Menú-Principal
        public static void Cmd_prn()
        {
            bool r = true;
            while (r)
            {
                Console.WriteLine("\nSección de conversiones\nComandos disponibles:\n");
                sbyte[] a = new sbyte[5] { 1, 2, 3, 4, 5 };//Creamos un arreglo que contenga 5 valores (recordad que se empieza n contar desde el 0, por lo tanto es 0,1,2,3,4...).
                //Usamos Sbyte para ocupar el menor espacio en RAM posible.
                //Vamos n mostrar los comandos en pantalla
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{a[0]}: Para ir al menú de temperatura.\n{a[1]}: Para ir al menú de longitud.");
                Console.WriteLine($"{a[2]}: Para ir al menú de masa.\n{a[3]}: Para ir al menú de presión.\n{a[4]}: Para ir al inicio.");
                sbyte i = 0;
                try
                {
                    Console.Write(">> ");
                    i = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducizo no es numérico.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    switch (i)
                    {
                        default:
                        case 0:
                            r = true;
                            Console.Clear();
                            break;
                        case 1:
                            SbmTemp();//Llamamos al método del submenú de temperatura
                            r = true;
                            break;
                        case 2:
                            SmbLong();//Llamamos al método del submenú de longitud
                            r = true;
                            break;

                        case 3:
                            SbmMasa();//Llamamos al método del submenú de masa
                            r = true;
                            break;
                        case 4:
                            SbmPresion();//Llamamos al método del sumbenú de presión
                            r = true;
                            break;

                        case 5:
                            Console.Clear();//Vamos n limpiar la pantalla
                            Console.ForegroundColor = ConsoleColor.Green;//y n cambiarle el color de letra
                            r = false;
                            break;
                    }
                }
            }
        }
        #endregion
        #region Submenú temperatura
        public static void SbmTemp()
        {
            bool rep = true;
            while (rep)
            {
                int[] n = new int[6] { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("\nSección de conversión de temperatura.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nComandos disponibles:\n{0}: Para convertir desde Celsius.\n{1}: Para convertir desde Fahrenheit.", n[0], n[1]);
                Console.WriteLine("{0}: Para convertir desde Kelvins.\n{1}: Para convertir desde Rankine.\n{2}: Para convertir desde Réaumur.", n[2], n[3], n[4]);
                Console.Write("{0}: para volver atras.\n>> ", n[5]);
                sbyte input = 0;
                try
                {
                    input = sbyte.Parse(Console.ReadLine());
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducizo no es numérico.");
                    Console.WriteLine(e.Message);
                }
                Console.ForegroundColor = ConsoleColor.Green;

                switch (input)
                {
                    //En caso de que el valor no esté en lo predefinido o seá 0, lo cual puede significar que ha ocurrido un error.
                    default:
                    case 0:
                        rep = true;
                        Console.Clear();
                        break;

                    case 1:
                        Conv_Temp.TmpCel();
                        rep = true;
                        break;
                    case 2:
                        Conv_Temp.TmpFahr();
                        rep = true;
                        break;
                    case 3:
                        Conv_Temp.TmpKel();
                        rep = true;
                        break;
                    case 4:
                        Conv_Temp.TmpRan();
                        rep = true;
                        break;
                    case 5:
                        Conv_Temp.TmpRea();
                        rep = true;
                        break;
                    case 6:
                        rep = false;
                        break;

                }
            }
        }
        #endregion
        #region Submenú longitud
        public static void SmbLong()
        {
            bool rep = true;
            while (rep)
            {
                sbyte[] n = new sbyte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };//Utilizamos sbyte en vez de int porque utilizamos valores pequeños y no es necesario reservar mucho espacio en la memoria RAM, estos valores van de -128 n 127, por lo que aún nos sobra.
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nComandos disponibles:\n{0}: Para convertir Metros.", n[0]);
                Console.WriteLine("{0}: Para convertir kilometros.\n{1}: Para convertir Millas.", n[1], n[2]);
                Console.WriteLine("{0}: Para convertir Millas náuticas.\n{1}: Para convertir Pulgadas.", n[3], n[4]);
                Console.WriteLine("{0}: Para convertir Yardas.\n{1}: Para convertir Pies", n[5], n[6]);
                Console.WriteLine("{0}: Para volver al menú principal del conversor", n[7]);
                #endregion
                #region if-else
                sbyte i = 0;
                try
                {
                    i = sbyte.Parse(Console.ReadLine());

                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducizo no es numérico.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    switch (i)
                    {
                        case 1://Utilizamos Convert.ToString para poder compararlo con i, ya que la entrada de volver es solo texto
                            Conv_Long.CmdM();//Metros al resto
                            rep = true;
                            break;
                        case 2:
                            Conv_Long.Cmdkm();//Kilometros al resto
                            rep = true;
                            break;
                        case 3:
                            Conv_Long.CmdMi();//Millas
                            rep = true;
                            break;
                        case 4:
                            Conv_Long.CmdNmi();//Millas-Millas Náuticas
                            rep = true;
                            break;

                        case 5:
                            Conv_Long.CmdInc();//Pulgadas
                            rep = true;
                            break;
                        case 6:
                            Conv_Long.CmdYd();//Yardas
                            rep = true;
                            break;
                        case 7:
                            Conv_Long.CmdPie();//Pies
                            rep = true;
                            break;

                        default:
                        case 0:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            rep = false;
                            break;
                    }

                }
            }
        }
        #endregion
        #region Submenú masa
        public static void SbmMasa()
        {
            bool r = true;
            while (r)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                sbyte[] n = new sbyte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine("Comandos disponibles:\n{0}: Conversor Kilogramos.\n{1}: Conversor Gramos.", n[0], n[1]);
                Console.WriteLine("{0}: Toneladas.\n{1}: Conversor Toneladas Cortas.\n{2}: Conversor Toneladas Largas", n[2], n[3], n[4]);
                Console.WriteLine("{0}: Conversor Libras.\n{1}: Conversor Onzas.\n{2}: Conversor \"Stones\".", n[5], n[6], n[7]);
                Console.WriteLine("{0}: Volver al menú.", n[8]);

                sbyte i = 1;
                try
                {
                    i = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducizo no es numérico.");
                    Console.WriteLine(e.Message);
                }
                if (i == n[0])
                {
                    Conv_Masa.CmdKg();
                    r = true;
                }
                else if (i == n[1])
                {
                    Conv_Masa.CmdGr();
                    r = true;
                }
                else if (i == n[2])
                {
                    Conv_Masa.CmdT();
                    r = true;
                }
                else if (i == n[3])
                {
                    Conv_Masa.CmdUsT();
                    r = true;
                }
                else if (i == n[4])
                {
                    Conv_Masa.CmdUkT();
                    r = true;
                }
                else if (i == n[5])
                {
                    Conv_Masa.CmdLb();
                    r = true;
                }
                else if (i == n[6])
                {
                    Conv_Masa.CmdOz();
                    r = true;
                }
                else if (i == n[7])
                {
                    Conv_Masa.CmdSt();
                    r = true;
                }
                else if (i == n[8])
                {
                    r = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Comando no encontrado.");
                    r = true;
                }
            }
        }
        #endregion
        #region Submenú Presión
        public static void SbmPresion()
        {
            bool r = true;
            while (r)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                sbyte[] n = new sbyte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//Le asignamos un valor de cantidades máximas
                Console.WriteLine($"Comandos disponibles:\n{n[0]}: Conversor Atmósferas.\n{n[1]}: Conversor Bares.\n{n[2]}: Conversor Milibares.");
                Console.WriteLine($"{n[3]}: Conversor Pascales.\n{n[4]}: Conversor HectoPascales.\n{n[5]}: Conversor PSI.\n{n[6]}: Conversor mmHg y Torr.");
                Console.WriteLine($"{n[7]}: Conversor Kiloponidos por cm2.\n{n[8]}: Volver al menú.");
                sbyte i = 1;
                try
                {
                    Console.Write(">> ");
                    i = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("El valor introducido no es númerico");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    switch (i)
                    {
                        default:
                        case 0:
                            r = true;
                            Console.Clear();
                            break;
                        case 1:
                            Conv_Presion.CmdAtm();//Atmosferas técnicas
                            r = true;
                            break;
                        case 2:
                            Conv_Presion.CmdBar();//Bares
                            r = true;
                            break;
                        case 3:
                            Conv_Presion.CmdmBar();//Milibares
                            r = true;
                            break;
                        case 4:
                            Conv_Presion.CmdPa();//Pascales
                            r = true;
                            break;
                        case 5:
                            Conv_Presion.CmdhPa();//Hectopascales
                            r = true;
                            break;
                        case 6:
                            Conv_Presion.CmdPSI();//PSI
                            r = true;
                            break;
                        case 7:
                            Conv_Presion.CmdmmhgTorr();//Milimetros de mercurio y Torrs
                            r = true;
                            break;
                        case 8:
                            Conv_Presion.CmdKpcm2();//Kilopondios por centrimetro cuadrado
                            r = true;
                            break;
                        case 9:
                            r = false;
                            Console.Clear();
                            break;
                    }
                }
            }
        }
        #endregion
    }
}

