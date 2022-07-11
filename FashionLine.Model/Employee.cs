using FashionLine.Model.Enums;

namespace FashionLine.Model
{
    public class Employee : BaseEntity
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set;}
        public virtual string? Location { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual Guarantor? Guarantor { get; set; }
        public virtual Role EmployeeRole { get; set; }
    }
}