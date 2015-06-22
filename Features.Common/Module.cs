using Features.Common;
using Features.CriticalPath.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Features.CriticalPath
{
   public class Module:IModule
    {
        private readonly IRegionManager _regionManager;

        public Module(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }

        public void Initialize()
        {
            var view = (CriticalPathView)ServiceLocator.Current.GetInstance(typeof(CriticalPathView), "J.windows.Features.RadTabControlAdapter");
            this._regionManager.Regions[RegionNames.TabControlRegion].Add(view, "CriticalPathView");
        }
    }

}
