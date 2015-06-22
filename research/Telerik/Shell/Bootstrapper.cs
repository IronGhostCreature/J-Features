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
using Microsoft.Practices.Prism.UnityExtensions;
using Shell.Views;
using Microsoft.Practices.Prism.Modularity;
using Telerik.Windows.Controls;
using Common;
using Microsoft.Practices.Prism.Regions;

namespace Shell
{
	public class Bootstrapper : UnityBootstrapper
	{

		protected override DependencyObject CreateShell()
		{
			// Use the container to create an instance of the shell.
			ShellView view = Container.TryResolve<ShellView>();
			return view;
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();

			Application.Current.MainWindow = (Window)this.Shell;
			Application.Current.MainWindow.Show();
		}
		protected override IModuleCatalog CreateModuleCatalog()
		{
			ModuleCatalog catalog = new ModuleCatalog();
			catalog.AddModule(typeof(Module1.Module1));
			catalog.AddModule(typeof(Module2.Module2));
			return catalog;
		}

		protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
		{
			var mappings = base.ConfigureRegionAdapterMappings();

			mappings.RegisterMapping(typeof(RadTabControl), Container.TryResolve<RadTabControlAdapter>());

			return mappings;
		}
	}
}
