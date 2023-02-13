using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestImmo.Views.GererPrestataire.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererPrestataireForm.xaml
    /// </summary>
    public partial class GererPrestataireForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GererPrestataireForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        private void RaisonSocialePrestataire_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NomPrestataire_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PrenomPrestataire_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TelephonePrestataire_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AdressePrestataire_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bouton_Ajouter_Prestataire_Click(object sender, RoutedEventArgs e)
        {
            if (RaisonSocialePrestataire_TextBox.Text != "" && NomPrestataire_TextBox.Text != "" && PrenomPrestataire_TextBox.Text != "" && TelephonePrestataire_TextBox.Text != "" && AdressePrestataire_TextBox.Text != "")
            {
                string raisonSociale = RaisonSocialePrestataire_TextBox.Text;
                string nom = NomPrestataire_TextBox.Text;
                string prenom =PrenomPrestataire_TextBox.Text;
                string telephone = TelephonePrestataire_TextBox.Text;
                string adresse = AdressePrestataire_TextBox.Text;

                Prestataire unPrestataire = new Prestataire(nom, prenom, raisonSociale, telephone, adresse);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Prestataire.Add(unPrestataire);
                ctx.SaveChanges();

                this.notifyObservers();

                MessageBox.Show("Prestataire ajouté avec succès!");
            }
            else
            {
                MessageBox.Show("Un ou plusieurs des champs n'a pas été correctement rempli.");
            }
        }

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
