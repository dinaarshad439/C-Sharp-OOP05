

using C_OOP05.Interfaces;

namespace C_OOP05.Classes
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Insurance: {shipment.CalculateInsurance():0.00} EGP");
        }
    }
}
