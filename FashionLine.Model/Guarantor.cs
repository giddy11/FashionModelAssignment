namespace FashionLine.Model
{
    public class Guarantor : BaseEntity
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set;}
        public virtual string? Address { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}