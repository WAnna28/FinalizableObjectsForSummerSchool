using System;

// // System.Object
// public class Object
// {
// ...
//  protected virtual void Finalize() { }
// }

// The role of the Finalize() method is to ensure that a .NET Core
// object can clean up unmanaged resources when it is garbage collected.
namespace FinalizableObjectsForSummerSchool.Models
{
    class MyResourceWrapper
    {
        // Compile-time error!
        // protected override void Finalize() { }

        // Clean up unmanaged resources here.
        // Beep when destroyed (testing purposes only!)
        ~MyResourceWrapper() {
            Console.WriteLine("test");
            Console.Beep(); 
        }
    }
}