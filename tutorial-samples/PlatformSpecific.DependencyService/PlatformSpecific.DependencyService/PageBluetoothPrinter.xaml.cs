using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformSpecific.DependencyService
{
	public partial class PageBluetoothPrinter
	{
		public PageBluetoothPrinter()
		{
			InitializeComponent();
		}


		private void Print (object sender, EventArgs ea)
		{
			// KUD Idijote:
			//		upali BT
			//		alo permissions
			IBluetoothPrinterService ibs = null;

			// get Registered service from Platform lib
			ibs = Xamarin.Forms.DependencyService.Get<IBluetoothPrinterService>();

			string data = 
					Environment.NewLine
					+
					Environment.NewLine
					+
					Environment.NewLine
					+
					entryData.Text
					+
					Environment.NewLine
					+
					Environment.NewLine
					+
					Environment.NewLine
					;

			ibs.Write(data);

			return;
		}
	}
}
