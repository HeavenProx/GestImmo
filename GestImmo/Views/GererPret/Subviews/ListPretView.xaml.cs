using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views.GererBien.Forms;
using GestImmo.Views.GererPret.Forms;
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

namespace GestImmo.Views.GererPret.Subviews
{
    /// <summary>
    /// Logique d'interaction pour ListPretView.xaml
    /// </summary>
    public partial class ListPretView : Page, IObserver
    {

        public Frame Ajouter_Pret;

        ImmoContext ctx = ImmoContext.getInstance();

        public ListPretView(Frame Ajouter_Pret)
        {
            InitializeComponent();
            this.Ajouter_Pret = Ajouter_Pret;
            this.updateList();
        }

        private void updateList()
        {

            ImmoContext ctx = ImmoContext.getInstance();

            this.ListPretView_Section.Items.Clear();

            foreach (Pret pret in ctx.Pret)
            {
                this.ListPretView_Section.Items.Add(pret);
            }
        }

        public void update()
        {
            this.updateList();
        }

        private void ListPretView_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            Pret unPret = (Pret)(sender as ListBox).SelectedItem;

            ConsulterPret consulterPret = new ConsulterPret(unPret);
            this.Ajouter_Pret.Navigate(consulterPret);
        }
    }
}