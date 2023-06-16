using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Banque.Models
{
    public class Compte
    {
        public string Numero { get; set; }

        public decimal Solde { get; private set; }

        public Personne Titulaire { get; set; }

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                return;
            }
            Solde += montant;
        }

        // Methode dite virtual pour permetrre l override dans les class enfant.
        public virtual void Retrait(decimal montant)
        {
            // Si on arrive ici dans le code c'est que le retrait ne prend pas en compte de limit (ligne de credit)
            // Du coup on fixe la limite à 0
            Retrait(montant, 0);
        }

        // Surcharge pour prendre en compte l'eventuelle ligne de credit
        public void Retrait(decimal montant, decimal limit)
        {
            if (montant < 0)
            {
                return;
            }
            if(Solde - montant < -limit)
            {
                return;
            }
            Solde -= montant;
        }

        // Surcharge de l operateur +
        // Nous permet maintenant d'additionné un decimal avec un compte sans plus jamais spécifié le solde
        public static decimal operator +(decimal somme, Compte c)
        {
            //if(c.Solde < 0)
            //{
            //    return somme;
            //}
            //return somme + c.Solde;

            //On prend en compte le Solde que si il est positif
            return somme + (c.Solde <= 0 ? 0 : c.Solde);
        }

        public override string ToString()
        {
            return $"Numero : {Numero}\n" +
                   $"Titulaire : {Titulaire.Prenom}" +
                   $"_____________________________________________";
        }
    }
}
