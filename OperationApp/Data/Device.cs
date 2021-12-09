using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public class Device
    {
        public int DeviceID { get; set; }

        [Required]
        public string Name { get; set; }
        public DeviceType deviceType {get;set;}
    }
}
