using GestImmo.Data.DAL;
using GestImmo.Models;
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
    /// Logique d'interaction pour ConsulterPrestataire.xaml
    /// </summary>
    public partial class ConsulterPrestataire : Page
    {
        private Prestataire prestataire;
        public ConsulterPrestataire(Prestataire prestataire)
        {
            InitializeComponent();
            this.prestataire = prestataire;

            this.RaisonSocialePrestataire_TextBox.Text = prestataire.RaisonSociale;
            this.NomPrestataire_TextBox.Text = prestataire.Nom;
            this.PrenomPrestataire_TextBox.Text = prestataire.Prenom;
            this.TelephonePrestataire_TextBox.Text = prestataire.Telephone;
            this.AdressePrestataire_TextBox.Text = prestataire.Adresse;
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

        private void Bouton_Modifier_Prestataire_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier ce prestataire ?",
               "Oui",
               MessageBoxButton.YesNo,
               MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                //ctx.Prestataire.
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("Le prestataire " + prestataire.Nom + " " + prestataire.Prenom + " a été modifié !");
            }
        }

        private void Bouton_Supprimer_Prestataire_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer ce prestataire ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Prestataire.Remove(this.prestataire);
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("Le prestataire " + prestataire.Nom + " " + prestataire.Prenom + " a été supprimé !");
            }
        }
    }
}
