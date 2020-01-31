//Enrick De Munter nr3 5itn 31/01/2020
/*OPGAVE
 * ======
 * v1: berken het gemiddelde van een lijst met getallen
 * 
 * ANALYSE 
 * =======
 * 
 * BEREKEN  lijst
 * BEREKEN  som:
 *          HERHAAL     voor elk getalin de lijst
 *               som = som + getal
 * 
 * 
 * BEREKEN  aantal (= lengte van lijst
 * BEREKEN  gemmiddelde (=som/aantal)
 * TOON     gemmiddelde     
 * 
 *  
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGemmiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIES
            byte[] getallen = { 10, 1, 8, 6, 7, 4 };
            List<byte> nogWatGetallen;
            float gemiddelde;
            //input
            //geen input
            // BEREKEN  som:
           
            // BEREKEN  gemmiddelde (=som/aantal)
            
            gemiddelde = Gemmiddelde(getallen);
            Console.WriteLine($"het gemmiddelde is {gemiddelde}");
            
            // TOON     gemmiddelde    
            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
        /// <summary>
        /// bereken het gemmiddelde van een lijst met getallen 
        /// </summary>
        /// <param name="lijst"></param>
        /// <returns></returns>
        private static float Gemmiddelde(byte[] lijst)
        {
            byte som = 0, aantal;
            float returnvalue, gemiddelde;
            //input
            //geen input
            // BEREKEN  som:
            foreach (byte getal in lijst)
            {
                som += getal;
            }
            //          HERHAAL     voor elk getalin de lijst
            //               som = som + getal
            // 
            // BEREKEN  aantal (= lengte van lijst
            aantal = (byte)lijst.Length;
            // BEREKEN  gemmiddelde (=som/aantal)
            gemiddelde = (float)(som / aantal);
            gemiddelde = Gemmiddelde(lijst);
            Console.WriteLine($"het gemmiddelde is {gemiddelde}");

            
        }
    }
}
