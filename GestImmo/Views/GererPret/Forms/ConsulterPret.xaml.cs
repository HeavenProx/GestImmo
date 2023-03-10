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

namespace GestImmo.Views.GererPret.Forms
{
    /// <summary>
    /// Logique d'interaction pour ConsulterPret.xaml
    /// </summary>
    public partial class ConsulterPret : Page
    {
        private Pret pret;
        public ConsulterPret(Pret pret)
        {
            InitializeComponent();
            this.pret = pret;
            this.NomBien_TextBox.Text = pret.NomBien.ToString();
            this.ApportPret_TextBox.Text = pret.Apport.ToString();
            this.MensualitePret_TextBox.Text = pret.Mensualite.ToString();
            this.DureePret_TextBox.Text = pret.Duree;


        }

        private void NomBien_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ApportPret_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MensualitePret_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DureePret_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bouton_Modifier_Pret_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier ce prêt ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                //ctx.Pret.
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("Le prêt du batiment " + pret.NomBien + " a été modifié !");
            }
        }

        private void Bouton_Supprimer_Pret_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer ce prêt ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Pret.Remove(this.pret);
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("Le prêt du batiment " + pret.NomBien + " a été supprimé !");
            }

        }
    }
}
