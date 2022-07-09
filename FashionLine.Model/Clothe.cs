using FashionLine.Model.Enums;

namespace FashionLine.Model
{
    public class Clothe
    {
        public virtual Measurement? Measurement { get; set; }
        public virtual ClotheType ClotheType { get; set; }
        public virtual Order? Order { get; set; }
    }
}