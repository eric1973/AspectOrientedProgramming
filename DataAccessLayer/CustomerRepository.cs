using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class CustomerRepository : IRepository<ICustomer>
    {

        public bool Create(ICustomer entity)
        {
            return this.Save(entity.firstName, entity.lastName, entity.streetAddress, entity.city);
        }

        IEnumerable<ICustomer> IRepository<ICustomer>.Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(ICustomer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ICustomer entity)
        {
            throw new NotImplementedException();
        }

        [Log]
        private bool Save(string firstName, string lastName, string streetAddress, string city)
        {
            //TODO Save that entity
            Console.WriteLine("See log entry in Debug->Windows->Output");
            return true;
        }
    }
}
