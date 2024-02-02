using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain.Core;

namespace WindowsFormsApp1.Domain.Tables
{
    public class Delivery : Entity<int>
    {
        public DateTime DateTime { get; set; }


        #region Relation

        public int StockId { get; set; }
        public Stock StockNa { get; set; }


        public DeliveryItems DeliveryItemNa { get; set; }

        #endregion


    }
}
