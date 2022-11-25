using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Intervention
    {
        private int date;
        private int montantTTC;
        private string? information;
        private List<Prestataire> ListPresta = new List<Prestataire>();
        private Biens unBien;



        public Intervention(int date, string adresse, int montantTTC, int date1, string information, List<Prestataire> ListPresta, Biens unBien)
        {
            Date = date;
            MontantTTC = montantTTC;
            Information = information;
            ListPresta1 = ListPresta;
            UnBien = unBien;
        }

        public Intervention(int valeur, string adresse, int surface, int date, int montantTTC, string information, List<Prestataire> listPresta1)
        {
            this.date = date;
            this.montantTTC = montantTTC;
            this.information = information;
            ListPresta1 = listPresta1;
        }

        public Intervention()
        {

        }

        public int InterventionId { get; set; }
        public int Date { get => date; set => date = value; }
        public int MontantTTC { get => montantTTC; set => montantTTC = value; }
        public string? Information { get => information; set => information = value; }
        public List<Prestataire> ListPresta1 { get => ListPresta; set => ListPresta = value; }

        public Biens UnBien { get => unBien; set => unBien = value; }
    }
}
