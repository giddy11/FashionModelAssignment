// See https://aka.ms/new-console-template for more information

using FashionLine.DB;
using FashionLine.DB.Repositories;
using FashionLine.Model;

Console.WriteLine("Hello, World!");

FluentNHibernateHelper.OpenSession();
var fashionLineRepo = new FashionBusinessLineRepository();
var employeeRepo = new EmployeeRepository();
var customerRepo = new CustomerRepository();
var customers = new List<Customer>();



#region FASHIONLINE
var fashion1 = new FashionBusinessLine() { 
    Name = "Chinedu Clothes limited", 
    Location = "Bayelsa3", 
    Customers = new List<Customer>(), 
    Employees = new List<Employee>()
};

//fashionLineRepo.Add(fashion1);
#endregion

#region EMPLOYEES
var employee1 = new Employee()
{
    FirstName = "Etim",
    LastName = "Archibong",
    EmployeeRole = FashionLine.Model.Enums.Role.Manager,
    Location = "Bayelsa4",
    PhoneNumber = "08054789857",
    Guarantor = new Guarantor() { FirstName = "Mrs. Mary", LastName = "Odili", Address = "Pail avae", PhoneNumber = "08027519975" }
};

var employee2 = new Employee()
{
    FirstName = "Racal",
    LastName = "Arc",
    EmployeeRole = FashionLine.Model.Enums.Role.Accountant,
    Location = "Bayelsa5",
    PhoneNumber = "08053789857", 
    Guarantor = new Guarantor() { FirstName = "Mr. Chinedu", LastName = "Godswill", Address = "Main wen", PhoneNumber = "08024789975" }
};

var employee3 = new Employee()
{
    FirstName = "Richard",
    LastName = "Mercy",
    EmployeeRole = FashionLine.Model.Enums.Role.DeliveryMan,
    Location = "Bayelsa6",
    PhoneNumber = "08011789857",
    Guarantor = new Guarantor() { FirstName = "Mr. Peter", LastName = "Elijah", Address = "Ndidi", PhoneNumber = "08124789975" }
};

employeeRepo.Add(employee1);
employeeRepo.Add(employee2);
employeeRepo.Add(employee3);
#endregion


#region CUSTOMERS

var customer1 = new Customer() { FirstName = "Gideon", LastName = "Edoghotu", Location = "Bayelsa", PhoneNumber = "08037063820" };
var customer2 = new Customer() { FirstName = "Dozie", LastName = "Peter", Location = "Bayelsa1", PhoneNumber = "08038063820" };

customers = new List<Customer>() { customer1, customer2 };

foreach (var item in customers)
{
    customerRepo.Add(item);
}
#endregion


Console.ReadLine();