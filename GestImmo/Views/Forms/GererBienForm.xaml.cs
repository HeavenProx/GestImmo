using GestImmo.DAL;
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

namespace GestImmo
{
    /// <summary>
    /// Logique d'interaction pour GereBienForm.xaml
    /// </summary>
    public partial class GereBienForm : Page
    {
        public GereBienForm()
        {
            InitializeComponent();
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

        private void buttonValider_Click(object sender, RoutedEventArgs e)
        {
            string nom = this.inputNom.Text;
            int valeur = int.Parse(this.inputValeur.Text);
            string adresse = this.inputAdresse.Text;
            int surface = int.Parse(this.inputSurface.Text);

            Box box = new Box(nom, valeur, adresse, surface);
            GestImmoContext ctx = GestImmoContext.getInstance();
            ctx.Bien.Add(box);
            ctx.SaveChanges();
        }
    }
}
