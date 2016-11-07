using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDemo.Models
{
    class InventoryViewModel
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public int Prices { get; set; }
        public DateTime ExpDate { get; set; }

    }
}
