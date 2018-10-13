using System;
using Android;
using Android.Bluetooth;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolisticWare.HardWareBluetooth.XamarinAndroid
{
	public partial class BluetoothLowEnergy
	{
		public List<Robotics.Mobile.Core.Bluetooth.LE.IDevice> Devices = null;
		public BluetoothDevice BluetoothDevicePolarHR7 = null;

		public BluetoothLowEnergy()
		{
			Robotics.Mobile.Core.Bluetooth.LE.Adapter adapter = null;

			adapter = new Robotics.Mobile.Core.Bluetooth.LE.Adapter();
			adapter.DeviceDiscovered += HandleDeviceDiscovered;
			adapter.StartScanningForDevices();


			return;
		}

		void HandleDeviceDiscovered (object sender, Robotics.Mobile.Core.Bluetooth.LE.DeviceDiscoveredEventArgs e)
		{
			if (null == Devices)
			{
				Devices = new List<Robotics.Mobile.Core.Bluetooth.LE.IDevice> ();
			}

			Devices.Add (e.Device);

			if (e.Device.Name == "")
			{

			}
			return;
		}
	}
}
