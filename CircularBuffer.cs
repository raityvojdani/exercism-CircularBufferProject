using System;

public class CircularBuffer<T>
{
    private T[] buffer;
    private int head;  // Tracks the oldest element (read position)
    private int tail;  // Tracks the newest element (write position)
    private bool isFull;  // Tracks if buffer is full

    public CircularBuffer(int capacity)
    {
        buffer = new T[capacity];
        head = 0;
        tail = 0;
        isFull = false;
    }

    public T Read()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Buffer is empty");
        }

        T value = buffer[head];
        buffer[head] = default(T);  // Clear (default(int)=0 )
        head = (head + 1) % buffer.Length;
        isFull = false;
        return value;
    }

    public void Write(T value)
    {
        if (isFull)
        {
            throw new InvalidOperationException("Buffer is full");
        }

        buffer[tail] = value;
        tail = (tail + 1) % buffer.Length;
        if (tail == head)
        {
            isFull = true;
        }
    }

    public void Overwrite(T value)
    {
        if (isFull)
        {
            // Overwrite the oldest element (where head is)
            buffer[tail] = value;
            head = (head + 1) % buffer.Length;  // Move head forward
            tail = (tail + 1) % buffer.Length;  // Move tail forward after writing
        }
        else
        {
            Write(value);  // Normal write if not full
        }
    }

    public void Clear()
    {
        // Reset head, tail, and isFull flag
        head = 0;
        tail = 0;
        isFull = false;
    }

    private bool IsEmpty()
    {
        return !isFull && head == tail;
    }
}
