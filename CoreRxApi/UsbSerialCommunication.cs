using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.LibUsb;
using System.Collections.ObjectModel;
using System.IO.Ports;

namespace CoreRxApi
{
	public class UsbSerialCommunication
	{
		List<IUsbDevice> devices;

		public UsbSerialCommunication()
		{
			devices = new List<IUsbDevice>();
		}

		public void FindAllPorts()
		{
			using(UsbContext context = new UsbContext())
			{
				var allDevices = context.List();
				foreach(var device in allDevices)
				{
					switch(device.ProductId)
					{
						case 72:
						case 71:
							devices.Add(device); 
							break;
						default:
							break;
					}
				}

				foreach (var device in devices)
				{
					Console.WriteLine(device.Info.ToString());
					Console.WriteLine(device.LocationId);
				}
			}

			
		}
	}
}
