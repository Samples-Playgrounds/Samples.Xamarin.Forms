using System;

using Xamarin.Forms;
using System.Collections;
using System.Collections.Specialized;

using Core.Collections;

namespace CustomRenderers
{
	/// <summary>
	/// Picker bindable.
	/// </summary>
	/// <see cref="https://forums.xamarin.com/discussion/30801/xamarin-forms-bindable-picker"/>
	/// <see cref="https://github.com/soltechinc/soltechxf"/>
	/// <see cref="https://gist.github.com/Sankra/286cfbdd5dfd379a9155"/>
	/// <see cref="https://forums.xamarin.com/discussion/19079/data-binding-for-the-items-source-of-a-picker-control"/>
	/// <see cref="http://stackoverflow.com/questions/15854708/how-can-i-bind-a-xaml-property-to-a-static-variable-in-another-class"/>
	public partial class PickerBindable : Picker
	{
		//Bindable property for the items source
		public static readonly BindableProperty ItemsSourceProperty =
		BindableProperty.Create
							<
								PickerBindable, 
								IEnumerable
							>
							(
								p => p.ItemsSource, 
								null, 
								propertyChanged: OnItemsSourcePropertyChanged
							);

		/// <summary>
		/// Gets or sets the items source.
		/// </summary>
		/// <value>
		/// The items source.
		/// </value>
		public IEnumerable ItemsSource
		{
			get 
			{ 
				return (IEnumerable)GetValue(ItemsSourceProperty); 
			}
			set 
			{ 
				SetValue(ItemsSourceProperty, value); 
			}
		}


		/// <summary>
		/// Called when [items source property changed].
		/// </summary>
		/// <param name="bindable">The bindable.</param>
		/// <param name="value">The value.</param>
		/// <param name="newValue">The new value.</param>
		private static void OnItemsSourcePropertyChanged (BindableObject bindable, IEnumerable value, IEnumerable newValue)
		{
			var picker = (PickerBindable)bindable;
			var notifyCollection = newValue as INotifyCollectionChanged;

			if (notifyCollection != null)
			{
				notifyCollection.CollectionChanged += (sender, args) =>
				{
					if (args.Action == NotifyCollectionChangedAction.Reset)
					{
						picker.Items.Clear();

						return;
					}

					if (args.NewItems != null)
					{
						foreach (var newItem in args.NewItems)
						{
							picker.Items.Add((newItem ?? "").ToString());
						}
					}

					if (args.OldItems != null)
					{
						foreach (var oldItem in args.OldItems)
						{
							picker.Items.Remove((oldItem ?? "").ToString());
						}
					}
				};
			}

			if (newValue == null)
			{
				return;

			}

			picker.Items.Clear ();

			foreach (var item in newValue)
			{
				picker.Items.Add ((item ?? "").ToString ());
			}
		}



		//Bindable property for the selected item
		public static readonly BindableProperty SelectedItemProperty =
			BindableProperty.Create
								<
								PickerBindable, 
								object
								>
								(
									p => p.SelectedItem, 
									null, 
									BindingMode.TwoWay, 
									propertyChanged: OnSelectedItemPropertyChanged
								);

		/// <summary>
		/// Gets or sets the selected item.
		/// </summary>
		/// <value>
		/// The selected item.
		/// </value>
		public object SelectedItem
		{
			get 
			{
				return GetValue(SelectedItemProperty);
			}
			set 
			{ 
				SetValue(SelectedItemProperty, value);
			}
		}



		/// <summary>
		/// Called when [selected item property changed].
		/// </summary>
		/// <param name="bindable">The bindable.</param>
		/// <param name="value">The value.</param>
		/// <param name="newValue">The new value.</param>
		private static void OnSelectedItemPropertyChanged (BindableObject bindable, object value, object newValue)
		{
			var picker = (PickerBindable)bindable;
			if (picker.ItemsSource != null)
			{
				picker.SelectedIndex = picker.ItemsSource.IndexOf (picker.SelectedItem);
			}

			return;
		}

	}
}

