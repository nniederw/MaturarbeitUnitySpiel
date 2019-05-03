using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class keyManager
{
    //private static string keyshoot = "space";
    private static string keyboost= "space";
    private static string keyup = "w";
    private static string keydown = "s";
    private static string keyright = "d";
    private static string keyleft = "a";

    public static bool Shoot()
    {
        bool b = false;
        if (Input.GetMouseButtonDown(0))
        {
            b = true;
        }
        return b;
    }
    public static bool Boost()
    {
        bool b = false;
        if (Input.GetKey(keyboost))
        {
            b = true;
        }
        return b;
    }

    public static bool GoUp()
    {
        bool b = false;
        if (Input.GetKey(keyup))
        {
            b = true;
        }
        return b;
    }
    public static bool GoDown()
    {
        bool b = false;
        if (Input.GetKey(keydown))
        {
            b = true;
        }
        return b;
    }
    public static bool GoRight()
    {
        bool b = false;
        if (Input.GetKey(keyright))
        {
            b = true;
        }
        return b;
    }
    public static bool GoLeft()
    {
        bool b = false;
        if (Input.GetKey(keyleft))
        {
            b = true;
        }
        return b;
    }






}
