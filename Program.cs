using FinalizableObjectsForSummerSchool.Models;
using System;

namespace FinalizableObjectsForSummerSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateObjects(10000);

            // Informs the runtime of a large allocation of unmanaged memory
            // that should be taken into account when scheduling garbage collection.
            GC.AddMemoryPressure(2147483647);

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }
        
        static void CreateObjects(int count)
        {
            MyResourceWrapper[] tonsOfObjects = new MyResourceWrapper[count];
           
            for (int i = 0; i < count; i++)
            {
                tonsOfObjects[i] = new MyResourceWrapper();
            }

            tonsOfObjects = null;
        }
    }
}