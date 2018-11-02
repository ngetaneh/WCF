using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentInfo GetDeptInfo(DepartmentRequest request)
        {
            Department department = null;
            string Constr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection cs = new SqlConnection(Constr))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeByDept", cs);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Name";
                parameterId.Value = request.DepartmentName;
                cmd.Parameters.Add(parameterId);
                cs.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
            }
            return new DepartmentInfo(department);
        }
        
       
    }
}
