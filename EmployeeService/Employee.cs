using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace EmployeeService
{
    [MessageContract(IsWrapped =true,WrapperName ="EmployeeRequestObject",WrapperNamespace ="http://MyCompany.Com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://MyCompany.Com/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://MyCompany.Com/Employee")]
        public int EmployeeId { get; set; }

       
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://MyCompany.Com/Employee")]
    public class EmployeeInfo
    {

    #region EmployeeInfo
        public EmployeeInfo()
        {

        }
#endregion

    #region EmployeeInfo Overload
        public EmployeeInfo(Employee employee)
        {
            this.ID = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth;
            this.Type = employee.Type;
            if (this.Type == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;

            }
        }
        #endregion
        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Employee")]
        public int ID { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Employee")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Employee")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Employee")]
        public EmployeeType Type { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Employee")]
        public int AnnualSalary { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Employee")]
        public int HourlyPay { get; set; }

        [MessageBodyMember(Order = 8, Namespace = "http://MyCompany.com/Employee")]
        public int HoursWorked { get; set; }
    }


    #region Employee
    [DataContract]
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

       [DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Order = 3)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

       [DataMember(Order = 4)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }
    }
    #endregion

    #region EmployeeTypeEnum
    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
    #endregion

    
    

}