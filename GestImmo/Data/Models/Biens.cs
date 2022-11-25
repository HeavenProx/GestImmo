using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Biens
    {
        public int BiensId { get; set; }

        private string nom;
        private int valeur;
        private string adresse;
        private int surface;
        private List<Contrat>? listContrat = new List<Contrat>();
        private List<Intervention>? listIntervention = new List<Intervention>();
        private Pret? pret;

        public string Nom { get => nom; set => nom = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Surface { get => surface; set => surface = value; }


        //public List<Contrat> ListContrat { get => listContrat; set => listContrat = value; }
        //public List<Intervention> ListIntervention { get => listIntervention; set => listIntervention = value; }
        //public Pret? Pret { get => pret; set => pret = value; }

        //public virtual int benefNet()
        //{
        //    int loyer = ListContrat[ListContrat.Count - 1].Loyer;
        //    int Net = loyer;
        //    if (Pret != null)
        //    {
        //       int mensu = Pret.Mensualite;
        //        Net = loyer - mensu;
        //    }
        //    return Net;
        //}

        public virtual void afficher()
        {
            Console.WriteLine("Nom du Bien : " + Nom);
            Console.WriteLine("Valeur du Bien : " + Valeur);
            Console.WriteLine("Adresse du Bien : " + Adresse);
            Console.WriteLine("Surface du Bien : " + Surface);
            //benefNet();

            //foreach (Contrat contrat in ListContrat)
            //{
            //   foreach (Locataire locataire in contrat.ListLocataires)
            //    {
            //        Console.WriteLine("===========locataire===========");
            //        Console.WriteLine("la fiche du locataire est : " + locataire.NomLoc + " " + locataire.PrenomLoc + " " + locataire.Age + " " + locataire.Profession);
            //
            //    }
         //   }
        }

        public void afficherTravaux()
        {
            Console.WriteLine("C'est les travaux...");
        }


        public Biens(string nom, int valeur, string adresse, int surface)
        {
            Nom = nom;
            Valeur = valeur;
            Adresse = adresse;
            Surface = surface;

        }


        public Biens()
        {

        }


    }


}
