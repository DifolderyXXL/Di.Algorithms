﻿namespace Di.Algorithms.Common;

public static class StaticInstruments
{
    public static void Swap<T>(this IList<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}