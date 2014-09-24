using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlsViews.Pages.Code.Cells
{
	public partial class CustomCellUsingContenViewDefinedInXaml : ViewCell
	{
		public CustomCellUsingContenViewDefinedInXaml() 
			: base()
		{
			this.View = new ControlsViews.Pages.Xaml.Cells.CustomCellAsContentViewInXaml();

			return;
		}
	}
}
