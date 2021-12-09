using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationApp.Data
{
    public interface IOperationService
    {
        
        List<Operation> GetOperationlist();
        void RemoveOperation(int operationId);
        void AddOperation(Operation operation);
    }
}
