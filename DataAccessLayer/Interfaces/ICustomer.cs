using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ICustomer : IEntity
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string streetAddress { get; set; }
        string city { get; set; }
    }
}
