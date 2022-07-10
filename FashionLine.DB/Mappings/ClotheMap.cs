using FashionLine.Model;
using FashionLine.Model.Enums;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class ClotheMap : BaseEntityMap<Clothe>
    {
        public ClotheMap()
        {
            References(cloth => cloth.Measurement);
            References(cloth => cloth.Order);
            Map(cloth => cloth.ClotheType).CustomType<ClotheType>();
        }
    }
}
