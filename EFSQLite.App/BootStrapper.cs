using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace EFSQLite.App
{
    public class Bootstrapper : UnityBootstrapper 
    {
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            
            // Register modules that should be loaded into the application
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(EFSQLiteModule.EFSQLiteModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            //this.RegisterTypeIfMissing(typeof(IModuleTracker), typeof(ModuleTracker), true);
            //this.Container.RegisterInstance<CallbackLogger>(this.callbackLogger);
        }
    }
}
