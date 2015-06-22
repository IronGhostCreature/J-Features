using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;
using Common;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Module2.ViewModels
{
	public class SimpsonViewModel : MainViewModel
	{
		IModuleManager moduleManager;
		IRegionManager regionManager;

		public SimpsonViewModel(IModuleManager _moduleManager, IRegionManager _regionManager)
		{
			this.moduleManager = _moduleManager;
			this.regionManager = _regionManager;

			this.Title = "The Simpson";

			Items.Add(new DataItem("Homer"));
			Items.Add(new DataItem("Marge"));
			Items.Add(new DataItem("Bart"));
			Items.Add(new DataItem("Lisa"));
			Items.Add(new DataItem("Maggie"));
			this.IsSelected = true;

			CloseCommand = new DelegateCommand(new Action<object>((p) => { this.CloseTab(); }));
		}
		public string Title { get; set; }
		public DelegateCommand CloseCommand { get; set; }

		private void CloseTab()
		{
			var view = regionManager.Regions[RegionNames.TabControlRegion].GetView("TheSimpsonsView");
			regionManager.Regions[RegionNames.TabControlRegion].Remove(view);
		}
	}
}
