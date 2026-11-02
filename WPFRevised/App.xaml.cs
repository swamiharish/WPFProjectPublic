using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WPFRevised
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //ServiceProvider _serviceProvider;

        ServiceProvider _serviceProvider;

        public App()
        {

            // ServiceProvider objServiceProvider = new ServiceCollection()
            //.AddSingleton<Template>()
            //.AddSingleton<StylesTriggers>()
            //.AddSingleton<ResourceStyles>()
            //.BuildServiceProvider();
            // _serviceProvider = objServiceProvider;

            ServiceCollection services = new ServiceCollection();   
            services.AddSingleton<Template>();
            services.AddSingleton<StylesTriggers>();
            services.AddSingleton<ResourceStyles>();
            services.AddSingleton<IcommandEx>();
            _serviceProvider = services.BuildServiceProvider();


        }

       protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Create and show the main window
            //ResourceStyles   mainWindow = new ResourceStyles()
            // StylesTriggers mainWindow = new StylesTriggers();

            IcommandEx mainWindow = _serviceProvider.GetService<IcommandEx>();
           // Template mainWindow = new Template();

            mainWindow.Show();      
        }

      
    }

}
