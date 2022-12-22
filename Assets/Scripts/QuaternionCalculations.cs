using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class QuaternionCalculations
{
    public static float GetAngleAt360Format(float angle)
    {
        return angle < 0 ? angle + 360 : angle;
    }
}
