using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace Lanzar_los_dados
{
    public class Dados
    {
        public List<int> lanzamietos = new List<int>();   
        public Dados() { }

        public int numTiros() 
        {
            Console.WriteLine("INGRESA EL # DE LANZAMIENTOS PARA ESTA RONDA: ");
            try
            {
                int tiros = Convert.ToInt32(Console.ReadLine());
                return tiros;
            } catch (Exception e) { Console.WriteLine(e.Message); return 0; }
        }
        public int lanzamientos(int numTiro)
        {
            Random random = new Random();
            var (tiros, dado )= (numTiro, 0 );
            while (tiros != 0) 
            {
                dado = random.Next(1, 6);
                
                Console.WriteLine("Lanzando el dado..");
                Console.ReadKey();
                Console.WriteLine("Tu tiro es: " + dado);

                agregarLanzamiento(dado);
                tiros--;
            }
            return dado;
        }

        public void agregarLanzamiento( int tiro)
        {
            lanzamietos.Add(tiro);
        }

        public void mostrarLanzamientos()
        {
            lanzamietos.ForEach(x => Console.WriteLine($"Lanzamiento: {x}"));
        }

        public IEnumerable<int> numerosRepetidos()
        {
            var lista = lanzamietos.GroupBy(y => y).Select(x => x.Count());
            return lista;
        }
        public IEnumerable<int> lanzamientosAgrupados()
        {
            return lanzamietos.Select(x => x).Distinct();
        }
       
    }
}
