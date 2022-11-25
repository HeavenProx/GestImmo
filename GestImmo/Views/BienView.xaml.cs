using GestImmo.Models;
using Npgsql;
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
using GestImmo.DAL;
using GestImmo.Views;
using GestImmo.Views.SubViews;

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        GestImmoContext ctx = GestImmoContext.getInstance();
        public BienView()
        {
            InitializeComponent();
            this.ListFrame.Navigate(new ListBienViews());
            this.AjoutFrame.Navigate(new ajoutBienViews());


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();
            GestImmoContext ctx = GestImmoContext.getInstance();


        }

        private void buttonValider_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
