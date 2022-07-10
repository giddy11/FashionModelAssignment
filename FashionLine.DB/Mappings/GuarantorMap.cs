using FashionLine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Mappings
{
    public class GuarantorMap : BaseEntityMap<Guarantor>
    {
        public GuarantorMap()
        {
            Map(guarantor => guarantor.FirstName);
            Map(guarantor => guarantor.LastName);
            Map(guarantor => guarantor.Address);
            Map(guarantor => guarantor.PhoneNumber);
            HasOne(guarantor => guarantor.Employee).PropertyRef(employe => employe.Guarantor);
        }
    }
}
