using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BitwiseOperations
{
    public static bool CompareLayers(int firstLayer, int secondLayer)
    {
        if ((firstLayer & (1 << secondLayer)) > 0)
        {
            return true;
        }
        return false;
    }
}
