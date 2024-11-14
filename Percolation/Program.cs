using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percolation
{
    class Program
        // Réponse 3b : Dans le pire cas, la totalité des case du haut sont ouvertes, excépté celles des coins inférieurs. L'eau va ainsi s'accumuler au centre de la grille
        //
        //
        //Réponse 3 c : Il Est impossible que cela se produise, car il faudrait remplir les cases ouvertes
        //

    {
        static void Main(string[] args)
        {
            Percolation var1 = new Percolation(3);
            List<KeyValuePair<int, int>> List = var1.CloseNeighbors(2, 2);
            
        }
    }
}
