using System;
using System.Net;
using System.Windows;
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;

namespace Common
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
