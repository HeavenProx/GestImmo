using GestImmo.Data.DAL;
using GestImmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView()
        {
            InitializeComponent();
            this.updateList(); 
        }

        private void updateList()
        {
            ImmoContext ctx = ImmoContext.getInstance();

            int nbBien = 0;
            foreach (Bien bien in ctx.Bien)
            { nbBien++; }
            if(nbBien <= 2){ valeurNbBien.Content = nbBien + " bien"; }
            else{ valeurNbBien.Content = nbBien + " biens au total"; }

            int nbPret = 0;
            foreach(Pret pret in ctx.Pret)
            { nbPret++; }
            if (nbBien <= 2) { valeurNbPret.Content = nbPret + " prêt"; }
            else { valeurNbPret.Content = nbPret + " prêts au total"; }

            int beneficeMensuel = 0;
            valeurBenefMensuelCum.Content = beneficeMensuel + " €";

            int detteMensuel = 0;
            foreach (Pret pret in ctx.Pret)
            { 
                detteMensuel = detteMensuel + pret.Mensualite;
            }
            valeurDetteMensuelCum.Content = detteMensuel + " €";

            int masseDette = 0;
            int masseApport = 0;
            int masseTotalDette;
            foreach (Pret pret in ctx.Pret)
            { 
                masseDette = masseDette + pret.Montant;
                masseApport = masseApport + pret.Apport;
            }
            masseTotalDette = masseDette - masseApport;
            valeurMasseTotaleDette.Content = masseTotalDette + " €";

            int loyerMensuelCumule = 0;
            valeurLoyerMensuelCumule.Content = loyerMensuelCumule + " €";
        }
    }
}
