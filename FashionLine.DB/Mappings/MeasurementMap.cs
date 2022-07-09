using FashionLine.Model;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class MeasurementMap : BaseEntityMap<Measurement>
    {
        public MeasurementMap()
        {
            Map(measure => measure.Neck);
            Map(measure => measure.Shoulder);
            Map(measure => measure.Waist);
            Map(measure => measure.Hip);
        }
    }
}
