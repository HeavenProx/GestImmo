using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Appartement : Habitat
    {
        public int AppartementId { get; set; }
        private int etage;
        private int assenceur;
        private bool chauffCommun;

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Nombres etages : " + Etage);
            Console.WriteLine("Nombres assenceurs : " + Assenceur);
            Console.WriteLine("Chauffage Commun : " + ChauffCommun);
        }

        public Appartement(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambre, int cave, int parking, int etage, int assenceur, bool chauffCommun)
            : base(nom, valeur, adresse, surface, nbPieces, nbChambre, cave, parking)
        {
            Etage = etage;
            Assenceur = assenceur;
            ChauffCommun = chauffCommun;
        }

        public Appartement()
        {

        }

        public int Etage { get => etage; set => etage = value; }
        public int Assenceur { get => assenceur; set => assenceur = value; }
        public bool ChauffCommun { get => chauffCommun; set => chauffCommun = value; }


    }
}
