using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    public class Stores
    {
        #region properties
        public int StoresId { get; set; }
        public string? Name { get; set; }
        #endregion
        #region Navigation
        public ICollection<Sales>? Sales { get; set; }
        #endregion
    }
}
