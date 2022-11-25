using GestImmo.DAL;
using GestImmo.Models;
using GestImmo.Views.Forms;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ajoutBienViews.xaml
    /// </summary>
    public partial class ajoutBienViews : Page
    {

        public ajoutBienViews()
        {
            InitializeComponent();
        }

        private void inputType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(inputType.SelectedIndex == 0)
            {
                this.choixFrame.Navigate(new GereBienForm());
            }
            else if (inputType.SelectedIndex == 1)
            {
                this.choixFrame.Navigate(new GererMaisonForm());
            }
            else if (inputType.SelectedIndex == 2)
            {
                this.choixFrame.Navigate(new GererAppartementForm());
            }
        }


















        public interface IObservable
        {
         //   List<IObserver> Observers { get; set; }

         //   void notifyObservers()
         //  {
         //       foreach(IObserver obs in Observers)
         //       {
         //           obs.update();
         //      }
         //   }
        }


        void notifyObservers()
        {
         //   foreach(IObserver obs in Observers)
         //   {
         //       obs.update();
         //   }
        }
        
    }
}
