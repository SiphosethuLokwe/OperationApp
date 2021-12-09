using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public class OperationService : IOperationService
    {
        private static Random rnd = new Random();
        
        private List<Operation> operation = new List<Operation>
        {
            new Operation
            {
                OperationID = rnd.Next(1,20),
                Name= $"Step 1"                      
            },
        };
        private List<Device> dev = new List<Device>();

        public void AddOperation(Operation operationstep)
        {
            operation.Add(new Operation
            {
                OperationID = rnd.Next(1, 20),
                Name = operationstep.Name,
                OrderInWhichToPerson = operationstep.OrderInWhichToPerson,
                ImageData = operationstep.ImageData,
                device = operationstep.device
            }); 
        }

        public List<Operation> GetOperationlist()
        {
            return operation;
        }

        public void RemoveOperation(int operationId)
        {
            operation.RemoveAll(x => x.OperationID == operationId);
        }
    }
}
