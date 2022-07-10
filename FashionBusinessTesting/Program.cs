// See https://aka.ms/new-console-template for more information

using FashionLine.DB;
using FashionLine.DB.Repositories;
using FashionLine.Model;

Console.WriteLine("Hello, World!");

FluentNHibernateHelper.OpenSession();
var customerRepo = new CustomerRepository();

var customer1 = new Customer() { FirstName = "Gideon", LastName = "Edoghotu", Location = "Bayelsa", PhoneNumber = "08037063820" };

customerRepo.Add(customer1);






Console.ReadLine();