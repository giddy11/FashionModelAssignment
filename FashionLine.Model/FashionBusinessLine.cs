﻿namespace FashionLine.Model
{
    
    public class FashionBusinessLine : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual string? Location { get; set; }
        public virtual IList<Employee>? Employees { get; set; }
        public virtual IList<Customer>? Customers { get; set; }
        public virtual List<Clothe>? ClotheInventory { get; set; }
    }
}