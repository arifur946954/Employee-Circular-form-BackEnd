using EfCoreRelation.Entity.AccademicQualificationDetails;
using EfCoreRelation.Entity.Address;
using EfCoreRelation.Entity.WorkExpreanceDetails;

namespace EfCoreRelation.Entity.Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }

        public string Name { get; set; }
        public string FatherName { get; set; }

        public string MotherName { get; set; }
        public string Nid { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthPlace { get; set; }

        public string Religion { get; set; }
        public string BloodGroup { get; set; }

        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public List<EmployeeAddress> employeeAddresses { get; set; }


        public DateTime InterviewDare { get; set; }
        public string AppliedPost { get; set; }
        public DateTime JoiningDate { get; set; }
        public int ExpectedSelary { get; set; }


        public string AppliedBy { get; set; }
        public List<AccademicQualification> accademicQualifications { get; set; }
        public List<WorkExperience> workExperiences { get; set; }
    }
}
