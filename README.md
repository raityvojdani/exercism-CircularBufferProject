# Circular Buffer Implementation in C#

## Project Overview

This project implements a **Circular Buffer (Ring Buffer)** in C#. A circular buffer is a data structure that uses a fixed-size buffer as if it were connected end-to-end. The buffer overwrites the oldest data when it becomes full unless the client opts to prevent this. The circular buffer supports the following functionalities:
- Writing data to the buffer.
- Reading data from the buffer.
- Overwriting the oldest data when the buffer is full.
- Clearing the buffer.

## Key Features
1. **Fixed Size**: The buffer has a predetermined size specified during initialization.
2. **Reading/Writing**: You can write data to the buffer and read them in the order they were written.
3. **Overwriting**: When the buffer is full, you can either overwrite the oldest data or raise an exception to prevent further writes.
4. **Clearing**: Clear all the data in the buffer.

## Class Overview

The core of this project is the `CircularBuffer<T>` class, which allows the user to store and manipulate data in a circular buffer fashion.

### Methods:

- **`CircularBuffer(int capacity)`**: Initializes the buffer with the specified capacity.
  
- **`void Write(T value)`**: Adds a new element to the buffer. If the buffer is full, an `InvalidOperationException` is thrown.
  
- **`T Read()`**: Reads and removes the oldest element in the buffer. If the buffer is empty, an `InvalidOperationException` is thrown.

- **`void Overwrite(T value)`**: Writes new data into the buffer, overwriting the oldest data if the buffer is full.

- **`void Clear()`**: Clears all elements in the buffer and resets the `head` and `tail` positions.


### Installation & Usage
1-Clone this repository to your local machine.
git clone https://github.com/your-username/circular-buffer.git

2-Open the project in Visual Studio or another C# IDE.
3-Build and run the project


### Example Usage

```csharp
// Initialize a buffer with a capacity of 3
CircularBuffer<int> buffer = new CircularBuffer<int>(3);

// Write values to the buffer
buffer.Write(1);
buffer.Write(2);
buffer.Write(3);

// Read a value from the buffer
int value = buffer.Read(); // Returns 1

// Write a new value, causing an overwrite of the oldest value (2)
buffer.Overwrite(4);

// Read remaining values
Console.WriteLine(buffer.Read()); // Output: 3
Console.WriteLine(buffer.Read()); // Output: 4

