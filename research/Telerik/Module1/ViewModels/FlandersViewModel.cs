using System;
using System.Net;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Common;
using Telerik.Windows.Controls;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Module1.ViewModels
{
	public class FlandersViewModel : MainViewModel
	{
		IModuleManager moduleManager;
		IRegionManager regionManager;

		public FlandersViewModel(IModuleManager _moduleManager, IRegionManager _regionManager)
		{
			this.moduleManager = _moduleManager;
			this.regionManager = _regionManager;
			
			Title = "The Flanders";
			Items.Add(new DataItem("Ned"));
			Items.Add(new DataItem("Maude"));
			Items.Add(new DataItem("Todd"));
			Items.Add(new DataItem("Rod"));
			Items.Add(new DataItem("Tina"));

			CloseCommand = new DelegateCommand(new Action<object>((p) => { this.CloseTab(); })); 
		}

		public string Title { get; set; }
		
		public DelegateCommand CloseCommand { get; set; }	

		
		private void CloseTab()
		{
			var view = regionManager.Regions[RegionNames.TabControlRegion].GetView("TheFlandersView");
			regionManager.Regions[RegionNames.TabControlRegion].Remove(view);
		}
        
	}
}
