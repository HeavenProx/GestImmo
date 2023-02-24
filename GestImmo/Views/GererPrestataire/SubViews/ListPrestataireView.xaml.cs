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

namespace GestImmo.Views.GererPrestataire.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListPrestataireView.xaml
    /// </summary>
    public partial class ListPrestataireView : Page, IObserver
    {
        ImmoContext ctx = ImmoContext.getInstance();

        public ListPrestataireView()
        {
            InitializeComponent();
            this.updateList();
        }

        private void updateList()
        {

            ImmoContext ctx = ImmoContext.getInstance();

            this.ListPrestataireView_Section.Items.Clear();

            foreach (Prestataire prestataire in ctx.Prestataire)
            {
                this.ListPrestataireView_Section.Items.Add(prestataire);
            }
        }

        public void update()
        {
            this.updateList();
        }
    }
}
