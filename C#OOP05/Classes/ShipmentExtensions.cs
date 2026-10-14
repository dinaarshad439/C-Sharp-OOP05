using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP05.Classes
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} | {shipment.status}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
           return  shipment.status == "Is Delivered";

            
        }
    }
}
