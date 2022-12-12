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
using GestImmo.Models;
using GestImmo.Views;
using GestImmo.Views.Interface;
using GestImmo.Views.SubViews;
using Serilog;

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererMaisonForm.xaml
    /// </summary>
    public partial class GererMaisonForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GererMaisonForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Log.Logger.Verbose("Entrer dans la fonction de création de maison");
            string nom = this.inputNom.Text;
            int valeur = int.Parse(this.inputValeur.Text);
            string adresse = this.inputAdresse.Text;
            int surface = int.Parse(this.inputSurface.Text);
            int nbPiece = int.Parse(this.inputNbPiece.Text);
            int nbChambre = int.Parse(this.inputNbChambre.Text);
            int nbCave = int.Parse(this.inputCave.Text);
            int nbParking = int.Parse(this.inputParking.Text);


            Maison maison = new Maison(nom, valeur, adresse, surface, nbPiece, nbChambre, nbCave, nbParking);
            GestImmoContext ctx = GestImmoContext.getInstance();
            ctx.Bien.Add(maison);
            ctx.SaveChanges();

            this.notifyObservers();

            Log.Logger.Information("La maison " + nom + " a été créé !");
        }

        public void notifyObservers()
        {

            foreach (IObserver obs in this.Observers)
            {
                obs.update();
            }
        }
    }
}
