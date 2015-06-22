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
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Telerik.Windows;
using Common;
using Module2.ViewModels;

namespace Module2.Views
{
	public partial class SimpsonsView : UserControl
	{

		public SimpsonsView(IModuleManager _moduleManager, IRegionManager _regionManager)
		{
			InitializeComponent();

			this.DataContext = new SimpsonViewModel(_moduleManager, _regionManager);
		}
	}
}
