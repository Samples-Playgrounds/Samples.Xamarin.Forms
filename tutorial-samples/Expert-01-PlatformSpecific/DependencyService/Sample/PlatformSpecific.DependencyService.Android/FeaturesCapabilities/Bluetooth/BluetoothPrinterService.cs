using System;
using System.Linq;

using Android.Content;


using HolisticWare.Mobile.Logging;
using HolisticWare.Mobile.Bluetooth;

using HolisticWare.Mobile.Logging.XamarinAndroid;
using HolisticWare.Mobile.Bluetooth.XamarinAndroid;

[assembly:Xamarin.Forms.Dependency(typeof(BluetoothPrinterService))]

namespace HolisticWare.Mobile.Bluetooth.XamarinAndroid
{
	public partial class BluetoothPrinterService : IBluetoothPrinterService
	{ 
		LoggerService LoggerService = null;

		Android.Bluetooth.BluetoothSocket _socket = null;

		public BluetoothPrinterService ()
		{
			
			Android.Bluetooth.BluetoothAdapter ba = null;
			try
			{
				ba = Android.Bluetooth.BluetoothAdapter.DefaultAdapter;
			}
			catch (Exception exc)
			{
				string msg = "if this fails - AndroidManifest.xml";
				LoggerService.WriteLine (msg);
			}

			if (ba == null)
			{
				LoggerService.WriteLine ("BluetoothAdapter == null");
				return;
			}

			if (!ba.IsEnabled)
			{
				LoggerService.WriteLine ("Bluetooth adapter is not enabled.");
			}

			foreach (var bd in ba.BondedDevices)
			{
				LoggerService.WriteLine (bd.Name);
			}
			string device_name = "Qsprinter";
			Android.Bluetooth.BluetoothDevice device = 
				(
				    from bd in ba.BondedDevices
				    where bd.Name == device_name
				    select bd
				).FirstOrDefault ();

			if (device == null)
			{
				LoggerService.WriteLine ("Bluetooth device not found = " + device_name);
			}

			Android.OS.ParcelUuid[] uuids = device.GetUuids ();
			string uuid = 
				uuids[0].ToString()
				//Guid.NewGuid().ToString()
				;

			_socket = device
						.CreateInsecureRfcommSocketToServiceRecord(Java.Util.UUID.FromString (uuid))
						//.CreateRfcommSocketToServiceRecord (Java.Util.UUID.FromString (uuid))
						;


			try
			{
				_socket.Connect();
				if(_socket.IsConnected)
				{
					LoggerService.WriteLine ("Bluetooth socket connected ");
				}
			}
			catch (Exception exc)
			{
//			[BluetoothUtils] isSocketAllowedBySecurityPolicy start : device null
//			[BluetoothSocket] GlobalConfig.GLOBALCONFIG_BT_IT_POLICY_FEATURE = true
//			[BluetoothAdapter] getBluetoothService() called with no BluetoothManagerCallback
//			[BluetoothSocket] connect(), SocketState: INIT, mPfd: {ParcelFileDescriptor: FileDescriptor[78]}
			}

			byte[] data_bytes = System.Text.Encoding.UTF8.GetBytes ("Bluetooth created");

			// Write data to the device
			//await 
			try
			{
				_socket.OutputStream.WriteAsync (data_bytes, 0, data_bytes.Length);
			}
			catch (Exception exc)
			{
			}

			return;	
		}


		byte[] buffer = new byte[1024];

		public string Read ()
		{
			// Read data from the device
			//await 
			_socket.InputStream.ReadAsync (buffer, 0, buffer.Length);

			return "";
		}

		public string ReadAsync ()
		{
			// Read data from the device
			//await 
			_socket.InputStream.ReadAsync (buffer, 0, buffer.Length);

			return "";
		}

		public void Write (string data)
		{
			LoggerService.WriteLine ("Android Bluetooth write fired = ");


			byte[] data_bytes = System.Text.Encoding.UTF8.GetBytes (data);

			// Write data to the device
			//await 
			try
			{
				_socket.OutputStream.WriteAsync (data_bytes, 0, data_bytes.Length);
			}
			catch (Exception exc)
			{
			}

			return;
		}

		public void WriteAsync (string data)
		{
			LoggerService.WriteLine ("Android Bluetooth write fired = ");

			byte[] data_bytes = System.Text.Encoding.UTF8.GetBytes (data);

			// Write data to the device
			//await 
			_socket.OutputStream.WriteAsync(data_bytes, 0, data_bytes.Length);


			// [BluetoothUtils] isSocketAllowedBySecurityPolicy start : device null
			return;
		}
	}
}

