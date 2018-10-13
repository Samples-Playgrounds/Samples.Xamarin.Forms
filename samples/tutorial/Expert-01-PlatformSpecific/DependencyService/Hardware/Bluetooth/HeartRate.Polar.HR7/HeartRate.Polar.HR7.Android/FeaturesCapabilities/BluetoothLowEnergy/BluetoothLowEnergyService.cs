using System;
using System.Collections.Generic;

using HeartRate.Polar.HR7;

[assembly:Xamarin.Forms.Dependency(typeof(BluetoothLowEnergyService))]
namespace HeartRate.Polar.HR7
{
	public class BluetoothLowEnergyService : IBluetoothLowEnergyService
	{
		Robotics.Mobile.Core.Bluetooth.LE.Adapter Adapter = null;

		public BluetoothLowEnergyService ()
		{
			Adapter = new Robotics.Mobile.Core.Bluetooth.LE.Adapter();
			Adapter.StartScanningForDevices();

			Adapter.ScanTimeoutElapsed += HandleScanTimeoutElapsed;
			Adapter.DeviceDiscovered += HandleDeviceDiscovered;
			Adapter.DeviceConnected += HandleDeviceConnected;

			return;
		}

		private void HandleScanTimeoutElapsed (object sender, EventArgs e)
		{
			//Adapter.StartScanningForDevices();

			return;			
		}

		private void HandleDeviceDiscovered (object sender, Robotics.Mobile.Core.Bluetooth.LE.DeviceDiscoveredEventArgs e)
		{
			Robotics.Mobile.Core.Bluetooth.LE.IDevice device = e.Device;

			Adapter.ConnectToDevice(device);

			return;			
		}

		private void HandleDeviceConnected (object sender, Robotics.Mobile.Core.Bluetooth.LE.DeviceConnectionEventArgs e)
		{
			Robotics.Mobile.Core.Bluetooth.LE.IDevice device = e.Device;

			return;			
		}

		public List<BluetoothLowEnergyDevice> Devices
		{
			get
			{
				return GetDevices();
			}
		}

		public List<BluetoothLowEnergyDevice> GetDevices()
		{
			List<BluetoothLowEnergyDevice> devices = new List<BluetoothLowEnergyDevice>();


			return devices;
		}
	}
}

