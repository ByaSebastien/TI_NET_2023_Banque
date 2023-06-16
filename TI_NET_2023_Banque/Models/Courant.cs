using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Banque.Models
{
    public class Courant : Compte
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

        public override void Retrait(decimal montant)
        {
            // Appel de la surcharge de la methode retrait de la class parent (Compte)
            // etant donné que la surcharge n'est pas virtual et jamais override le base. n'est pas necessaire
            base.Retrait(montant,LigneDeCredit);
        }
    }
}
