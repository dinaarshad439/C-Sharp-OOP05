

using C_OOP05.Interfaces;
using C_OOP05.Struct;

namespace C_OOP05.Classes
{
    /// <summary>
    /// Represents a shipment with tracking, delivery, destination, and cost information.
    /// </summary>
    internal abstract class Shipment : ITrackable, IInsurable
    {
        #region Private Fields

        string? trackingCode;
        string? description;
        decimal weight;
        decimal deliveryFee;
        static int TotalShipmentsCreated=0;

        #endregion

        #region Properties

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;

            }
        }

        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            protected set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public abstract decimal EstimatedCost { get; }

        public string status { get; set; } = "ready";

        #endregion

        #region Constructor
        public Shipment(string _trackingCode)
        {
            TrackingCode = _trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
            TotalShipmentsCreated++;
        }

        public Shipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination, string _status)
        {
            TrackingCode = _trackingCode;
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
            Destination = _destination;
            status = _status;
            TotalShipmentsCreated++;
        }

        static Shipment()
        {
            Console.WriteLine("Shipment System Initialized");
        }

        #endregion

        #region Methods

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }


        public void Weight_Update(decimal newWeight)
        {

            if (newWeight > 0)
                Weight = newWeight;
        }

        public decimal Weight_Update(int newWeight)
        {
            if (newWeight > 0)
            {
                Weight += newWeight;
                return Weight;
            }

            return 0;
        }

        public abstract void PrintShipment();

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {status}.";
        }

        public abstract decimal CalculateInsurance();


        public Shipment CopyShipment()
        {
           
            return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, status);
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            
            Shipment deepCopyShipment = (Shipment)this.MemberwiseClone();

        
            if (this.Destination != null)
            {
                deepCopyShipment.Destination = new DeliveryAddress(
                    this.Destination.City,
                    this.Destination.Street,
                    this.Destination.BuildingNumber
                );
            }

            return deepCopyShipment;
        }
        #endregion

    }
}
