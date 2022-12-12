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
    /// Logique d'interaction pour GererAppartementForm.xaml
    /// </summary>
    public partial class GererAppartementForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GererAppartementForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        private void verifChauff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Log.Logger.Verbose("Entrer dans la fonction de création d'appartement");
            string nom = this.inputNom.Text;
            int valeur = int.Parse(this.inputValeur.Text);
            string adresse = this.inputAdresse.Text;
            int surface = int.Parse(this.inputSurface.Text);
            int nbPiece = int.Parse(this.inputNbPiece.Text);
            int nbChambre = int.Parse(this.inputNbChambre.Text);
            int nbCave = int.Parse(this.inputCave.Text);
            int nbParking = int.Parse(this.inputParking.Text);
            int nbEtage = int.Parse(this.inputEtage.Text);
            int nbAscenceur = int.Parse(this.inputAscenceur.Text);
            bool nbChauffCommun = false;
            if (verifChauff.SelectedIndex == 0)
            {
                nbChauffCommun = true;
            }
            if (verifChauff.SelectedIndex == 1)
            {
                nbChauffCommun = false;
            }

            Appartement appartement = new Appartement(nom, valeur, adresse, surface, nbPiece, nbChambre, nbCave, nbParking, nbEtage, nbAscenceur, nbChauffCommun);
            GestImmoContext ctx = GestImmoContext.getInstance();
            ctx.Bien.Add(appartement);
            ctx.SaveChanges();

            this.notifyObservers();

            Log.Logger.Information("L'appartement " + nom + " a été créé !");
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
