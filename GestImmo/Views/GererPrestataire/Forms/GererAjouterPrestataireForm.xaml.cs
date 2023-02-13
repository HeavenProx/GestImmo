using GestImmo.Views.Forms;
using GestImmo.Views.GererIntervention.Forms;
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

namespace GestImmo.Views.GererPrestataire.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererAjouterPrestataireForm.xaml
    /// </summary>
    public partial class GererAjouterPrestataireForm : Page
    {
        public GererAjouterPrestataireForm()
        {
            InitializeComponent();
            this.Frame_Ajouter_Prestataire.Navigate(new GererPrestataireForm());
        }

        private IObserver obs;
        public GererAjouterPrestataireForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }

        
    }
}
