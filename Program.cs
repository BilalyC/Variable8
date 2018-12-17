using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez donner un rayon r : ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Le périmètre est : " + (Math.PI * (2 * r)));
            Console.WriteLine("La surface est : " + (Math.PI * Math.Pow(r, 2)));
        }
    }
}
