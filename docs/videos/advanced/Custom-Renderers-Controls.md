# Platform specific: Custom Renderers (aka Custom Controls)

video: Evolve 2014 Jason Smith "Extending Xamarin.Forms with custom controls"

## Motivation

Albert Einstein

"Everything should be simple as possible,but not simpler."

*	API complexity
	*	iOS: 		33000		
	*	Android:	40000		
	
* Xamarin.Forms: 	2000		
	* 	may not be enough		
	*	with access to native (peephole) everything can be done		
	
*	Writing code - managing complexity
*	complexity source of the bugs
*	complexity makes apps amazing
*	necessary evil - need to deal with it.


* Xamarin.Forms - must: think about native UX


## Custom Renderers

*	Renderers	
	*	transforms Xamarin.Forms Views into native API components concepts
		*	iOS: 			UIView			
		*	Android:		View			
		*	Windows Phone:	FrameworkElement		
*	multiple components	
	*	ExportRendererAttribute		
		*	mapping	(simple mapping concept to map one type to another)
		*	on application startup all attributes are loaded and mapping is created
		*	assembly attribute		
			*	faster (class Attribute needs all classes to be loaded - 300ms)
	*	OnElementChanged method
		*	event that
			* 	new element 
			*	watched/tracked/observed element has changed
		*	most important
		*	ElementChangedEventArgs	(similar to INotifiyPropertChanged)
			*	properties
				*	Element
				*	OldElement
			*	pattern
				*	do nothing
					*	if (null == Control)
					*	||
					*	null != ea.OldElement
					*	||
					*	null == Element

*	custom renderers
	*	topics	
		*	correct handling of the re-using
		*	default Renderer overwriting - not suggested
		*	existing Renderers - modifications
		*	creation of new View types
	*	purpose
		*	customization		
			implementing things not available by default	
		*	optimization		
			faster rendering
		

		
### Simple samples

	[assembly: ExportREnderer(typeof(RoundedButton), typeof(RoundedButtonRenderer)]
	public partial class RoundedButtonRenderer	
		:
		ButtonRenderer 	// 
	{
		// no override ???
		public void OnElementChanged(ElementChangedEventArgs<Button> ea)
		{
			base.OnElementChanged(ea);

			// pattern added
			if 
				(
					null == Control
					||
					null != ea.OldElement 
					||
					null == Element
				)
			{
				// NOOP - do nothing
				retrunl;
			}
			
			// original code
			if (null != Control)
			{
				Control.Layer.CornerRadius = 12;
				Control.Layer.BorderWidth = 3;				
			}
		}
	}

	
	
##	Specializing existing Renderers


	[assembly: ExportREnderer(typeof(CircleImageRenderer), typeof(ImageRenderer)]
	public partial class CircleImageRenderer	
		:
		ImageRenderer 	// 
	{
		public override void OnElementChanged(ElementChangedEventArgs<Button> ea)
		{
			base.OnElementChanged(ea);

			//----------------------------------------------------------------------
			// pattern 
			//		simple
			if 
				(
					null == Control
					||
					null != ea.OldElement 
					||
					null == Element
				)
			{
				// NOOP - do nothing
				retrunl;
			}
			//............................................................
			//	pattern
			//		real world
			if (null == Control)
			{
				// initialie control
			}
			
			if (null != ea.OldElement)
			{
				// memory management - prevent leaks
				//	unhooking event handlers that might hold references
				// unsubscribe
				ea.OldElement.ChildAdded -= OldElementChildAdded;
			}
			
			if (null != ea.NewElement)
			{
				// hook event handlers to new element
				// subscribe
				ea.OldElement.ChildAdded += OldElementChildAdded;
			}
			//----------------------------------------------------------------------
				
			double min = Math.Min(Element.Width, Element.Height);
			Control.Layer.CornerRadius = (float)(min / 2.0);
			Control.Layer.MasksToBounds = false;
			Control.Layer.BorderWidth = 3;
			Control.ClipToBounds = true;
			
			// platform specific - in platform library or app project!!!
			Control.Layer.BorderColor = new CoreGraphics.CGColor(1,1,1);
		}
		
		protected void OldElementChildAdded(object sender, ElementEventArgs ea)
		{
		}
	}
	


	
	
### Importing native Views



	public partial class LoadingViewRenderer : ViewRenderer<LoadingView, CustomLoadingView>
	{
		protected override async void OnElementChanged(ElementChangedEventArgs<LoadingView> ea)
		{
			base.OnElementChanged(ea);
	
			if (null == Control)
			{
				// should be called only once!!
				SetNativeControl(new CustomLoadingView());
			}
			
			if (null != ea.OldElement)
			{
			
			}
		}
	}
	
	
	public partial class CustomLoadingView : UIView
	{
		
	}
	
	
	
*	Do not override default rednerers
*	it is possible but people will hate you
*	Renderers are (currently) not dynamically configurable		
	*	there is Registrar and this would need to be configurable too...

### Q&A

*	customizing Layouts
	* possible by subclassing (internal)
	
	
	public CustomLayout 
		: 
			Layout // internal 2014-10
			// Layout<View>
			// Layout<TabbedPage>
			// 
	{
	}

	public CustomStackLayout : StackLayout
	{
		protected override void LayoutChildren(double x, double y, double w, double h)
		{
			base.LayoutChildren(x,y,w,h);
		}
	}
	

#### 	v.1.3
	
*	Styles
*	Behaviours
*	Triggers
*	DynamicResources
*	Styles based on DynamicResources
*	Application class


####	Gestures

*	Popups
*	Gesture Handlers
	*	longtap
	*	swipe
	*	

Xamarin.Android as single activity 

*	google recommended
*	Fragments were not backported (project start) Fragments were target
*	activity navigtion paradigms of the Activity did not match desired paradigms for 
	Navigation in Xamarin.Forms
*	native hookines
	*	extension methods in platform specific projects
*	Designer		
	*	planned
	*	drag and drop - probably not
	*	live preview
	*	Xamarin.Sketches
*	tablet support
	*	Device.Idio == TargetIdiom.Tablet
	* adaptation for tablets
	


	
## References

*	[http://www.michaelridland.com/](http://www.michaelridland.com/)
*	[http://www.codeproject.com/Articles/818536/Creating-a-Cross-Platform-Application-Bar-for-Xama](http://www.codeproject.com/Articles/818536/Creating-a-Cross-Platform-Application-Bar-for-Xama)



http://www.infinite-x.net/2014/06/05/creating-a-drawing-app-using-xamarin-forms/



	