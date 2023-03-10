using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views.GererBien.Forms;
using GestImmo.Views.GererPrestataire.Forms;
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

namespace GestImmo.Views.GererPrestataire.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListPrestataireView.xaml
    /// </summary>
    public partial class ListPrestataireView : Page, IObserver
    {
        private Frame Ajouter_Prestataire;

        ImmoContext ctx = ImmoContext.getInstance();

        public ListPrestataireView(Frame Ajouter_Prestataire)
        {
            InitializeComponent();
            this.Ajouter_Prestataire = Ajouter_Prestataire;
            this.updateList();
        }

        private void updateList()
        {

            ImmoContext ctx = ImmoContext.getInstance();

            this.ListPrestataireView_Section.Items.Clear();

            foreach (Prestataire prestataire in ctx.Prestataire)
            {
                this.ListPrestataireView_Section.Items.Add(prestataire); //.Nom
                /*this.ListPrestataireView_Section.Items.Add(prestataire.Prenom);
                this.ListPrestataireView_Section.Items.Add(prestataire.RaisonSociale);*/
            }
        }

        public void update()
        {
            this.updateList();
        }

        private void ListPrestataireView_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            Prestataire unPrestataire = (Prestataire)(sender as ListBox).SelectedItem;

            ConsulterPrestataire consulterPrestataire = new ConsulterPrestataire(unPrestataire);
            this.Ajouter_Prestataire.Navigate(consulterPrestataire);
        }
    }
}
