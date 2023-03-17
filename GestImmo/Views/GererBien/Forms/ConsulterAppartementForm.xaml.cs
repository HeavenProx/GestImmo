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
using static System.Net.Mime.MediaTypeNames;

namespace GestImmo.Views.GererBien.Forms
{
    /// <summary>
    /// Logique d'interaction pour ConsulterAppartementForm.xaml
    /// </summary>
    public partial class ConsulterAppartementForm : Page
    {
        private Appartement appartement;
        public ConsulterAppartementForm(Appartement appartement)
        {
            InitializeComponent();
            this.appartement = appartement;

            this.NomBien_TextBox.Text = appartement.NomBien;
            this.ValeurBien_TextBox.Text = appartement.Valeur.ToString();
            this.AdresseBien_TextBox.Text = appartement.Adresse;
            this.SurfaceBien_TextBox.Text = appartement.Surface.ToString();
            this.PiecesBien_TextBox.Text = appartement.NbPiece.ToString();
            this.ChambresBien_TextBox.Text = appartement.NbChambre.ToString();
            this.Etage_Textbox.Text = appartement.Etage.ToString();
            this.Ascenseur_TextBox.Text = appartement.Ascenseur.ToString();
            this.Chauffage_TextBox.Text = appartement.Chauffage.ToString();
            this.Cave_TextBox.Text = appartement.Cave.ToString();
            this.Parking_TextBox.Text = appartement.Parking.ToString();      
        }

        private void NomBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ValeurBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AdresseBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SurfaceBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PiecesBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChambresBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Etage_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Ascenseur_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Chauffage_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cave_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Parking_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bouton_Modifier_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier cet appartement ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                this.appartement.NomBien = NomBien_TextBox.Text;
                this.appartement.Valeur = int.Parse(ValeurBien_TextBox.Text);
                this.appartement.Adresse = AdresseBien_TextBox.Text;
                this.appartement.Surface = int.Parse(SurfaceBien_TextBox.Text);
                this.appartement.NbPiece = int.Parse(PiecesBien_TextBox.Text);
                this.appartement.NbChambre = int.Parse(ChambresBien_TextBox.Text);
                this.appartement.Etage = int.Parse(Etage_Textbox.Text);
                this.appartement.Ascenseur = Ascenseur_TextBox.Text;
                this.appartement.Chauffage = Chauffage_TextBox.Text;
                this.appartement.Cave = int.Parse(Cave_TextBox.Text);
                this.appartement.Parking = int.Parse(Parking_TextBox.Text);

                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("L'appartement " + appartement.NomBien + " a été modifié !");
            }
        }

        private void Bouton_Supprimer_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer cet appartement ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Remove(this.appartement);
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("L'appartement " + appartement.NomBien + " a été supprimé !");
            }
        }
    }
}
