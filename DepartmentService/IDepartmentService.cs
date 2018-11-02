using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace DepartmentService
{
    [ServiceContract]
    public  interface IDepartmentService
    {
        [OperationContract]
        DepartmentInfo GetDeptInfo(DepartmentRequest request);
    }
}
