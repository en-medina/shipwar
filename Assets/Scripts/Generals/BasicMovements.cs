using UnityEngine;
using System.Collections;

public static class BasicMovements
{
    public static void AutoMove(this Transform EneTrans, float XMoveSpeed)
    {
        EneTrans.position += -Vector3.right * XMoveSpeed * Time.deltaTime;
    }

    public static void AutoRotate(this Transform EneRotate, float RotateSpeed)
    {
        EneRotate.Rotate(new Vector3(0, 0, 45) * RotateSpeed * Time.deltaTime);
    }

    public static void SwapValue(ref int a, ref int b)
    {
        a ^= b;
        b ^= a;
        a ^= b;
    }

}
    