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

namespace GestImmo.Views.GererIntervention.Forms
{
    /// <summary>
    /// Logique d'interaction pour ConsulterIntervention.xaml
    /// </summary>
    public partial class ConsulterIntervention : Page
    {
        private Intervention intervention;
        public ConsulterIntervention(Intervention intervention)
        {
            InitializeComponent();
            this.intervention = intervention;

            this.BienIntervention_ComboBox.Text = intervention.InterventionId.ToString();
            //this.PrestataireIntervention_ComboBox = 
            this.DateIntervention_TextBox.Text = intervention.DateIntervention;
            this.MontantTTCIntervention_TextBox.Text = intervention.MontantTTC.ToString();
            this.InformationIntervention_TextBox.Text = intervention.Information.ToString();
        }

        private void TypeBien_ComboBox_SelectionChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void MontantTTCIntervention_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void InformationIntervention_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bouton_Modifier_Intervention_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de modifier cette intervention ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                //ctx.Intervention.
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("L'intervention du " + intervention.DateIntervention + " ayant couté " + intervention.MontantTTC + " par  a été modifiée !");
            }
        }

        private void Bouton_Supprimer_Intervention_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Etes vous sûr de supprimer cette intervention ?",
                "Oui",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Intervention.Remove(this.intervention);
                ctx.SaveChanges();
                //this.notifyObservers();

                MessageBox.Show("L'intervention du " + intervention.DateIntervention + " ayant couté " + intervention.MontantTTC + " par  a été supprimé !");
            }
        }

    }  
}
