using GestImmo.Views.GererIntervention.Forms;
using GestImmo.Views.GererIntervention.SubViews;
using GestImmo.Views.GererPrestataire.Forms;
using GestImmo.Views.GererPrestataire.SubViews;
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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour PrestataireView.xaml
    /// </summary>
    public partial class PrestataireView : Page
    {
        public PrestataireView()
        {
            InitializeComponent();
            ListPrestataireView listPrestataireView = new ListPrestataireView(this.Ajouter_Prestataire);
            this.Frame_Consulter_Prestataire.Navigate(listPrestataireView);
            this.Ajouter_Prestataire.Navigate(new GererAjouterPrestataireForm());
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.Frame_Consulter_Prestataire.Navigate(new ListPrestataireView(this.Ajouter_Prestataire));
        }
    }
}
