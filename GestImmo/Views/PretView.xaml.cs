using GestImmo.Views.GererPret.Forms;
using GestImmo.Views.GererPret.Subviews;
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
    /// Logique d'interaction pour PretView.xaml
    /// </summary>
    public partial class PretView : Page
    {
        public PretView()
        {
            InitializeComponent();
            ListPretView listPretView = new ListPretView(this.Ajouter_Pret);
            this.Frame_Consulter_Pret.Navigate(listPretView);
            this.Ajouter_Pret.Navigate(new GererAjouterPretForm(listPretView));
        }
        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.Frame_Consulter_Pret.Navigate(new ListPretView(this.Ajouter_Pret));
        }
    }
}
