using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckPerson _customerCheckPerson;

        public StarbucksCustomerManager(ICustomerCheckPerson customerCheckPerson)
        {
            _customerCheckPerson = customerCheckPerson;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckPerson.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}
