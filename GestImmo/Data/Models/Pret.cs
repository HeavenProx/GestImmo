using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Pret
    {
        private int apport;
        private int mensualite;
        private int duree;
        private DateTime debutPret;
        private Biens unBien;


        public int coutRestant()
        {
            int prixBiens = apport + mensualite * duree;

            float dateFloat = (float)(DateTime.Now.Subtract(debutPret).Days / (365.25 / 12));
            int dateInt = (int)dateFloat + 1;

            int dejaRembourse = mensualite * dateInt;
            int capital = prixBiens - dejaRembourse;
            return capital;

        }

        public Pret(int apport, int mensualite, int duree, DateTime debutPret, Biens unBien)
        {
            Apport = apport;
            Mensualite = mensualite;
            Duree = duree;
            DebutPret = debutPret;
            UnBien = unBien;
        }

        public Pret()
        {

        }

        public int PretId { get; set; }
        public int Apport { get => apport; set => apport = value; }
        public int Mensualite { get => mensualite; set => mensualite = value; }
        public int Duree { get => duree; set => duree = value; }
        public DateTime DebutPret { get => debutPret; set => debutPret = value; }
        public Biens UnBien { get => unBien; set => unBien = value; }
    }

}
