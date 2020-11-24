
using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Customer.csv")]
    internal class Customer : IdentityObject, Contracts.Persistence.ICustomer
    {
        [DataPropertyInfo(OrderPosition = 1)]
        public string FirstName { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]
        public string LastName { get; set; }
        [DataPropertyInfo(OrderPosition = 3)]
        public string Company { get; set; }
    }
}
