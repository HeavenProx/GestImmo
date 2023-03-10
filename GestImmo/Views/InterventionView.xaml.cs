using GestImmo.Views.Forms;
using GestImmo.Views.GererIntervention.Forms;
using GestImmo.Views.GererIntervention.SubViews;
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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour InterventionView.xaml
    /// </summary>
    public partial class InterventionView : Page
    {
        public InterventionView()
        {
            InitializeComponent();
            ListInterventionView listInterventionView = new ListInterventionView(this.Ajouter_Intervention);
            this.Frame_Consulter_Intervention.Navigate(listInterventionView);
            this.Ajouter_Intervention.Navigate(new GererAjouterInterventionForm());
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            this.Frame_Consulter_Intervention.Navigate(new ListInterventionView(this.Ajouter_Intervention));
        }
    }
}
