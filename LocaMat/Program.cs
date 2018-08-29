using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LocaMat.Classes;
using LocaMat.Data;

namespace LocaMat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LocaMat");
            Console.WriteLine();

            while (true)
            {
                var choix = AfficherMenu();
                switch (choix)
                {
                    case 1:

                        AfficherProduits();
                        break;

                    case 2:
                        AfficherClients();
                        break;

                    case 3:
                        AfficherAgences();
                        break;

                    case 4:
                        ModifierClients();
                        break;

                    case 5:
                        CreerClients();
                        break;
                    case 6:
                        SuprimerClients();
                        break;
                    case 7:
                        AfficherOffresProduit();
                        break;
                    case 8:
                        AfficherProduitAgence();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Appuyez pour retourner au menu...");
                Console.ReadKey();
            }
        }

        private static void AfficherProduitAgence()
        {
            Console.WriteLine();
            Console.WriteLine("> AfficherProduitAgence");
            AfficherAgences();
            Console.WriteLine("> Afficher Produit de quelle agence?");
            var idagence = Console.ReadKey();

            using (var contexte = new Contexte())
            {
                var agences = contexte.Agences;
                //.OrderBy(x => x.Nom).ToList();
                foreach (var agence in agences)
                {
                    //Console.WriteLine($"({agence.Produit}) {agence.} {agence.IdAgence} ");
                }
            }
        }

        private static void AfficherOffresProduit()
        {
            Console.WriteLine();
            Console.WriteLine("> OffresProduit");

            using (var contexte = new Contexte())
            {
                var offresproduits = contexte.OffresProduits;
                //.Single(x => x.Id).ToList();
                foreach (var offresproduit in offresproduits)
                {
                    Console.WriteLine($"({offresproduit.Id}) {offresproduit.IdProduit} {offresproduit.IdAgence} ");
                }
            }
        }

        private static void SuprimerClients()
        {
            throw new NotImplementedException();
        }

        private static void ModifierClients()
        {
            throw new NotImplementedException();
        }

        private static void CreerClients()
        {
            Console.WriteLine();
            Console.WriteLine(">Nouveau Client");
            Console.WriteLine(">entrer Nom");
            var nomClient = Console.ReadLine();
            Console.WriteLine(">entrer Prenom");
            var prenomClient = Console.ReadLine();
            Console.WriteLine(">entrer Adresse");
            var adresseClient = Console.ReadLine();

            var client = new Client();
            client.Nom = nomClient;
            client.Prenom = prenomClient;
            client.Adresse = adresseClient;

            using (var contexte = new Contexte())
            {
                contexte.Clients.Add(client);
                contexte.SaveChanges();
            }
        }

        private static void AfficherAgences()
        {
            Console.WriteLine();
            Console.WriteLine("> Agences");

            using (var contexte = new Contexte())
            {
                var agences = contexte.Agences;
                //.OrderBy(x => x.Nom).ToList();
                foreach (var agence in agences)
                {
                    Console.WriteLine($"({agence.Id}) {agence.Ville} {agence.Adresse} ");
                }
            }
        }

        private static void AfficherClients()
        {
            Console.WriteLine();
            Console.WriteLine("> Clients");

            using (var contexte = new Contexte())
            {
                var clients = contexte.Clients;
                //.OrderBy(x => x.Nom).ToList();
                foreach (var client in clients)
                {
                    Console.WriteLine($"Client ID {client.Id}NOM {client.Nom}PRENOM {client.Prenom}ADRESSE{client.Adresse}");
                }
            }
        }

        private static void AfficherProduits()
        {
            Console.WriteLine();
            Console.WriteLine("> Produits");

            using (var contexte = new Contexte())
            {
                var produits = contexte.Produits
                        .OrderBy(x => x.Nom).ToList();
                foreach (var produit in produits)
                {
                    //var nombreModeles = contexte.Modeles
                    //    .Where(x => x.IdMarque == marque.Id)
                    //    .Count();
                    //Console.WriteLine($"{marque.Nom} ({marque.Id}): {nombreModeles} modèle(s)");

                    Console.WriteLine($"{produit.Id}{produit.Nom}{produit.PrixJourHT} ()");
                }
            }
        }
        private static int AfficherMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Afficher les Produits");
            Console.WriteLine("2. Afficher les Clients");
            Console.WriteLine("3. Afficher les Agences");
            Console.WriteLine("4. Modifier Client");
            Console.WriteLine("5 Creer client");
            Console.WriteLine("6. sup client");
            Console.WriteLine("7. AfficherOffresProduit");
            Console.WriteLine("8. AfficherProduitAgence");

            Console.WriteLine("9. Quitter");

            Console.Write("Votre choix: ");
            return int.Parse(Console.ReadLine());
        }


    }
}

