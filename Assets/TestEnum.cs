using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TestEnum
{
    AAA,
    BBB,
}

public static class TestEnumExtension
{
    public static bool IsAAA(this TestEnum e)
    {
        return false;
    }
}
