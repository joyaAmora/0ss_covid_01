using System.Collections.Generic;

namespace BillingManagement.Models
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
