using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DepartmentServiceHost
{
    class prog
    {
        static void Main(string[] args)
        {
            using (ServiceHost host2 = new ServiceHost(typeof(DepartmentService.DepartmentService)))
            {
                host2.Open();
                Console.WriteLine("Department Service Host started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
