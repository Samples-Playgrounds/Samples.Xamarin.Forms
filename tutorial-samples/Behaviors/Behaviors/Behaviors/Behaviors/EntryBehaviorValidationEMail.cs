using System;

using Xamarin.Forms;
using System.Text.RegularExpressions;

namespace Behaviors
{
	public partial class EntryBehaviorValidationEMail 
		: 
		// Behavior
		Behavior<Entry>
	{
		public EntryBehaviorValidationEMail ()
		{
		}

		protected override void OnAttachedTo(Entry entry)
		{
		entry.TextChanged += OnEntryTextChanged;

		base.OnAttachedTo(entry);
		}

		protected override void OnDetachingFrom(Entry entry)
		{
			entry.TextChanged -= OnEntryTextChanged;

			base.OnDetachingFrom(entry);
		}

		bool IsValid;

		protected void OnEntryTextChanged(object sender, TextChangedEventArgs e)
		{
			IsValid = 
				(
					Regex.IsMatch
							(
							  e.NewTextValue
							, emailRegex 
							, RegexOptions.IgnoreCase
							, TimeSpan.FromMilliseconds(250)
							)
				) 
				? true : false
				;
        	((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;

			return;
		}

		// TODO: BUG if const then emailRegex = String.Empty!!!!
		//const 
		string emailRegex = 
		@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" 
		+
        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"
		;

	}
}

