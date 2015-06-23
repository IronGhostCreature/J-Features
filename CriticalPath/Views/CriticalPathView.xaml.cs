using System.ComponentModel.Composition;
using System.Windows.Controls;
using CriticalPath.ViewModels;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace CriticalPath.Views
{
    /// <summary>
    /// Interaction logic for CriticalPathView.xaml
    /// </summary>
    [Export]
    public partial class CriticalPathView : UserControl
    {
        [ImportingConstructor]
        public CriticalPathView(IRegionManager _regionManager)
        {
            InitializeComponent();
            this.DataContext = new CriticalPathViewModel(_regionManager);
        }
    }
}
