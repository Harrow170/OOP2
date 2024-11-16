﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2.Model.Enums;

namespace OOP2.Model.Orders
{
    /// <summary>
    /// Holds data of priority order.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// gets and sets the delivery date.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// gets and sets the delivery date.
        /// </summary>
        public OrderTime DeliveryTime { get; set; }


        /// <summary>
        /// Creates a sample of an inhereted class PriorityOrder.
        /// /// <param name="status">Order status.</param>
        /// <param name="address">Address.</param>
        /// <param name="items">Items of the order.</param>
        /// <param name="deliveryDate">Delivery date.</param>
        /// /// <param name="deliveryDate">Delivery time.</param>
        /// </summary>
        public PriorityOrder(
            Address address,
            List<Item> items,
            DateTime deliveryDate,
            OrderTime deliveryTime, double discountAmount
            ) : base(address, items, discountAmount)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }


        /// <summary>
        /// Creates a sample of an inhereted class PriorityOrder.
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now;
            DeliveryTime = OrderTime.f9t11;
        }

    }
}