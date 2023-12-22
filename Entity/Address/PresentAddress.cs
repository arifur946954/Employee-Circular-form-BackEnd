namespace EfCoreRelation.Entity.Address
{
    public class PresentAddress
    {
        public int Id { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string PoliceStation { get; set; }
        public string District { get; set; }
        public int EmployeeAddressId { get; set; }
        public EmployeeAddress employeeAddress { get; set; }
    }
}
