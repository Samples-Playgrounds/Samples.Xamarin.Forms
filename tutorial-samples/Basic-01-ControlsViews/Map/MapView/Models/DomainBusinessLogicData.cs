using System;
using System.Collections.Generic;

namespace ControlsView.MapView
{
	public class DomainBusinessLogicData
	{
		public DomainBusinessLogicData ()
		{
		}




		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Map in Code", 
				"ControlsView.MapView.Views.Code.PageMap"
			},
			{ 
				"Map in XAML", 
				"ControlsView.MapView.Views.XAML.PageMap"
			},
		};


		public static Dictionary<string,string> Samples
		{
			get
			{
				return samples;
			}
			set
			{
				samples = value;
			}
		}
	}
}
