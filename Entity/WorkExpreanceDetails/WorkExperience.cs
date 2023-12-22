using EfCoreRelation.Entity.Employees;

namespace EfCoreRelation.Entity.WorkExpreanceDetails
{
    public class WorkExperience
    {
        public int Id { get; set; }
      
        public string Post { get; set; }
        public string Organization { get; set; }
        public string JobLocation { get; set; }
        public int Selary { get; set; }
        public string ReportingTo { get; set; }
        public string DefaultProduct { get; set; }

        //fk
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

    }
}
