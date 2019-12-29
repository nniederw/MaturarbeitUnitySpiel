using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyManager
{
    //private static string keyshoot = "space";
    private static string keyup = "s";
    private static string keydown = "w";
    private static string keyright = "d";
    private static string keyleft = "a";

    private static bool shoot() { return Input.GetMouseButtonDown(0); }
    private static bool goUp() { return Input.GetKey(keyup); }
    private static bool goDown() { return Input.GetKey(keydown); }
    private static bool goRight() { return Input.GetKey(keyright); }
    private static bool goLeft() { return Input.GetKey(keyleft); }

    public static bool Shoot()
    {
        bool b = false;
        if (shoot())
        { b = true; }
        return b;
    }
    public static bool GoUp()
    {
        bool b = false;
        if ((goUp()))
        {
            b = true;
        }
        return b;
    }
    public static bool GoDown()
    {
        bool b = false;
        if (goDown())
        {
            b = true;
        }
        return b;
    }
    public static bool GoRight()
    {
        bool b = false;
        if (goRight())
        {
            b = true;
        }
        return b;
    }
    public static bool GoLeft()
    {
        bool b = false;
        if (goLeft())
        {
            b = true;
        }
        return b;
    }
}
