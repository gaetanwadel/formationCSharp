using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Banque banque = new Banque();

            banque.LectureFichierCompte();
            banque.LectureFichierTransaction();
            banque.GestionTransaction();
            banque.EcritureFichierCompte();




        } 
    }
}
       

