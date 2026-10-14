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

            #endregion
        }
    }
}
