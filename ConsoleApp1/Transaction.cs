using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        public int Identifiant;
        public decimal Montant;
        public int Expediteur;
        public int Destinataire;

        public Transaction(int identifiant, decimal montant, int expediteur, int destinataire)
        {
            Identifiant = identifiant;
            Montant = montant;
            Expediteur = expediteur;
            Destinataire = destinataire;
        }
    }
}
