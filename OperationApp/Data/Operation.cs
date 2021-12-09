using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public class Operation
    {
        public int OperationID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public int OrderInWhichToPerson { get; set; }

        public byte[] ImageData { get; set; }

        [Required]
        public Device device { get; set; }
    }

}
