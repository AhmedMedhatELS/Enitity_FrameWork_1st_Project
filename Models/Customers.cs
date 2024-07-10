using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Customers
    {
        #region properties
        public int CustomersId {  get; set; }
        public string? Name { get; set;}
        public string? Email {  get; set;}
        public string? CreadiCardNumber {  get; set;}
        #endregion
        #region Navigation
        public ICollection<Sales>? Sales { get; set; }
        #endregion
    }
}
