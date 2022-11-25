using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Habitat : Biens
    {
        private int nbPieces;
        private int nbChambre;
        private int cave;
        private int parking;

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Nombre pieces : " + NbPieces);
            Console.WriteLine("Nombre Chambre : " + NbChambre);
            Console.WriteLine("Nombre Cave : " + Cave);
            Console.WriteLine("Nombre Parking : " + Parking);

        }

        public Habitat(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambre, int cave, int parking)
            : base(nom, valeur, adresse, surface)
        {
            NbPieces = nbPieces;
            NbChambre = nbChambre;
            Cave = cave;
            Parking = parking;
        }

        public Habitat()
        {

        }

        public int HabitatId { get; set; }
        public int NbPieces { get => nbPieces; set => nbPieces = value; }
        public int NbChambre { get => nbChambre; set => nbChambre = value; }
        public int Cave { get => cave; set => cave = value; }
        public int Parking { get => parking; set => parking = value; }
    }

}
