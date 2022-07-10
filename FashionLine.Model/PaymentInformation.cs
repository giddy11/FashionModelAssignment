namespace FashionLine.Model
{
    public class PaymentInformation : BaseEntity
    {
        public virtual decimal Price { get; set; }
        public virtual decimal AmountPaid { get; set; }
        public virtual decimal Balance { get; }
        public virtual Order? Order { get; set;}
    }
}