using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Models
{
    public class Prestataire
    {
        private string? raisonSociale;
        private string? nom;
        private string? prenom;
        private string? telephone;
        private string? adresseEntreprise;
        private List<Intervention>? interventionList = new List<Intervention>();


        public Prestataire(string raisonSociale, string nom, string prenom, string telephone, string adresseEntreprise,  int prestataireId,  List<Intervention> interventionList)
        {
            RaisonSociale = raisonSociale;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            AdresseEntreprise = adresseEntreprise;
            InterventionList = interventionList;
            PrestataireId = prestataireId;

        }

        public Prestataire()
        {

        }


        public int PrestataireId { get; set; }
        public string? RaisonSociale { get => raisonSociale; set => raisonSociale = value; }
        public string? Nom { get => nom; set => nom = value; }
        public string? Prenom { get => prenom; set => prenom = value; }
        public string? Telephone { get => telephone; set => telephone = value; }
        public string? AdresseEntreprise { get => adresseEntreprise; set => adresseEntreprise = value; }
        public List<Intervention> InterventionList { get => interventionList; set => interventionList = value; }
    }
}
