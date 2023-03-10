using GestImmo.Data.DAL;
using GestImmo.Models;
using GestImmo.Views.GererBien.Forms;
using GestImmo.Views.GererIntervention.Forms;
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

namespace GestImmo.Views.GererIntervention.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListInterventionView.xaml
    /// </summary>
    public partial class ListInterventionView : Page, IObserver
    {
        private Frame Ajouter_Intervention;

        ImmoContext ctx = ImmoContext.getInstance();

        public ListInterventionView(Frame Ajouter_Intervention)
        {
            InitializeComponent();
            this.Ajouter_Intervention = Ajouter_Intervention;
            this.updateList();
        }

        private void updateList()
        {

            ImmoContext ctx = ImmoContext.getInstance();

            this.ListInterventionView_Section.Items.Clear();

            foreach (Intervention intervention in ctx.Intervention)
            {
                this.ListInterventionView_Section.Items.Add(intervention);
            }
        }

        public void update()
        {
            this.updateList();
        }

        private void ListInterventionView_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImmoContext ctx = ImmoContext.getInstance();
            Intervention uneIntervention = (Intervention)(sender as ListBox).SelectedItem;

            ConsulterIntervention consulterIntervention = new ConsulterIntervention(uneIntervention);
            this.Ajouter_Intervention.Navigate(consulterIntervention);
        }
      
    }
}
