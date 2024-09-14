using System;

namespace CircularBufferProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a circular buffer with capacity 3
            var buffer = new CircularBuffer<int>(3);

            // Write some data to the buffer
            buffer.Write(1);
            buffer.Write(2);
            buffer.Write(3);

            // Read data from the buffer
            Console.WriteLine(buffer.Read()); // Should print 1
            Console.WriteLine(buffer.Read()); // Should print 2

            // Add more data to test overwriting
            buffer.Write(4);
            buffer.Overwrite(5); // Overwrites 3

            // Read remaining data
            Console.WriteLine(buffer.Read()); // Should print 4
            Console.WriteLine(buffer.Read()); // Should print 5
        }
    }
}
