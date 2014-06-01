using System;
using Xamarin.QuickUI;
using Tramchester.App.Views;
using Tramchester.App.Models;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

namespace Tramchester.App.Controls
{
	public class TramstopPicker : StackLayout
	{
		private Button selectionButton;
		private Label mainLabel;



		public ICommand ShowTramstopsCommand {
			get { return (ICommand)GetValue(ShowTramstopCommandProperty); }
			set { SetValue(ShowTramstopCommandProperty, value); }
		}

		public static BindableProperty ShowTramstopCommandProperty = BindableProperty.Create<TramstopPicker, ICommand> ((tramstopPicker) => tramstopPicker.ShowTramstopsCommand, null, BindingMode.TwoWay, null, OnShowTramstopPropertyChanged);

		private static void OnShowTramstopPropertyChanged(BindableObject bindable, 
			object oldvalue, object newvalue)
		{
			var tramstopPicker = (TramstopPicker)bindable;
			tramstopPicker.ShowTramstopsCommand = (ICommand)newvalue;
		}

		public string LabelText {
			get { return (string)GetValue(LabelTextProperty); }
			set 
			{ 
				SetValue(LabelTextProperty, value);
				this.mainLabel.Text = value; 
			}
		}

		public static BindableProperty LabelTextProperty = BindableProperty.Create<TramstopPicker, string> ((tramstopPicker) => tramstopPicker.LabelText, null, BindingMode.TwoWay, null, OnLabelTextPropertyChanged);


		private static void OnLabelTextPropertyChanged(BindableObject bindable, 
			object oldvalue, object newvalue)
		{
			var tramstopPicker = (TramstopPicker)bindable;
			tramstopPicker.LabelText = (string)newvalue;
		}

		public Tramstop Tramstop {
			get { return (Tramstop)GetValue(TramstopProperty); }
			set 
			{ 
				SetValue(TramstopProperty, value);
				this.selectionButton.Text = value.Name; 
			}
		}

		public static BindableProperty TramstopProperty = BindableProperty.Create<TramstopPicker, Tramstop> ((tramstopPicker) => tramstopPicker.Tramstop, null, BindingMode.TwoWay, null, OnTramstopPropertyChanged);


		private static void OnTramstopPropertyChanged(BindableObject bindable, 
			object oldvalue, object newvalue)
		{
			var tramstopPicker = (TramstopPicker)bindable;
			tramstopPicker.Tramstop = (Tramstop)newvalue;
		}

		public TramstopPicker ()
		{
			this.mainLabel = new Label ();

			selectionButton = new Button { Text = "Please select tram stop" };
			selectionButton.Activated += (object sender, EventArgs e) => {
				if(this.ShowTramstopsCommand.CanExecute(null)){
					this.ShowTramstopsCommand.Execute(null);
				}
			};

			this.Add(mainLabel);
			this.Add(selectionButton);

		}

	}
}

