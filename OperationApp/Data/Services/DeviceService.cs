using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public class DeviceService : IDevice
    {
        private List<Device> devices = new List<Device>();
        public int AddDevice(Device device)
        {
            devices.Add(new Device
            {
                DeviceID = device.DeviceID,
                Name = device.Name,
                deviceType = device.deviceType
            });

            return devices.Select(x => x.DeviceID).FirstOrDefault();
        }

        public List<Device> GetDevicelist()
        {
            return devices;
        }
    }
}
