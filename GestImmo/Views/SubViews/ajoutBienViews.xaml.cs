using GestImmo.DAL;
using GestImmo.Models;
using GestImmo.Views.Forms;
using GestImmo.Views.Interface;
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
        private IObserver obs;

        public ajoutBienViews(IObserver observer)
        {
            this.obs = observer;
            InitializeComponent();
        }

        private void inputType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(inputType.SelectedIndex == 0)
            {
                GereBienForm gereBienForm = new GereBienForm();
                gereBienForm.Observers.Add(this.obs);
                this.choixFrame.Navigate(gereBienForm);
            }
            else if (inputType.SelectedIndex == 1)
            {
                GererMaisonForm gererMaisonForm = new GererMaisonForm();
                gererMaisonForm.Observers.Add(this.obs);
                this.choixFrame.Navigate(gererMaisonForm);
            }
            else if (inputType.SelectedIndex == 2)
            {
                GererAppartementForm gererAppartementForm = new GererAppartementForm();
                gererAppartementForm.Observers.Add(this.obs);
                this.choixFrame.Navigate(gererAppartementForm);
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
