using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views.Forms;
using GestImmo.Views.GererBien.Forms;
using GestImmo.Views.SubViews;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page, IObserver
    {
        //private Frame consulterBoxForm;
        public Frame Ajouter_Bien;

        
        public ListBienView(Frame Ajouter_Bien)
        {
            InitializeComponent();
            this.Ajouter_Bien = Ajouter_Bien;
            this.updateList();
        }

        private void updateList()
        {
            
            ImmoContext ctx = ImmoContext.getInstance();

            this.ListBienView_Section.Items.Clear();

            foreach (Bien bien in ctx.Bien)
            {
                    this.ListBienView_Section.Items.Add(bien);
            }
        }

        public void update()
        {
            this.updateList();
        }

        private void ListBienView_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            Bien unBien = (Bien)(sender as ListBox).SelectedItem;

            if (unBien != null)
            {
                if (unBien is Box)
                {
                    ConsulterBoxForm consulterBoxForm = new ConsulterBoxForm(unBien);
                    this.Ajouter_Bien.Navigate(consulterBoxForm);
                }
                else if (unBien is Maison)
                {
                    Maison uneMaison = (Maison)(sender as ListBox).SelectedItem;
                    ConsulterMaisonForm consulterMaisonForm = new ConsulterMaisonForm(uneMaison);
                    this.Ajouter_Bien.Navigate(consulterMaisonForm);
                }
                else if (unBien is Appartement)
                {
                    Appartement unAppartement = (Appartement)(sender as ListBox).SelectedItem;
                    ConsulterAppartementForm consulterAppartementForm = new ConsulterAppartementForm(unAppartement);
                    this.Ajouter_Bien.Navigate(consulterAppartementForm);
                }
            }
        }

        /*public void chargerViewParId(int id)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            bool place = false;
            Bien bien = ctx.Bien.Find(id);
        }*/
    }
}
