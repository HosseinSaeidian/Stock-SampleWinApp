using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Domain.Tables
{
    public class DeliveryItems
    {
        public int Quantity { get; set; }


        #region Relation

        public int ItemId { get; set; }
        public Item ItemNa { get; set; }


        public int DeliveryId { get; set; }
        public Delivery DeliveryNa { get; set; }


        #endregion

    }
}
