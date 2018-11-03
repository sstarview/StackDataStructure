using System;

namespace StackDataStructure
{
  public class Stack
  {
    //initially the stack is empty
    private int arrayTop = -1;

    private bool StackEmpty(int[] array)
    {
      if (arrayTop < 0)
      {
        return true;
      }
      else
        return false;
    }
    
    //for pushing the element in the array 
    //one at a time
    public void Push(int[] array, int element)
    {
      arrayTop = arrayTop + 1;
      array[arrayTop] = element;
    }

    //for removing the elements from the array
    //one at a time
    public int Pop(int[] array)
    {
      if (StackEmpty(array))
      {
        throw new Exception("Empty Stack");
      }
      else
      {
        arrayTop = arrayTop - 1;
        return array[arrayTop + 1];
      }
    }
  }
}
