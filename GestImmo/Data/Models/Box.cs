using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Box : Biens
    {
        public int BoxId { get; set; }

        public Box(string nom, int valeur, string adresse, int surface)
            :base(nom, valeur, adresse, surface)
        {

        }

        public Box()
        {

        }

        public override void afficher()
        {
            base.afficher();
        }
    }
}
