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
    /// Logique d'interaction pour GererPretForm.xaml
    /// </summary>
    public partial class GererPretForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }

        public GererPretForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();

            ImmoContext ctx = ImmoContext.getInstance();
            foreach (Bien bien in ctx.Bien)
            {
                BienPret_ComboBox.Items.Add(bien.NomBien + " - id : " + bien.BienId);
            }
        }

        private void BienPret_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }

        private void Bouton_Ajouter_Pret_Click(object sender, RoutedEventArgs e)
        {
            /*if (DateIntervention_TextBox.Text != "" && MontantTTCIntervention_TextBox.Text != "" && InformationIntervention_TextBox.Text != "")
            {
                string nomBien = BienIntervention_ComboBox.Items.ToString();
                string date = DateIntervention_TextBox.Text;
                int montantttc = int.Parse(MontantTTCIntervention_TextBox.Text);
                string information = InformationIntervention_TextBox.Text;

                Intervention uneIntervention = new Intervention(date, montantttc, information, null);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Intervention.Add(uneIntervention);
                ctx.SaveChanges();*/

                this.notifyObservers();

                /*MessageBox.Show("Intervention ajouté avec succès!");
            }
            else
            {
                MessageBox.Show("Un ou plusieurs des champs n'a pas été correctement rempli.");
            }*/

        }


    }
}
