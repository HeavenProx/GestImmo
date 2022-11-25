using GestImmo.Views;
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

namespace GestImmo
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
        }

        private void accueilButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new HomeView());
        }

        private void bienButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new BienView());
        }

        private void prestatairesButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PrestataireView());
        }

        private void pretButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretView());
        }
    }
}
