using GestImmo.Views;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Content = new NavigationView();

            string log = "[{Timestamp:dd/MM/yyyy}] : {Message:lj} {NewLine}{Exception}";
            Log.Logger = new LoggerConfiguration()             
                .WriteTo.File("../../../../logs.txt", outputTemplate: log, rollingInterval: RollingInterval.Day)
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                .CreateLogger();

            Log.Logger.Information("Connection aux logs !");
        }
    }
}
