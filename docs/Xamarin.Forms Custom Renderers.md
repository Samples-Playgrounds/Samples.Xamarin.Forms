# Xamarin.Forms Custom Renderers

video: Custom Renderers in Xamarin.Forms (Xamarin.University)

Definition:

Xamarin.Foroms cross platform component (mc++: framework) which enables defining UI c#
and native classes which are natively rendered in Android, iOS and Windows Phone.

Provides ability to write app code once w/o 




## Environment

1.	Xamarin.Studio
2.	Visual Studio


## Rendering Model

*	2 parts
	*	Control / View / Element
		*	Describes visual elemement
		*	platform agnostic (not tied to any platform)
			* defined in portable/shared part
	*	Renderer
		*	during application execution
		*	creates platform visualisation based on model
		*	platform specific - LabelRenderer
			*	iOS: UILabel
			*	Windows Phone: TextBlock
			*	Android: TextView



## Use Case for Custom Renderers

*	Custom Controls
	*	new Controls not available in Xamarin.Forms
	*	Calendar
	*	Accordion
	*	Charting
*	Custom Rendering	
	*	Text decorations
	*	Shadows
	*	Animations
	*	Platform-Specific features
	*	performance improvements 

Custom renderers for replacing default renderers.
Selective replacement only desired platforms.


### Steps

1.	add new class CustomizedControl which derives from Control to be customized
	1.	add properties needed to implement custom behavior		
		properties will be bindable only base class is BindableObject		
		View derives from BindableObjecr
		1.	add readonly static field		
			public readonly static BindableProperty <SomePropertyName>
		2.	initialize this field		
			
			<pre>
BindableProperty.Create		// generic method
		<
			CustomizedControl
		,
		>
		(
		  CustmozizedControlView 	//Owner
		, double					// property type
			(
				p=>p.CornerRadius	// property needed to be implemented
				, 0 				// default value
			);
			</pre>
		3.	implement property 	




#### Samples continued

		
	//Bindable property for the progress color
	public static readonly BindableProperty ProgressColorProperty =
		BindableProperty.Create<CircularProgress,Color>
			(
				p => p.ProgressColor, Color.Red
			);
			
	//Gets or sets the color of the progress bar
	public Color ProgressColor 
	{
	  get { return (Color)GetValue (ProgressColorProperty); }
	  set { SetValue (ProgressColorProperty, value); }
	}




	public class CustomChartView : View
	{
	  public static readonly BindableProperty ItemSourceProperty =
		BindableProperty.Create<CustomChartView, StockMarketDataSample>
			(
				p => p.ItemSource, 
				new StockMarketDataSample()
			);
		
	  public StockMarketDataSample ItemSource
	  {
		get { return (StockMarketDataSample)GetValue(ItemSourceProperty); }
		set { SetValue(ItemSourceProperty, value); }
	  }
	  // Additional bindable properties
	}
	
## References Links


*	[http://blog.falafel.com/learning-xamarin-custom-renderers-in-xamarin-forms/](http://blog.falafel.com/learning-xamarin-custom-renderers-in-xamarin-forms/)
*	[http://blog.xamarin.com/using-custom-controls-in-xamarin.forms-on-android/][http://blog.xamarin.com/using-custom-controls-in-xamarin.forms-on-android/]
*	[http://blog.xamarin.com/using-custom-controls-in-xamarin.forms-on-windows-phone/](http://blog.xamarin.com/using-custom-controls-in-xamarin.forms-on-windows-phone/)

http://stackoverflow.com/questions/26040652/binding-to-listview-item-tapped-property-from-view-model
http://stackoverflow.com/questions/25126433/force-redraw-of-xamarin-forms-view-with-custom-renderer
