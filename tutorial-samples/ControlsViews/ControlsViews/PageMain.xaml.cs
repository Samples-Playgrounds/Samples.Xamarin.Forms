using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsViews
{
	public partial class PageMain
	{
		public PageMain()
		{
			InitializeComponent();

			this.buttonConotrolsInCode.Clicked += buttonConotrolsInCode_Clicked;

			return;
		}

		private void buttonConotrolsInCode_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsSimpleInCode());

			return;
		}

		private void buttonConotrolsInXaml_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageControlsViewsSimpleInXaml());


			return;
		}
	}
}
