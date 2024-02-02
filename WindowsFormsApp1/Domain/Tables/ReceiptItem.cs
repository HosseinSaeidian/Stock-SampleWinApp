using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain.Core;

namespace WindowsFormsApp1.Domain.Tables
{
    public class ReceiptItem : Entity<int>
    {
        public int Quantity { get; set; }


        #region Relation

        public int ItemId { get; set; }
        public Item ItemNa { get; set; }


        public int ReceiptId { get; set; }
        public Receipt ReceiptNa { get; set; }


        #endregion

    }
}
