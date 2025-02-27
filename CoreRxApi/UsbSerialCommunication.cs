using LibUsbDotNet;
using LibUsbDotNet.LudnMonoLibUsb;
using System.IO.Ports;

namespace CoreRxApi
{
	public class UsbSerialCommunication
	{
		public UsbSerialCommunication()
		{

		}

		public void FindAllPorts()
		{
			UsbDevice.ForceLibUsbWinBack = true;

			var list = MonoUsbDevice.AllLibUsbDevices;
		}
	}
}
