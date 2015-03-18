using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images.Views.Xaml
{
	public partial class PageImagesEmbeddedResources
	{
		public PageImagesEmbeddedResources()
		{
			InitializeComponent();

			string[] resources = null;
			resources = HolisticWare.Mobile.UI.XamarinForms.Images.ImageEmbedded.EmbeddedResourcesFromAssembltOf(this);

			imageEmbeddedResource.Source = Xamarin.Forms.ImageSource.FromResource("Images.Images.image.png");

			return;
		}
	}
}
