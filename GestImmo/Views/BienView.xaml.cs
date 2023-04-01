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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        private GererBienForm gererBienForm;

        public BienView()
        {
            InitializeComponent();
            ListBienView listBienView = new ListBienView(this.Ajouter_Bien);
            this.Frame_Consulter_Bien.Navigate(listBienView);

            this.Ajouter_Bien.Navigate(new GererBienForm(listBienView));
        }
        

        private void Ajouter_Bien_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
