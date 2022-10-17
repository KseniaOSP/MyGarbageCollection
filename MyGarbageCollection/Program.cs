using MyGarbageCollection;
using System;
using System.Diagnostics;
using System.Xml.Schema;

Can pepsi = new("Pepsi");

pepsi.Dispose();

using (Can cola = new("Cola"))
{ 

}

//long[] bigArray = new long[1000000]; 

long managedMemory = GC.GetTotalMemory(false);
Console.WriteLine($"Managed memory is: {managedMemory}");

using (Process proc = Process.GetCurrentProcess())
{
    long totalMemory = proc.PrivateMemorySize64;
    Console.WriteLine($"Total memory is: {totalMemory}");
    long unmanagedMemory = totalMemory - managedMemory;
    Console.WriteLine($"Unmanaged memory is: {unmanagedMemory}");
}






