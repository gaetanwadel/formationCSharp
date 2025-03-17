using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class CompteBancaire
    {

        public decimal Solde = 0;
        public int Identifiant;
        public List<Transaction> Historique { get; set; }


        public CompteBancaire(decimal solde, int identifiant)
        {
            Identifiant = identifiant;
            Solde = solde;
            Historique = new List<Transaction>();
        }
       
        public void AjouterArgent(Transaction transaction)
        {
            Solde += transaction.Montant;

        }

        // Méthode retrait
        public void RetirerArgent(Transaction transaction)
        {
            
            Solde -= transaction.Montant;
            
	        
          
        }
       

        public void AjoutHistoric(Transaction transaction)
        {
            if (Historique.Count() <= 9)
            {
                Historique.Add(transaction);
            }
            else
            {
                Historique.RemoveAt(0);
                Historique.Add(transaction);
            }
        }
        public decimal SommeTransaction(decimal montantactuel)
        {

            decimal somme_montant = montantactuel;

            foreach (var transaction in Historique)
            {
                somme_montant += transaction.Montant;

            }
            return somme_montant;
        }

    }
}






