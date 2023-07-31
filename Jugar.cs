using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzar_los_dados
{
    public class Jugar 
    {
       public static void Main()
       {
            Dados dados = new Dados();
            bool salir = true;
            while (salir  = false)
            {
                Console.WriteLine("Hola bienvenido al juego de lanzar dados...");
                Console.WriteLine("Selecciona la opcion  que desees, solo estoy acá para que te diviertas =#");
                Console.WriteLine("0. Aquí podras selccionar el nunmero de lanzamientos para el dado");
                Console.WriteLine("1. Iniciar los Lanzamientos");
                Console.WriteLine("2. Revisa los resultad de los lanzamientos :3");
                Console.WriteLine("3. Salir");
                opcion op = new();
                switch (op)
                {
                    case opcion.numero:
                        break;
                    case opcion.lanzar:
                        break;
                    case opcion.ver:
                        break;
                    case opcion.salir:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta...");
                        break;
                }
            }
       }
         
    }

    public enum opcion
    {
        numero,
        lanzar,
        ver,
        salir

    }
}
