using GestImmo.Data.DAL;
using GestImmo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Logique d'interaction pour ConsulterBoxForm.xaml
    /// </summary>
    public partial class ConsulterBoxForm : Page
    {
        private Bien bien;
        
        public ConsulterBoxForm(Bien bien)
        {
            InitializeComponent();
            this.bien = bien;

            this.NomBien_TextBox.Text = bien.NomBien;
            this.ValeurBien_TextBox.Text = bien.Valeur.ToString();
            this.AdresseBien_TextBox.Text = bien.Adresse;
            this.SurfaceBien_TextBox.Text = bien.Surface.ToString();      
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

        private void Bouton_Modifier_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier cette box ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                this.bien.NomBien = NomBien_TextBox.Text;
                this.bien.Valeur = int.Parse(ValeurBien_TextBox.Text);
                this.bien.Adresse = AdresseBien_TextBox.Text;
                this.bien.Surface = int.Parse(SurfaceBien_TextBox.Text);
                ctx.SaveChanges();

                MessageBox.Show("La box " + bien.NomBien + " a été modifié !");
            }
        }

        private void Bouton_Supprimer_Bien_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer cette box ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Bien.Remove(this.bien);
                ctx.SaveChanges();

                MessageBox.Show("La box " + bien.NomBien + " a été supprimé !");
            }
        }
    }
}
