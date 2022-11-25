using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Locataire
    {
        private string? nomLoc;
        private string? prenomLoc;
        private int age;
        private string? profession;
        private List<Contrat> listContrat = new List<Contrat>();

        public Locataire(string nomLoc, string prenomLoc, int age, string profession, List<Contrat> listContrat)
        {
            this.nomLoc = nomLoc;
            this.prenomLoc = prenomLoc;
            this.age = age;
            this.profession = profession;
            this.listContrat = listContrat;
        }

        public Locataire()
        {

        }

        public int LocataireId { get; set; }
        public string? NomLoc { get => nomLoc; set => nomLoc = value; }
        public string? PrenomLoc { get => prenomLoc; set => prenomLoc = value; }
        public int Age { get => age; set => age = value; }
        public string? Profession { get => profession; set => profession = value; }
        internal List<Contrat> ListContrat { get => listContrat; set => listContrat = value; }
    }
}
