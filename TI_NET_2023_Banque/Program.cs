using TI_NET_2023_Banque.Models;

//declaration + instanciation d un objet client de la classe Personne
Personne client = new Personne();
client.Nom = "Bya";
client.Prenom = "Seb";
client.DateNaiss = new DateTime(1991, 3, 27);

Courant c = new Courant();
c.Numero = "123";
c.LigneDeCredit = 100;
c.Titulaire = client;
c.Depot(100);
c.Retrait(1000);

Courant c2 = new Courant()
{
    Numero = "456",
    LigneDeCredit = 500,
    Titulaire = client,
};

c2.Depot(1000);

Banque belfius = new Banque();
belfius.Nom = "Belfius";

belfius.Ajouter(c);
belfius.Ajouter(c2);

Epargne e = new Epargne()
{

};

//Console.WriteLine(belfius["123"].Titulaire.DateNaiss.Day);

//Courant nouveauCompte = creerCompte();

//belfius.Ajouter(nouveauCompte);

//foreach(Courant compte in belfius.Comptes.Values)
//{
//    Console.WriteLine(compte);
//}

//Console.WriteLine("Quel compte voulez vous regarder? ");
//string num = Console.ReadLine();
//Console.WriteLine(belfius[num]);

Console.WriteLine(belfius.AvoirDesComptes(client));

Courant creerCompte()
{
    Console.WriteLine("Titulaire du compte : ");
    Console.Write("Nom : ");
    string nom = Console.ReadLine();
    Console.Write("Prenom : ");
    string prenom = Console.ReadLine();
    Console.WriteLine("Date de naissance : ");
    Console.Write("Jour : ");
    int jour = int.Parse(Console.ReadLine());
    Console.Write("Mois : ");
    int mois = int.Parse(Console.ReadLine());
    Console.Write("Annee : ");
    int annee = int.Parse(Console.ReadLine());
    Console.WriteLine("Compte :");
    Console.Write("Numero : ");
    string numero = Console.ReadLine();
    Console.Write("Ligne de credit : ");
    int ligneDeCredit = int.Parse(Console.ReadLine());

    Courant nouveauCompte = new Courant()
    {
        Numero = numero,
        LigneDeCredit = ligneDeCredit,
        Titulaire = new Personne()
        {
            Nom = nom,
            Prenom = prenom,
            DateNaiss = new DateTime(annee,mois,jour)
        }
    };
    return nouveauCompte;
}