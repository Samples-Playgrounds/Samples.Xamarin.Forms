using System;
using System.Collections.Generic;

namespace HeartRate.Polar.HR7
{
	public interface IBluetoothLowEnergyService
	{
		List<BluetoothLowEnergyDevice> Devices
		{
			get;
		}
	}
}

