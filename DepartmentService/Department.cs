using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace DepartmentService
{
    [MessageContract(IsWrapped = true, WrapperName = "DepartmentRequestObject", WrapperNamespace = "http://MyCompany.Com/Department")]
    public class DepartmentRequest
    {
        [MessageHeader(Namespace = "http://MyCompany.Com/Department")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://MyCompany.Com/Department")]
        public string DepartmentName { get; set; }
    }
    #region Department
    [DataContract]
    public class Department
    {
        private string _gender;
        private string _name;
        private string _jobTitle;
        private DateTime _dateOfBirth;
        private int _vacationHour;
        private int _sickLeave;
        private int _entityID;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _entityID; }
            set { _entityID = value; }
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

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }
        [DataMember(Order = 6)]

        public int VacationHour
        {
            get { return _vacationHour; }
            set { _vacationHour = value; }
        }
        [DataMember(Order = 7)]

        public int SickLeave
        {
            get { return _sickLeave; }
            set { _sickLeave = value; }
        }
    }
    #endregion

    [MessageContract(IsWrapped = true, WrapperName = "DeptartmentInfoObject", WrapperNamespace = "http://MyCompany.Com/Department")]
    public class DepartmentInfo
    {
        #region deptInfo
        public DepartmentInfo()
        {

        }
        #endregion

        #region deptInfo Overload
        public DepartmentInfo(Department dept)
        {
            this.ID = dept.Id;
            this.Name = dept.Name;
            this.Gender = dept.Gender;
            this.DOB = dept.DateOfBirth;
            this.Vacation = dept.VacationHour;
            this.sickLeave = dept.SickLeave;
            this.jobTitle = dept.JobTitle;
        }
        #endregion

        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Department")]
        public int ID { get; set; }

        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Department")]
        public string Name { get; set; }

        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Department")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Department")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Department")]
        public int Vacation { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Department")]
        public int sickLeave { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Department")]
        public string jobTitle { get; set; }


    }
   
}
