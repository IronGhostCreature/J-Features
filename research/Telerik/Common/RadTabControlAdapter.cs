using System;
using System.Net;
using System.Windows;
using Microsoft.Practices.Prism.Regions;
using Telerik.Windows.Controls;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace Common
{
	public class RadTabControlAdapter : RegionAdapterBase<RadTabControl>
	{
		public RadTabControlAdapter(IRegionBehaviorFactory regionBehaviorFactory)
			: base(regionBehaviorFactory)
		{ }

		protected override void Adapt(IRegion region, RadTabControl regionTarget)
		{
			region.ActiveViews.CollectionChanged += (sender, args) =>
			{
				switch (args.Action)
				{
					case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
					foreach (UserControl view in args.NewItems)
					{
						RadTabItem tab = new RadTabItem();
						tab.DataContext = view.DataContext;
						tab.SetBinding(RadTabItem.HeaderProperty, new Binding());
						tab.Style = regionTarget.ItemContainerStyle;
						tab.Content = view;
						regionTarget.Items.Add(tab);
					}
					break;
					case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
					foreach (UserControl view in args.OldItems)
					{
						RadTabItem viewTab = regionTarget.Items.Cast<RadTabItem>().Single(o => o.DataContext == view.DataContext);
						regionTarget.Items.Remove(viewTab);
					}
					break;
				}
			};
		}

		protected override IRegion CreateRegion()
		{
			return new AllActiveRegion();
		}
	}
}
