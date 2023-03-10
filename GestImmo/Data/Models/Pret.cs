using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Models
{
    public class Pret
    {
        public int PretId { get; set; }
        private string nomBien;
        private int montant;
        private int mensualite;
        private int apport;
        private string duree;
        private int tauxInteret;

        public Pret(string nomBien, int montant, int mensualite, int apport, string duree, int tauxInteret)
        {
            this.nomBien = nomBien;
            this.montant = montant;
            this.apport = apport;
            this.duree = duree;
            this.tauxInteret = tauxInteret;
        }

        public int Montant { get => montant; set => montant = value; }
        public int Apport { get => apport; set => apport = value; }
        public string Duree { get => duree; set => duree = value; }
        public int TauxInteret { get => tauxInteret; set => tauxInteret = value; }
        public int Mensualite { get => mensualite; set => mensualite = value; }
        public string NomBien { get => nomBien; set => nomBien = value; }
    }
}
