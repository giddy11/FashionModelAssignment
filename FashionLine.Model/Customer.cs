namespace FashionLine.Model
{
    public class Customer : BaseEntity
    {
        public virtual string? FirstName { get; set; }
        public virtual string? LastName { get; set; }
        public virtual string? Location { get; set; }
        public virtual string? PhoneNumber { get; set; }
        public virtual List<Order>? Orders { get; set; }
    }
}