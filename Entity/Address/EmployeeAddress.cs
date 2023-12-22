



using EfCoreRelation.Entity.Employees;

namespace EfCoreRelation.Entity.Address
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
      public Employee employee { get; set; }
        public List<PresentAddress> presentAddresses { get; set; }
        public List<ParmanentAddress> parmanentAddresses { get; set; }



    }
}
