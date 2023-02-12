using GestImmo.Views.Forms;
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

namespace GestImmo.Views.GererIntervention.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererAjouterInterventionForm.xaml
    /// </summary>
    public partial class GererAjouterInterventionForm : Page
    {
        public GererAjouterInterventionForm()
        {
            InitializeComponent();
            this.Frame_Ajouter_Intervention.Navigate(new GererInterventionForm());
        }

        private IObserver obs;
        public GererAjouterInterventionForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }
    }
}
