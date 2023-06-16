using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_Banque.Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes;

        public Dictionary<string, Courant> Comptes
        {
            get 
            { 
                //if(_comptes is null)
                //{
                //    return new Dictionary<string, Courant>();
                //}
                //return _comptes; 
                //return _comptes = _comptes ?? new Dictionary<string, Courant>();
                return _comptes ??= new Dictionary<string, Courant>();
            }
        }

        public string Nom { get; set; }

        public Courant this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Courant c);
                return c;
            }
        }

        public void Ajouter(Courant c)
        {
            Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        /// <summary>
        /// Permet de connaitre les avoirs d'une personne p
        /// </summary>
        /// <param name="p">La personne en question</param>
        /// <returns>La somme de tout ses comptes en positif</returns>
        public decimal AvoirDesComptes(Personne p)
        {
            decimal somme = 0;

            // On parcourt tout le dictionnaire (la clef et la valeur) dans un KeyValuePair

            //foreach(KeyValuePair<string,Courant> kvp in Comptes)
            //{
            //    if(kvp.Value.Titulaire == p)
            //    {
            //        somme += kvp.Value;
            //    }
            //}

            // On parcourt les Valeurs du dictionnaire pour les sommer dans une variable locale
            foreach (Courant c in Comptes.Values)
            {
                if (c.Titulaire == p)
                {
                    somme += c;
                }
            }

            return somme;

            // LinQ
            //return Comptes.Values.Where(c => c.Titulaire == p).Sum(c => c.Solde);
        }
    }
}
