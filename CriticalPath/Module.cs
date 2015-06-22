using System.ComponentModel.Composition;
using CriticalPath.Views;
using Features.Common;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace CriticalPath
{
    [ModuleExport(typeof(Module), InitializationMode = InitializationMode.WhenAvailable)]
    public class Module:IModule
    {
        private readonly IRegionManager _regionManager;

        [ImportingConstructor]
        public Module(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }

        public void Initialize()
        {
            var view = (CriticalPathView)ServiceLocator.Current.GetInstance(typeof(CriticalPath.Views.CriticalPathView), "CriticalPath.Views.CriticalPathView");
            this._regionManager.Regions[RegionNames.TabControlRegion].Add(view, "CriticalPathView");
        }
    }

}
