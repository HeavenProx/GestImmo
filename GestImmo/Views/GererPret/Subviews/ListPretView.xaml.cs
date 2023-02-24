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

namespace GestImmo.Views.GererPret.Subviews
{
    /// <summary>
    /// Logique d'interaction pour ListPretView.xaml
    /// </summary>
    public partial class ListPretView : Page, IObserver
    {
        ImmoContext ctx = ImmoContext.getInstance();

        public ListPretView()
        {
            InitializeComponent();
            this.updateList();
        }

        private void updateList()
        {

            ImmoContext ctx = ImmoContext.getInstance();

            this.ListPretView_Section.Items.Clear();

            foreach (Pret pret in ctx.Pret)
            {
                this.ListPretView_Section.Items.Add(pret.Montant);
            }
        }

        public void update()
        {
            this.updateList();
        }
    }
}