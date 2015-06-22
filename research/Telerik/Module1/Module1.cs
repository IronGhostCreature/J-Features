using System;
using System.Net;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Common;
using Module1.Views;

namespace Module1
{
	public class Module1 : IModule
	{
		IRegionManager regionManager;
		IUnityContainer container;

		public Module1(IRegionManager _regionManager, IUnityContainer _container)
		{
			this.regionManager = _regionManager;
			this.container = _container;
		}

		#region IModule Members

		public void Initialize()
		{
			//this.regionManager.RegisterViewWithRegion(RegionNames.TabControlRegion, () => container.Resolve<FlandersView>());
			this.regionManager.Regions[RegionNames.TabControlRegion].Add(container.Resolve<FlandersView>(), "TheFlandersView");
		}

		#endregion
	}
}
