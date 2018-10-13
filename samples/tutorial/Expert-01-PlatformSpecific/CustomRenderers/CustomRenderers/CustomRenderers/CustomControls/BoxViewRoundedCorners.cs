using System;
using Xamarin.Forms;

namespace CustomRenderers.CustomControls
{
	public partial class BoxViewRoundedCorners 
		:
		Xamarin.Forms.BoxView
	{
		public BoxViewRoundedCorners ()
		{
		}

        public static readonly 
        	Xamarin.Forms.BindableProperty 
        		CornerRadiusProperty =
					Xamarin.Forms.BindableProperty.Create
											<
												BoxViewRoundedCorners,				// Owner of the property
												double								// type
											>
											(
												p => p.CornerRadius,				// property to return
												0									// default value
											);


		public double CornerRadius 
        {
            get 
            {
            	return (double)GetValue (CornerRadiusProperty);
            }
            set
            {
            	System.Diagnostics.Debug.WriteLine("Set CornerRadius = " + value);
            	SetValue (CornerRadiusProperty, value); 
            }
        }

   
		public Xamarin.Forms.Color Color
        { 
            get 
            { 
            	return Xamarin.Forms.Color.Transparent;
            } 
            set 
            {
            	FillColor = value;
            }
        }

        public static readonly 
	        Xamarin.Forms.BindableProperty 
	        	FillColorProperty =
					Xamarin.Forms.BindableProperty.Create
											<
												BoxViewRoundedCorners,				// Owner of the property
												Xamarin.Forms.Color					// Type
											> 
											(
												p => p.FillColor, 					// property to return
												Xamarin.Forms.Color.Transparent		// default value
											);

		public Xamarin.Forms.Color FillColor
        {
            get 
            {
            	return (Xamarin.Forms.Color)GetValue (FillColorProperty);
            }
            set 
            {
            	SetValue (FillColorProperty, value);
            }
        }

        public static readonly 
        	Xamarin.Forms.BindableProperty 
        		StrokeColorProperty =
					Xamarin.Forms.BindableProperty.Create
											<
												BoxViewRoundedCorners, 				// Owner of the property
												Xamarin.Forms.Color					// Type
											> 
											(
												p => p.StrokeColor,					// property to return
												Xamarin.Forms.Color.Transparent		// default value
											);


		public Xamarin.Forms.Color StrokeColor
        {
            get 
            {
            	return (Xamarin.Forms.Color)GetValue (StrokeColorProperty);
            }
            set 
            {
            	SetValue (StrokeColorProperty, value);
            }
        }




        public static readonly 
        	Xamarin.Forms.BindableProperty 
        		StrokeThicknessProperty =
            		Xamarin.Forms.BindableProperty.Create
											<
												BoxViewRoundedCorners, 				// Owner of the property
												double								// Type
											>
											(
												p => p.StrokeThickness,				// property to return
												0									// default value
											);


        public double StrokeThickness 
        {
            get 
            {
            	return (double)GetValue (StrokeThicknessProperty);
            }
			set 
			{
				SetValue (StrokeThicknessProperty, value);
			}
        }


        // using Xamarin.Forms
		public static readonly 
			BindableProperty HasShadowProperty = 
				BindableProperty.Create
								<
									BoxViewRoundedCorners,
									bool
								>
								(
									p => p.HasShadow, 
									default(bool)
								);

		public bool HasShadow 
		{
			get 
			{ 
				return (bool)GetValue(HasShadowProperty); 
			}
			set 
			{
				SetValue(HasShadowProperty, value);
			}
		}



		protected override void OnPropertyChanged (string property_name)
		{
			base.OnPropertyChanged (property_name);

			switch (property_name)
			{
				case "CornerRadius":
					SetValue (CornerRadiusProperty, CornerRadius);
					break;
				case "HasShadow":
					SetValue (HasShadowProperty, HasShadow);
					break;
				default:
					string msg = "BoxViewRoundedCorners.OnPropertyChanged missing property" + property_name; 
					System.Diagnostics.Debug.WriteLine(msg);
					break;
			}
		}
 	}
}
