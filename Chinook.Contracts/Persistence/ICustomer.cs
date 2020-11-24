using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface ICustomer : IIdentifiable
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Company { get; set; }
    }
}
