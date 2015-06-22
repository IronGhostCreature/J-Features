using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Common;
using Module1.ViewModels;

namespace Module1.Views
{
	public partial class FlandersView : UserControl
	{
		public FlandersView(IModuleManager _moduleManager, IRegionManager _regionManager)
		{
			InitializeComponent();

			this.DataContext = new FlandersViewModel(_moduleManager, _regionManager);
		}
	}
}
