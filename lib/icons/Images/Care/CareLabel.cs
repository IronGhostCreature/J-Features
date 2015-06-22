using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Media.Imaging;
using StylePack.Utils;
using StylePack.Utils.Extensions;

namespace StylePack.UI.Images.Care
{
  public class CareLabel
  {
    public String Category { get; set; }
    public String ImageName { get; set; }
    public String Name { get; set; }
    public String Temperature { get; set; }
    public String Zone { get; set; }
    public String Code { get; set; }
		
	  public Bitmap Image
	  {
		  get { return new BitmapImage(new Uri(ImageName)).ToBitmap(); }
	  }
  }

  public class CareLabelCollection : ObservableCollection<CareLabel>
  {
    
  }
}
