using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain.Core;

namespace WindowsFormsApp1.Domain.Tables
{
    public class Item : Entity<int>
    {
        public int Code { get; set; }
        public string Name { get; set; }


        #region Relation

        public List<DeliveryItems> DeliveryItemsNa { get; set; }
        public List<ReceiptItem> ReceiptItemNa { get; set; }

        #endregion
    }
}
