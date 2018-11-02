using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DeptServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DepartmentService.DepartmentService)))
            {
                host.Open();
                Console.WriteLine("Department Service Host started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
