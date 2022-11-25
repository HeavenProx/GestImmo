using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Data.Models
{
    internal class MesBiens
    {
        private string Nom;
        private int valeur;
        private string adresse;
        private int surface;



        public MesBiens(string nom, int valeur, string adresse, int surface)
        {
            Nom = nom;
            Valeur = valeur;
            Adresse = adresse;
            Surface = surface;

        }

        public string Nom1 { get => Nom; set => Nom = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Surface { get => surface; set => surface = value; }
    }
}
