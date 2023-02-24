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
        private Frame consulterBoxForm;
        private Frame Ajouter_Bien;
        ImmoContext ctx = ImmoContext.getInstance();

        
        public ListBienView(Frame consulterBoxForm)
        {
            InitializeComponent();
            this.updateList();

            this.consulterBoxForm = consulterBoxForm;
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
            //ConsulterBoxForm(unBien.BienId);

            //ConsulterBoxForm consulterBoxForm = new ConsulterBoxForm(this.Ajouter_Bien);
            //this.Ajouter_Bien.Navigate(new ConsulterBoxForm());
        }

        /*private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.Ajouter_Bien.Navigate(new ConsulterBoxForm(this.Ajouter_Bien));
        }*/

        public void chargerViewParId(int id)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            bool place = false;
            Bien bien = ctx.Bien.Find(id);

        }
    }
}
