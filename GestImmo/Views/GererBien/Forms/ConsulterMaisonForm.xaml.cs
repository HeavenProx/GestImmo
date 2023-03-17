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

namespace GestImmo.Views.GererBien.Forms
{
    /// <summary>
    /// Logique d'interaction pour ConsulterMaisonForm.xaml
    /// </summary>
    public partial class ConsulterMaisonForm : Page
    {
        private Maison maison;
        public ConsulterMaisonForm(Maison maison)
        {
            InitializeComponent();
            this.maison = maison;

            this.NomBien_TextBox.Text = maison.NomBien;
            this.ValeurBien_TextBox.Text = maison.Valeur.ToString();
            this.AdresseBien_TextBox.Text = maison.Adresse;
            this.SurfaceBien_TextBox.Text = maison.Surface.ToString();
            this.PiecesBien_TextBox.Text = maison.NbPiece.ToString();
            this.ChambresBien_TextBox.Text = maison.NbChambre.ToString();
            this.Cave_TextBox.Text = maison.Cave.ToString();
            this.Parking_TextBox.Text = maison.Parking.ToString();
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

        private void PieceBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ChambreBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CaveBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ParkingBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bouton_Modifier_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier cette maison ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                this.maison.NomBien = NomBien_TextBox.Text;
                this.maison.Valeur = int.Parse(ValeurBien_TextBox.Text);
                this.maison.Adresse = AdresseBien_TextBox.Text;
                this.maison.Surface = int.Parse(SurfaceBien_TextBox.Text);
                this.maison.NbPiece = int.Parse(PiecesBien_TextBox.Text);
                this.maison.NbChambre = int.Parse(ChambresBien_TextBox.Text);
                this.maison.Cave = int.Parse(Cave_TextBox.Text);
                this.maison.Parking = int.Parse(Parking_TextBox.Text);

                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("La maison " + maison.NomBien + " a été modifié !");
            }
        }

        private void Bouton_Supprimer_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer cette maison ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Remove(this.maison);
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("La maison " + maison.NomBien + " a été supprimé !");
            }
        }
    }
}
