using System;

namespace StackDataStructure
{
  class Stack
  {
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

    public void Push(int[] array, int element)
    {
      arrayTop = arrayTop + 1;
      array[arrayTop] = element;
    }

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
