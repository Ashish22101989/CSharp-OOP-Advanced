using System;
using System.Collections.Generic;
using System.Text;

public static class Swapper
{
    public static void Swap<T>(IList<T> inputList, int firstIndex, int secondIndex)
    {
        T temp = inputList[firstIndex];
        inputList[firstIndex] = inputList[secondIndex];
        inputList[secondIndex] = temp;
    }
}

