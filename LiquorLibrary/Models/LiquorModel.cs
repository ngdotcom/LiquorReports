using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquorLibrary.Models
{
    public class LiquorModel
    {
        // Invoice_Itemized.ItemNum, Invoice_Itemized.Quantity, Invoice_Itemized.CreateDate, Inventory.ItemName
        public string Quantity { get; set; }
        public string ItemName { get; set; }
        public string CreateStartDate { get; set; }
        public string CreateEndDate { get; set; }
    }
}
