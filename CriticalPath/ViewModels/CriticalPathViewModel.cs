using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Features.Common;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace CriticalPath.ViewModels
{
    [Export]
    public class CriticalPathViewModel:MainViewModel
    {
        IRegionManager regionManager;

        public CriticalPathViewModel( IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            this.Title = "Critial Path";
        }

        public string Title { get; set; }
        public DelegateCommand CloseCommand { get; set; }

        private void CloseTab()
        {
            var view = regionManager.Regions[RegionNames.TabControlRegion].GetView("CriticalPathView");
            regionManager.Regions[RegionNames.TabControlRegion].Remove(view);
        }
    }
}
