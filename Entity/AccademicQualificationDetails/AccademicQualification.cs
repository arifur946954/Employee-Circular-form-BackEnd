using EfCoreRelation.Entity.Employees;

namespace EfCoreRelation.Entity.AccademicQualificationDetails
{
    public class AccademicQualification
    {
        public int Id { get; set; }
        

        public string Degree { get; set; }
        public string University { get; set; }
        public string Instution { get; set; }
        public string Major { get; set; }
        public double Result { get; set; }
        public string PassingYear { get; set; }


        //fk
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

    }
}
