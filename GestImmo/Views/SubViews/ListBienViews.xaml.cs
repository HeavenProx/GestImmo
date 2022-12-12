using GestImmo.DAL;
using GestImmo.Models;
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

namespace GestImmo
{
    /// <summary>
    /// Logique d'interaction pour ListBienViews.xaml
    /// </summary>
    public partial class ListBienViews : Page, IObserver
    {
        public ListBienViews()
        {
            InitializeComponent();
            GestImmoContext ctx = GestImmoContext.getInstance();
            
            foreach (Biens bien in ctx.Bien)
            {
                this.tableauBien.Items.Add(bien.Nom);
            }

        }

        private void refreshList()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            this.tableauBien.Items.Clear();
            foreach (Biens bien in ctx.Bien)
            {
                this.tableauBien.Items.Add(bien.Nom);
            }
        }

        public void update()
        {
            this.refreshList();
        }
    }
}
