using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public interface IDevice
    {
        int AddDevice(Device device);

        List<Device> GetDevicelist();


    }
}
