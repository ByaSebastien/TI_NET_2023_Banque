using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Banque.Models
{
    public class Courant
    {
        private decimal _ligneDeCredit;
        public decimal LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                // value est un mot clef qui designe la valeur qu'on essaiera d affecter a la variable au moment de l utilisation
                if(value < 0)
                {
                    return;
                }
                _ligneDeCredit = value;
            }
        }

        public string Numero { get; set; }

        public decimal Solde { get; private set; }

        public Personne Titulaire {  get; set; }

        public void Depot(decimal montant)
        {
            if(montant < 0)
            {
                return;
            }
            Solde += montant;
        }

        public void Retrait(decimal montant)
        {
            if(montant < 0)
            {
                return;
            }
            if(Solde - montant < -LigneDeCredit)
            {
                return;
            }
            Solde -= montant;
        }

        public override string ToString()
        {
            return $"Numero : {Numero}\n" +
                   $"Titulaire : {Titulaire.Prenom}" +
                   $"_____________________________________________";
        }
    }
}
