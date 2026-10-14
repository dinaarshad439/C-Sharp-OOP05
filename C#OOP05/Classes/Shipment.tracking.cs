using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP05.Classes
{
    internal abstract partial class Shipment
    {

        partial void OnTrackingStatusChanged(string newStatus);

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {status}.";
        }


        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                status = newStatus;

               
                OnTrackingStatusChanged(status);
            }
        }
    }
}
