using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lanzar_los_dados
{
    public class Dados
    {
        List<int> lanzamietos = new List<int>();   
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
        public int lanzamientos()
        {
            Random random = new Random(); 
            var (tiros, dado )= ( numTiros(), 0 );
            while (tiros != 0) 
            {
                dado = random.Next(1,6);
                agregarLanzamiento(dado);
                tiros--;
            }
            return dado;
        }

        public void agregarLanzamiento( int tiro)
        {
            lanzamietos.Add(tiro);
        }
       
    }
}
