using GestImmo.Data.DAL;
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

namespace GestImmo.Views.GererIntervention.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListInterventionView.xaml
    /// </summary>
    public partial class ListInterventionView : Page, IObserver
    {
        ImmoContext ctx = ImmoContext.getInstance();

        public ListInterventionView()
        {
            InitializeComponent();
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
    }
}
