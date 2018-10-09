using System;
using System.Linq;
using System.Diagnostics;


using Windows.Networking.Sockets;
using Windows.Networking.Proximity;


using PlatformSpecific.DependencyService.FeaturesCapabilities.Logging;
using PlatformSpecific.DependencyService.FeaturesCapabilities.Bluetooth;

using PlatformSpecific.DependencyService.FeaturesCapabilities.Logging.WindowsPhone;
using PlatformSpecific.DependencyService.FeaturesCapabilities.Bluetooth.WindowsPhone;
using System.Collections.Generic;

[assembly:Xamarin.Forms.Dependency(typeof(BluetoothPrinterService))]

namespace PlatformSpecific.DependencyService.FeaturesCapabilities.Bluetooth.WindowsPhone
{
	/// <summary>
	/// 
	/// 
	///		1.	Bluetooth
	///			1.	Turn On
	///				1.	Settings +/ Bluetooth +/ Switch = On
	///				2.	In the list "Accessory" appears
	///				3.	Tap
	///				4.	Pair Qsprinter
	///					1.	Enter Password
	///					
	///				
	/// </summary>
	/// <see cref="http://msdn.microsoft.com/en-us/library/windows/apps/jj207007(v=vs.105).aspx"/>
	/// <see cref="http://www.windowsphone.com/en-us/how-to/wp8/connectivity/bluetooth-faq"/>
	/// <see cref="http://developer.nokia.com/community/wiki/Introduction_to_Bluetooth_support_on_Windows_Phone_8"/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	/// <see cref=""/>
	public partial class BluetoothPrinterService : IBluetoothPrinterService
	{ 
		LoggerService LoggerService = null;


		public BluetoothPrinterService ()
		{
			PeerFinder.ConnectionRequested += PeerFinder_ConnectionRequested;

			AppToDevice();

			return;	
		}

		private void PeerFinder_ConnectionRequested(object sender, ConnectionRequestedEventArgs args)
		{
			if (ShouldConnect())
			{
				// Go ahead and connect
				ConnectToPeer(args.PeerInformation);
			}

			return;
		}

		async void ConnectToPeer(PeerInformation peer)
		{
			StreamSocket socket = await PeerFinder.ConnectAsync(peer);
			DoSomethingUseful(socket);

		}

		private void DoSomethingUseful(StreamSocket socket)
		{
			//socket.InputStream.ReadAsync()
		}

		private bool ShouldConnect()
		{
			// Determine whether to accept this connection request and return
			return true;
		}

		public string Read ()
		{
			return "";
		}

		public string ReadAsync ()
		{
			return "";
		}

		public void Write (string data)
		{

			return;
		}

		public void WriteAsync (string data)
		{
			return;
		}

		// Connect to a device
		// To connect to a device over Bluetooth, the device must first be paired with the
		// phone on which your app is running. User can discover paired devices using 
		// PeerFinder.FindAllPeersAsync. User can set the PeerFinder.AlternateIdentities with 
		// one of the key-value pairs in the following table:
		//
		//	PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
		//		Enumerate all paired devices. The PeerInformation.ServiceName will be 
		//		empty in this case. For many devices, the Bluetooth port over which to 
		//		communicate is hard coded, so you can use that directly in the ConnectAsync 
		//		call. If the device is advertising a service, then you can enumerate using 
		//		the paired option but call ConnectAsync with the GUID of the service you want to use. 
		//	
		//	PeerFinder.AlternateIdentities["Bluetooth:SDP"] = "<SDP service guid>";
		//		Find devices using the Service discovery protocol (SDP) that are advertising 
		//		a service with the given GUID. If any devices are found, the 
		//		PeerInformation.ServiceName will be equal to the GUID you specified.
		//
		//
		// Issue
		//		Bluetooth peer-to-peer (P2P) advertisement isn’t enabled if you start, 
		//		stop, and then restart PeerFinder.
		// Workaround
		//		Send your app to the background and then bring it to the foreground.
		//
		// Issue
		//		Bluetooth cannot be tested using Windows Phone Emulator.
		// Workaround
		//		Test Bluetooth using a Windows Phone 8 device.
		//
		// Note: You can only browse and connect to paired devices!
		private async void AppToDevice()
		{
			// Configure PeerFinder to search for all paired devices.
			PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";
			
			IReadOnlyList<PeerInformation> devices_paired = null;
			try 
			{
				devices_paired = await PeerFinder.FindAllPeersAsync();
			}
			catch(System.Exception exc)
			{
				// exc = {System.Exception: The device is not connected. 
				// (Exception from HRESULT: 0x8007048F)
				//		at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
				//		at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(...
				string msg = exc.Message;
			}

			if (devices_paired.Count == 0)
			{
				Debug.WriteLine("No paired devices were found.");
			}
			else
			{
				// Select a paired device. In this example, just pick the first one.
				PeerInformation selectedDevice = devices_paired[0];
				// Attempt a connection
				StreamSocket socket = new StreamSocket();
				// Make sure ID_CAP_NETWORKING is enabled in your WMAppManifest.xml, or the next 
				// line will throw an Access Denied exception.
				// In this example, the second parameter of the call to ConnectAsync() is the RFCOMM port number, and can range 
				// in value from 1 to 30.
				await socket.ConnectAsync(selectedDevice.HostName, "1");
				DoSomethingUseful(socket);
			}

			return;
		}

		private async void FindPaired()
		{

			// Search for all paired devices
			PeerFinder.AlternateIdentities["Bluetooth:Paired"] = "";

			try
			{
				var peers = await PeerFinder.FindAllPeersAsync();

				// Handle the result of the FindAllPeersAsync call
			}
			catch (Exception ex)
			{
				if ((uint)ex.HResult == 0x8007048F)
				{
					System.Diagnostics.Debug.WriteLine("Bluetooth is turned off");
				}
			}
		}
	}
}

