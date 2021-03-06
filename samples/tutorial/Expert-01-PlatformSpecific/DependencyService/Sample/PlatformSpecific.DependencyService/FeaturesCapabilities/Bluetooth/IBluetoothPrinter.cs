﻿using System;
using System.Collections.Generic;

namespace HolisticWare.Mobile.Bluetooth
{
	public interface IBluetoothPrinterService
	{
		string Read();

		string ReadAsync();

		void Write(string data);

		void WriteAsync(string data);
	}
}
