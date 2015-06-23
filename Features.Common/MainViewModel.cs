using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace Features.Common
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<DataItem>();
        }
        private bool isSelected;
        public bool IsSelected
        {
            get
            {
                return this.isSelected;
            }
            set
            {
                if (this.isSelected != value)
                {
                    this.isSelected = value;
                    OnPropertyChanged("IsSelected");
                }
            }
        }

        public ObservableCollection<DataItem> Items { get; set; }
    }
}
