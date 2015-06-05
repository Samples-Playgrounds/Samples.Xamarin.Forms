using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControlsViews.Pages;

namespace ControlsViews
{
	public partial class PageMain
	{
		public PageMain()
		{
			InitializeComponent();


			//...................................................
			// Defined in XAML
			//buttonConotrolsInCode.buttonSamplesInCode_Clicked
			//...................................................

			//this.buttonSamplesInCode.Clicked += buttonSamplesInCode_Clicked;

			return;
		}

		private void buttonSamplesInXamlPushModal_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsInXaml());
		
			return;
		}

		private void buttonSamplesInCodePushModal_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsInCode());
		
			return;
		}

		private void buttonSamplesInXamlPush_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new PageControlsViewsInXaml());
		
			return;
		}

		private void buttonSamplesInCodePush_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new PageControlsViewsInCode());
		
			return;
		}
	}
}
