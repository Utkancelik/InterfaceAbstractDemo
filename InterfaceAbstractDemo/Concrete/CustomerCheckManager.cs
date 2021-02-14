using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager:ICustomerCheckPerson
    {
        bool ICustomerCheckPerson.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
