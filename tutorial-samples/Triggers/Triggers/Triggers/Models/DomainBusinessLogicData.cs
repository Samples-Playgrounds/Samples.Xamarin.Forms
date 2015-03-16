using System;
using System.Collections.Generic;

namespace Triggers
{
	public class DomainBusinessLogicData
	{
		public DomainBusinessLogicData ()
		{
		}




		public static Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"Trigger Property", 
				"Triggers.Views.Xaml.PageTriggerProperty"
			},
			{ 
				"Trigger Property in Style", 
				"Triggers.Views.Xaml.PageTriggerProprtyDefinedWithStyle"
			},
			{ 
				"Trigger Data", 
				"Triggers.Views.Xaml.PageTriggerData"
			},
			{ 
				"Trigger Event", 
				"Triggers.Views.Xaml.PageTriggerEvent"
			},
			{ 
				"Trigger Event Multi", 
				"Triggers.Views.Xaml.PageTriggerMulti"
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
