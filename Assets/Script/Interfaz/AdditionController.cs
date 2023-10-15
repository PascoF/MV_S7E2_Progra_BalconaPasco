using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionController
{
    public void Execute(int a, int b, int c, Action<int> OnCallback)
    {
        OnCallback?.Invoke(a + b + c);
    }
    public void Puntos(int a, Action<int> OnCallback)
    {
        OnCallback?.Invoke(a);
    }

}
