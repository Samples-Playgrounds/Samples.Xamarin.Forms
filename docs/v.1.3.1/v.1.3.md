# v.1.3

## steps

### Updating apps

http://developer.xamarin.com/guides/cross-platform/macios/updating-xamarin-forms-apps/



## webinar 20150129

*	App
	*	application lifecycle events
		*	OnStart
		*	OnSleep
			*	phone call
		*	OnResume
*	Font refactoring
	*	Font replaced with
	*	new properties
		*	FontFamily
		*	FontSize
		* 	FontAttributes
	*	GetNamedSize() to resolve NamedSize
* 	Navigation Stack
	*	accessing and editing NavigationStack
	*	features
		*	RemovePage
		*	InserPageBefore
		* 	NavigationStack[]
*	Styles
	*	previous
		*	ResourceDictionary
		*	referenced through {StaticResource}
	*	new
		*	group into Style
			* 
		*	DynamicResource
*	Behaviors
*	Triggers

		
		
		
## Behaviors

*	C# classes that inherit from Behavior<T> where T is the UI element to which a 
	functionality is attached. 
*	extremely useful for attaching a piece of functionality to an existing element 
	in a view.
*	powerful because they are reusable and easy to incorporate into unit testing 
	since they are an independent piece of functionality.	
	
*	A behavior class must inherit from Behavior<T> and override two methods 		
	*	OnAttachedTo(T view) 
	*	OnDetachingFrom(T view)

	{
		protected override void OnAttachedTo (Entry bindable)
		{
			// ...
		}
		protected override void OnDetachingFrom (Entry bindable)
		{
			// ...
		}
	}	
	
*	OnAttachedTo 
	This method is fired immediately after the behavior is attached to the view. 	
	User can use this method to add a specific functionality to the UI element.		
	For example, you can subscribe to the TextChanged event of the Entry control 
	and validate the text for email.
*	OnDetachingFrom		
	This method is fired when the behavior is removed from the attached control. 	
	User can use this method to remove event handlers that were previously attached 
	to avoid memory leaks.	

	
*	Every VisualElement has a Behaviors property - Behavior collection. 
	Behaviors are attached to the element by simply adding the Behavior to that 
	collection.

	<Entry 
		Placeholder="Sample">
	  <Entry.Behaviors>
		<local:EmailValidatorBehavior  />
	  </Entry.Behaviors>
	</Entry>
	
	
	
### References Links

*	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/behaviors/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/behaviors/)
*	[http://blog.xamarin.com/behaviors-in-xamarin.forms/](http://blog.xamarin.com/behaviors-in-xamarin.forms/)
		
	
### Sample Behavior on Entry element for validating Email	


	public class EmailValidatorBehavior : Behavior
	{
		const string emailRegex = 
			@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" 
			+
			@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"
			;
			
		static readonly BindablePropertyKey IsValidPropertyKey = 
			BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(NumberValidatorBehavior), false);
		public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;
		
		public bool IsValid
		{
			get { return (bool)base.GetValue(IsValidProperty); }
			private set { base.SetValue(IsValidPropertyKey, value); }
		}
		
		protected override void OnAttachedTo(Entry bindable)
		{
			bindable.TextChanged += HandleTextChanged;
		}
		
		void HandleTextChanged(object sender, TextChangedEventArgs e)
		{
			IsValid = (Regex.IsMatch(e.NewTextValue, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) ? true : false;
			((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;
		}
		protected override void OnDetachingFrom(Entry bindable)
		{
			bindable.TextChanged -= HandleTextChanged;
		}
	}

## Triggers

*	express actions declaratively in XAML that change the appearance 
	of controls based on events or property changes.
*	possibility to assign/add a trigger
	*	control, 
	*	page-level 
	*	app-levelapp-level 
*	reusability/sharing
	*	resource dictionary to be applied to multiple controls.

There are four types of trigger:

*	Property Trigger		
	occurs when a property on a control is set to a particular value.
*	Data Trigger		
	uses data binding to trigger based on the properties of another control.
*	Event Trigger		
	occurs when an event occurs on the control.
*	Multi Trigger		
	allows multiple trigger conditions to be set before an action occurs.

		
### References Links

*	[http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/triggers/](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/triggers/)
*	[http://forums.xamarin.com/discussion/31568/multi-triggers-conditions](http://forums.xamarin.com/discussion/31568/multi-triggers-conditions)
*	[]()
*	[]()



### Sample Behavior on Entry element for validating Email	
