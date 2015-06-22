using System;
using System.Net;
using System.Windows;

namespace Common
{
	public class DataItem
	{
		public DataItem(string _header)
		{
			this.Header = _header;
		}
		public string Header { get; set; }
	}
}
