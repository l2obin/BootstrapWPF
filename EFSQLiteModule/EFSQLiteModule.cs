using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFSQLiteModule
{
    public class EFSQLiteModule : IModule
    {
        private readonly IRegionManager regionManager;

        public EFSQLiteModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.MainView));
        }
    }
}
