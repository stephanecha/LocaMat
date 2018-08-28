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
            Console.WriteLine("VOITURES");
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
                        //AfficherMarques();
                        break;

                    case 3:
                        //CreerMarque();
                        break;

                    case 4:
                        //ModifierMarque();
                        break;

                    case 5:
                        //SupprimerMarque();
                        break;

                    case 9:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Appuyez pour retourner au menu...");
                Console.ReadKey();
            }
        }

   

        private static void AfficherProduits()
        {
            Console.WriteLine();
            Console.WriteLine("> Produits");

            using (var contexte = new Contexte())
            {
                var produits = contexte.Produits;
                    //.OrderBy(x => x.Nom).ToList();
                foreach (var produit in produits)
                {
                    //var nombreModeles = contexte.Modeles
                    //    .Where(x => x.IdMarque == marque.Id)
                    //    .Count();
                    //Console.WriteLine($"{marque.Nom} ({marque.Id}): {nombreModeles} modèle(s)");

                    Console.WriteLine($"{produit.Nom} ({produit.Id})");
                }
            }
        }
        private static int AfficherMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Afficher les Produits");
            Console.WriteLine("2. Afficher les Clients");
            Console.WriteLine("3. Afficher les Agences");
           
            Console.WriteLine("9. Quitter");

            Console.Write("Votre choix: ");
            return int.Parse(Console.ReadLine());
        }


    }
}

