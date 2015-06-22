using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Practices.Prism.Regions;
using Telerik.Windows.Controls;
using Telerik.Windows.Media.Imaging;

namespace J.windows.Features
{
    [Export]
    public class RadTabControlAdapter : RegionAdapterBase<RadTabControl>
    {
        [ImportingConstructor]
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
                            var tab = new RadTabItem {DataContext = view.DataContext};
                            tab.SetBinding(RadTabItem.HeaderProperty, new Binding());
                            tab.Style = regionTarget.ItemContainerStyle;
                            tab.Content = view;
                            regionTarget.Items.Add(tab);
                        }
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        foreach (UserControl view in args.OldItems)
                        {
                            var viewTab = regionTarget.Items.Cast<RadTabItem>().Single(o => o.DataContext == view.DataContext);
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
