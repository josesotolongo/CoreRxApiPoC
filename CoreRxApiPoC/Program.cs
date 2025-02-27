using CoreRxApi;

namespace CoreRxApiPoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
	        UsbSerialCommunication usbApi = new UsbSerialCommunication();
            usbApi.FindAllPorts();
        }
    }
}
