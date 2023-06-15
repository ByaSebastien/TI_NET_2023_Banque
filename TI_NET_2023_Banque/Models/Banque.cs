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
    }
}
