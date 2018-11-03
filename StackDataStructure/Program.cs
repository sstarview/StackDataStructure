using System;

namespace StackDataStructure
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myArray = new int[10];

      Stack stack = new Stack();
      stack.Push(myArray, 15);
      stack.Push(myArray, 88);
      stack.Push(myArray, 98);
      stack.Push(myArray, 44);
      stack.Pop(myArray);
      stack.Push(myArray, 55);
      stack.Pop(myArray);
      stack.Pop(myArray);
      stack.Pop(myArray);
      stack.Pop(myArray);
      stack.Pop(myArray);
      for (int i = 0; i < myArray.Length; i++)
      {
        Console.WriteLine(myArray[i]);
      }

    }
  }
}
