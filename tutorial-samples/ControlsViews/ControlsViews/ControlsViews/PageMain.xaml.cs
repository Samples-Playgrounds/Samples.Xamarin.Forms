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

		private void buttonSamplesInXaml_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsInXaml());
		
			return;
		}

		private void buttonSamplesInCode_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsInCode());
		
			return;
		}
	}
}
