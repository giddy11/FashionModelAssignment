using FashionLine.Model;
using FashionLine.Model.Enums;
using FluentNHibernate.Mapping;

namespace FashionLine.DB.Mappings
{
    public class EmployeeMap:BaseEntityMap<Employee>
    {
        public EmployeeMap()
        {
            Map(employ => employ.FirstName);
            Map(employ => employ.LastName);
            Map(employ => employ.Location);
            Map(employ => employ.PhoneNumber);
            //References(employee => employee.Guarantor);
            HasOne(employ => employ.Guarantor);
            Map(employ => employ.EmployeeRole).CustomType<Role>();
        }
    }
}
