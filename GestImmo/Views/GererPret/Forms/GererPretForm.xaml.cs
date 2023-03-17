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
                BienPret_ComboBox.Items.Add(bien.NomBien);
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
        private void MontantPret_TextBox_TextChanged(object sender, TextChangedEventArgs e)
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
            if (BienPret_ComboBox.Text != "" && ApportPret_TextBox.Text != "" && MensualitePret_TextBox.Text != "" && DureePret_TextBox.Text != "")
            {

                string nomBien = BienPret_ComboBox.Text;
                int montant = int.Parse(MontantPret_TextBox.Text);
                int mensualite = int.Parse(MensualitePret_TextBox.Text);
                int apport = int.Parse(ApportPret_TextBox.Text);
                string duree = DureePret_TextBox.Text;
                int tauxInteret = int.Parse(DureePret_TextBox.Text);

                Pret unPret = new Pret(nomBien, montant, mensualite, apport, duree, tauxInteret);
                ImmoContext ctx = ImmoContext.getInstance();
                ctx.Pret.Add(unPret);
                ctx.SaveChanges();

                this.notifyObservers();

                MessageBox.Show("Intervention ajouté avec succès!");
            }
            else
            {
                MessageBox.Show("Un ou plusieurs des champs n'a pas été correctement rempli.");
            }
            
        }

        
    }
}
