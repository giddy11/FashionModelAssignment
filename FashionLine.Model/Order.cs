namespace FashionLine.Model
{
    public class Order : BaseEntity
    {

        //public Order()
        //{
        //    Clothes = new List<Clothe>();
        //    DeliveryAddress = Owner.Location;
        //}
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual List<Clothe>? Clothes { get; set; }
        public virtual Customer? Customer { get; set; }
        //public virtual Customer Owner { get; set; }
        public virtual PaymentInformation? PaymentInfo { get; set; }
        public virtual string DeliveryAddress { get; set; }

    }
}