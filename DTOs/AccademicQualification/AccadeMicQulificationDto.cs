using EfCoreRelation.Entity.AccademicQualificationDetails;

namespace EfCoreRelation.DTOs.AccademicQualification
{
    public class AccadeMicQulificationDto
    {
        public string Degree { get; set; }
        public string University { get; set; }
        public string Instution { get; set; }
        public string Major { get; set; }
        public double Result { get; set; }
        public string PassingYear { get; set; }


        //fk
        public int EmployeeId { get; set; }
    }
}
