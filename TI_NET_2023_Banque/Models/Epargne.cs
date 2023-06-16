using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Banque.Models
{
    public class Epargne : Compte
    {
        public DateTime DateDernierRetrait { get; private set; }

        public override void Retrait(decimal montant)
        {
            decimal ancientSolde = Solde;
            // appel de la methode retrait dans la class parent (Compte)
            base.Retrait(montant);
            if(Solde < ancientSolde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }
    }
}
