using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Maison : Habitat
    {
        public int MaisonId { get; set; }
        public Maison(string nom, int valeur, string adresse, int surface, int nbPieces, int nbChambre, int cave, int parking)
            : base(nom, valeur, adresse, surface, nbPieces, nbChambre, cave, parking)
        {

        }

        public Maison()
        {

        }

        public string affichage()
        {
            return Adresse;
        }
    }
}
