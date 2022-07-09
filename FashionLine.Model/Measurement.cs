namespace FashionLine.Model
{
    public class Measurement : BaseEntity
    {
        public virtual float Neck { get; set; }
        public virtual float Shoulder { get; set;}
        public virtual float Waist { get; set;}
        public virtual float Hip { get; set;}
    }
}