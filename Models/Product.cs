using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Product
    {
        #region properties
        public int ProductId {  get; set; }
        public string? Name { get; set; }
        public int Quantity {  get; set; }
        public decimal Price {  get; set; }
        public string? Description { get; set; }
        #endregion
        #region Navigation
        public ICollection<Sales>? Sales { get; set; }
        #endregion
    }
}
