using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ControlsViews.Cells
{
	public partial class CustomCellInCode : ViewCell
	{
		public CustomCellInCode()
		{
			Label labelUserName = new Label();
			Entry entryUserName = new Entry();
			StackLayout stack_horizontal_username = new StackLayout();
			stack_horizontal_username.Children.Add(labelUserName);
			stack_horizontal_username.Children.Add(entryUserName);


			Label labelPassword1 = new Label();
			Entry entryPassword1 = new Entry();
			StackLayout stack_horizontal_pwd1 = new StackLayout();
			stack_horizontal_pwd1.Children.Add(labelPassword1);
			stack_horizontal_pwd1.Children.Add(entryPassword1);

			Label labelPassword2 = new Label();
			Entry entryPassword2 = new Entry();
			StackLayout stack_horizontal_pwd2 = new StackLayout();
			stack_horizontal_pwd2.Children.Add(labelPassword2);
			stack_horizontal_pwd2.Children.Add(entryPassword2);

			StackLayout stack_vertical = new StackLayout();
			stack_vertical.Children.Add(stack_horizontal_username);

			// Cell's View
			this.View = stack_vertical;


			// DataBinding
			labelUserName.SetBinding(Label.TextProperty, "UserName");
			entryUserName.SetBinding(Entry.TextProperty, "UserName");

			return;
		}
	}
}
