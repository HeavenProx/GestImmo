using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Contrat
    {
        private int loyer;
        private string? dateDebut;
        private string? dateFin;
        private List<Locataire> listLocataires = new List<Locataire>();
        private Biens bien;


        public Contrat(int loyer, string dateDebut, string dateFin, List<Locataire> listLocataires, Biens bien)
        {
            Loyer = loyer;
            DateDebut = dateDebut;
            DateFin = dateFin;
            ListLocataires = listLocataires;
            this.Bien = bien;
        }

        public Contrat()
        {

        }

        public int ContratId { get; set; }
        public int Loyer { get => loyer; set => loyer = value; }
        public string? DateDebut { get => dateDebut; set => dateDebut = value; }
        public string? DateFin { get => dateFin; set => dateFin = value; }
        internal List<Locataire> ListLocataires { get => listLocataires; set => listLocataires = value; }
        public Biens Bien { get => bien; set => bien = value; }
    }

}
