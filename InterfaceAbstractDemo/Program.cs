using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Utkan",
                LastName = "Çelik",
                DateOfBirth = new DateTime(2000,1,28),
                NationalityId = "20017949024",
            });
        }
    }
}
