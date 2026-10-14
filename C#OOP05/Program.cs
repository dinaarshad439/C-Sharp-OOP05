using C_OOP05.Classes;
using C_OOP05.Struct;

namespace C_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Therotical Questions

            #region (Q1) Object Copying

            // (a)
            /*
             * When you assign one object variable to another only the reference is copied not the actual object data.
             */

            // (b)
            /*
             * No, it does not create a new object.
             * because Both variables point to the same object in memory
             */

            //(c)
            /*
             * Copying a reference: Both variables point to the same object in memory, Any modification made through one variable affects the other.
             * Copying an object: Creates a brand new object in memory with its own distinct reference.
             */

            #endregion

            #region (Q2) Shallow vs Deep Copies

            // (a)
            /*
             * Create new object that copies value types and  for reference type fields only reference is copied
             */

            // (b)
            /*
             *  create new object that copies all nested objects so the original object and copyied object are independent.
             */

            //(c)
            /*
             * the original object and the shallow copy point to the exact same inner objects in memory
             */

            //(d)
            /*
             * the original object and the deep copy do not share any reference-type members, making them completely independent.
             */

            //(e)
            /*
             * A deep copy is much safer when you have a composite object containing mutable reference types
             * If you modify the items list or the address in the copied object, a shallow copy would accidentally modify the original object's data too
             */

            #endregion

            #region (Q3) Static Members

            // (a)
            /*
             * Static Field: Belongs to the class itself rather than any specific object
             * there is only one copy of a static field shared across all instances.
             * 
             * Instance Field: Belongs to a specific object instance Every time you create a new object using the new keyword 
             * a new copy of the instance field is allocated in memory for that specific object.
             */

            // (b)
            /*
             * Static Method: A method that belongs to the class itself and can be called without creating Object of the class.
             * No, not directly. Because static methods Can be called without creating object.
             */

            // (c)
            /*
             * Static Constructor: A special constructor used to initialize static fields and cannot have access modifer.
             * It runs once automatically before any static member is used.
             */

            // (d)
            /*
             * Static class: class cannot create object from it and contaion only static members.
             * No, You cannot create object from it.
             */

            #endregion

            #region (Q4) Extension Methods

            // (a)
            /*
             * Add new method to existing types without modifying original class or creating new class.
             */

            //(b)
            /*
             * First parameter must use this keyword.
             */

            // (c)
            /*
             * It must be declared as a static method inside a static class.
             */

            //(d)
            /*
             * No, it cannot access private members because they are not part of type.
             */
            #endregion

            #region (Q5) Partial Classes and Partial Methods 

            // (a)
            /*
             * Allow you to divide class into multiple files complemented to each other and seen by compiler as one class.
             */

            // (b)
            /*
             * 1) to organize large classes into multiple files.
             * 2)to improve maintainability and readability.
             * 3) to separate auto generated code from custom code.
             */

            // (c)
            /*
             * declare method without implementation in the class so it may be implemented in another class.
             */

            // (d)
            /*
             * if you dont implement partial method the compiler will remove it.
             */
            #endregion

            #endregion

            #region Practical Questions


            #region (Q1) Object Copying

            

            Shipment shipment1 = new StandardShipment("SH001", "Standard", 3, 5,new DeliveryAddress("Cairo","Maadi",10), "In Transit");

            
            Shipment shipment2 = shipment1;

            //Shipment copiedShipment = shipment1.CopyShipment();


            //bool isSameObject = (shipment1 == shipment2);
            //Console.WriteLine($"Same Object (Reference Assignment): {isSameObject}"); 


            //bool isSameCopy = (shipment1 == copiedShipment);
            //Console.WriteLine($"Same Object (CopyShipment): {isSameCopy}"); 

            #endregion


            #region (Q2) Shallow Copy

            
            Shipment shallowCopied = shipment1.ShallowCopy();

            Console.WriteLine("------------ Before Changes ------------");
            Console.WriteLine($"shipment1 (Original) Hash: {shipment1.GetHashCode()} | City: {shipment1.Destination.City}");
            Console.WriteLine($"shipment2 (Assigned) Hash: {shipment2.GetHashCode()} | City: {shipment2.Destination.City}");
            Console.WriteLine($"shallowCopied Hash     : {shallowCopied.GetHashCode()} | City: {shallowCopied.Destination.City}");

         
            Console.WriteLine("\n------------ After Changing shallowCopied Address ------------");
            shallowCopied.Destination.City = "Giza";

            Console.WriteLine($"shipment1 (Original) City: {shipment1.Destination.City}"); 
            Console.WriteLine($"shallowCopied City     : {shallowCopied.Destination.City}");

            
            Console.WriteLine($"Same Shipment Object (shipment1 vs shallowCopied): {ReferenceEquals(shipment1, shallowCopied)}");

           
            Console.WriteLine($"Same DeliveryAddress Object: {ReferenceEquals(shipment1.Destination, shallowCopied.Destination)}");


            #endregion

            #endregion
        }
    }
}
