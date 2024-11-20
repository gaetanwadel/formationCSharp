using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Banque
    {
        private Dictionary<int, CompteBancaire> _Comptes = new Dictionary<int, CompteBancaire>();
        private Dictionary<int, Transaction> _Transactions = new Dictionary<int, Transaction>();
        private Dictionary<int, bool> _StatutsTransaction = new Dictionary<int, bool>();


        public void LectureFichierCompte()
        {
       
            using (FileStream fs1 = File.OpenRead(@"C:\Users\Formation\Documents\Entrée\Compte.csv"))
            using (StreamReader fichier1 = new StreamReader(fs1))
            {
                while (!fichier1.EndOfStream)
                {
                    string[] infocompte = fichier1.ReadLine().Split(';');
                    if (infocompte.Length != 2)
                    {
                        continue;
                    }
                    CreationDictionaireCompte(infocompte);
                }
            }
        }
        public void CreationDictionaireCompte(string[] infocompte)
        {
            string identifiant = infocompte[0];
            string solde = infocompte[1];

            int ID; //= int.Parse(identifiant);
            if (!int.TryParse(identifiant, out ID))
            {
                return;
            }
            int SLD = int.Parse(solde);

            CompteBancaire compte = new CompteBancaire(SLD, ID);
            _Comptes.Add(ID, compte);
        }

        public void LectureFichierTransaction()
        {

            using (FileStream fs2 = File.OpenRead(@"C:\Users\Formation\Documents\Entrée\Transaction.csv"))
            using (StreamReader fichier2 = new StreamReader(fs2))
            {
                while (!fichier2.EndOfStream)
                {
                    string[] infotransa = fichier2.ReadLine().Split(';');
                    if (infotransa.Length != 4)
                    {
                        continue;
                    }
                    CreationDictionnaireTransaction(infotransa);
                }
            }
        }
        public void CreationDictionnaireTransaction(string[] infotransa)
        {
            string ident = infotransa[0];
            string montant = infotransa[1];
            string expediteur = infotransa[2];
            string destinataire = infotransa[3];

            int IDE; // = int.Parse(ident);

            if (!int.TryParse(ident, out IDE))
            {
                return;
            }

            int MTNT = int.Parse(montant);
            int EXP; 
            if (!int.TryParse(expediteur, out EXP))
            {
                return;
            }
            int DEST = int.Parse(destinataire);
            if (!int.TryParse(destinataire, out DEST))
            {
                return;
            }
            Transaction transaction = new Transaction(IDE, MTNT, EXP, DEST);
            _Transactions.Add(IDE, transaction);
        }
      
        public void GestionTransaction()
        {
            foreach (var transaction in _Transactions)
            {
                bool istransactionok;
                if (transaction.Value.Expediteur == 0)
                {
                    istransactionok = Depot(transaction.Value, _Comptes[transaction.Value.Destinataire]);
                }
                else if (transaction.Value.Destinataire == 0)
                {
                    istransactionok = Retrait(transaction.Value, _Comptes[transaction.Value.Expediteur]);
                }
                else
                {
                    istransactionok = Virement(transaction.Value, _Comptes[transaction.Value.Destinataire], _Comptes[transaction.Value.Expediteur]);
                }

                _StatutsTransaction.Add(transaction.Key, istransactionok);
            }
        }
        public bool Depot(Transaction transaction, CompteBancaire destinataire)
        {
            if (transaction.Montant > 0)

            {
                destinataire.AjouterArgent(transaction);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Retrait(Transaction transaction, CompteBancaire expediteur)
        {
            if (transaction.Montant > 0 && expediteur.Solde >= transaction.Montant && expediteur.SommeTransaction(transaction.Montant)<1000)
            {
                expediteur.RetirerArgent(transaction);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Virement(Transaction transaction, CompteBancaire destinataire, CompteBancaire expediteur)
        {
            if (transaction.Montant > 0 && expediteur.Solde >= transaction.Montant && expediteur.SommeTransaction(transaction.Montant) < 1000)
            {
                expediteur.RetirerArgent(transaction);
                destinataire.AjouterArgent(transaction);
                return true;
            }
            else
            {
                return false;
            }

        }
      
        public void EcritureFichierCompte()

        {
            using (FileStream fs3 = File.Create(@"C:\Users\Formation\Documents\Sortie\Statuts-Transaction.csv"))

            using (StreamWriter fichier3 = new StreamWriter(fs3))
            {
                foreach (var statut in _StatutsTransaction)
                {
                    if (statut.Value)
                    {
                        fichier3.WriteLine($"{statut.Key};OK");
                    }
                    else
                    {
                        fichier3.WriteLine($"{ statut.Key};KO");
                    }
                }
            }

        }
    }
}

