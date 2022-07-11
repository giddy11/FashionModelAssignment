using FashionLine.Model;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class FashionBusinessLineMap : BaseEntityMap<FashionBusinessLine>
    {
        public FashionBusinessLineMap()
        {
            Map(fash => fash.Name);
            Map(fash => fash.Location);
            HasMany(fash => fash.Employees);
            HasManyToMany(fash => fash.Customers);
            HasMany(fash => fash.ClotheInventory);
        }
    }
}
