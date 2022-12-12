using GestImmo.DAL;
using GestImmo.Models;
using GestImmo.Views.Interface;
using Serilog;
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
    public partial class GereBienForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }
        public GereBienForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }


        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            Log.Logger.Verbose("Entrer dans la fonction de création de box");
            string nom = this.inputNom.Text;
            int valeur = int.Parse(this.inputValeur.Text);
            string adresse = this.inputAdresse.Text;
            int surface = int.Parse(this.inputSurface.Text);

            Box box = new Box(nom, valeur, adresse, surface);
            GestImmoContext ctx = GestImmoContext.getInstance();
            ctx.Bien.Add(box);
            ctx.SaveChanges();

            this.notifyObservers();

            Log.Logger.Information("Le box " + nom + " a été créé !");
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
