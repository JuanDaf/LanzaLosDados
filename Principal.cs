using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Lanzar_los_dados
{
    public class Principal
    {
        public static void Main(string[] args) 
        {
            Dados dados = new Dados();
            var (salir, num) = (false,0);
            while (salir == false)
            {
                Console.WriteLine("Hola bienvenido al juego de lanzar dados...");
                Console.WriteLine("Selecciona la opcion  que desees, solo estoy acá para que te diviertas =#");
                Console.WriteLine("1. Aquí podras selccionar el nunmero de lanzamientos para el dado");
                Console.WriteLine("2. Iniciar los Lanzamientos");
                Console.WriteLine("3. Revisa los resultado de los lanzamientos :3");
                Console.WriteLine("4. Revisa el numero mas repetido :3");
                Console.WriteLine("5. Numeros obtenidos =)");
                Console.WriteLine("6. Salir");
                try
                { opcion op = (opcion)Convert.ToInt64(Console.ReadLine()); 
               
                switch (op)
                {
                    case opcion.numero:
                        Console.WriteLine("------------------------------------------------------------------");
                        num = dados.numTiros();
                        Console.WriteLine("------------------------------------------------------------------");
                        break;
                    case opcion.lanzar:
                        if (num == 0)
                        {
                            Console.WriteLine("Primero selecciona el numero de tiros para el dado..");
                        } else {
                            Console.WriteLine("--------------------------------------------------------------");
                            dados.lanzamientos(num);
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                        break;
                    case opcion.ver:
                        if (num == 0)
                        {
                            Console.WriteLine("Primero selecciona el numero de tiros para el dado..");
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            dados.mostrarLanzamientos();
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                        break;
                    case opcion.repe:
                        if (num == 0)
                        {
                            Console.WriteLine("Primero selecciona el numero de tiros para el dado..");
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            var listOrden = dados.lanzamientosAgrupados();
                            int i = 0;
                            foreach (var item in dados.numerosRepetidos())
                            {
                                Console.WriteLine($"Num:{listOrden.ToList()[i]} Veces: {item}");
                                i++;
                            }
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                        break;
                    case opcion.obte:
                        if (num == 0)
                        {
                            Console.WriteLine("Primero selecciona el numero de tiros para el dado..");
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            foreach (var item in dados.lanzamientosAgrupados())
                            {
                                Console.WriteLine($"{item}");
                            }
                           
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                        break;
                    case opcion.salir:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta...");
                        break;
                }
                }
                catch (Exception) { Console.WriteLine("Ingresa un numero..."); }
            }
        }
    }
    public enum opcion
    {
        numero = 1,
        lanzar = 2,
        ver = 3,
        repe = 4,
        obte =5,
        salir = 6

    }
}
