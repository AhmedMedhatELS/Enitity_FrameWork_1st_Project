using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    /*
     * Assume relations is one to many 
     * sales is the many side for the 3 relations
     */
    public class Sales
    {
        #region properties
        public int SalesId { get; set; }
        public DateTime Date { get; set; }
        #endregion
        #region ForeignKey
        public int CustomersId { get; set; }
        public Customers? customers { get; set; }
        public int StoresId { get; set; }
        public Stores? Stores { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        #endregion
    }
}
