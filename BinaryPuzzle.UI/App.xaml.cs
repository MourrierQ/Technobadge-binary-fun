using Autofac;
using BinaryPuzzle.UI.Startup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BinaryPuzzle.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //var mainWindow = new MainWindow(
            //    new MainViewModel(
            //        new FriendDataService()));

            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();

            mainWindow.Show();
        }
    }
}
