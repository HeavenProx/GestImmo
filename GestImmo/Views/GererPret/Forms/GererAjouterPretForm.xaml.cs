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

namespace GestImmo.Views.GererPret.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererAjouterPretForm.xaml
    /// </summary>
    public partial class GererAjouterPretForm : Page
    {
        public GererAjouterPretForm()
        {
            InitializeComponent();

            this.Frame_Ajouter_Pret.Navigate(new GererPretForm());
        }

        private IObserver obs;
        public GererAjouterPretForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;
        }
    }
}