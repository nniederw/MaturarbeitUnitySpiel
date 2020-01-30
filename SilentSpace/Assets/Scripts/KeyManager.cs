using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyManager
{
    //private static string keyshoot = "space";
    
    
    private static string keyUp = "s";
    private static string keyDown = "w";
    private static string keyRight = "d";
    private static string keyLeft = "a";
    private static string keyQuit = "escape";
    private static string keyReplay = "r";
    private static string keyShoot = "space";
    private static string keyIncreaseSpeed = "e";
    private static string keyDecreaseSpeed = "q";


    //private static bool shootMouse() { return Input.GetMouseButtonDown(0); }
    //private static bool shoot() { return Input.GetMouseButtonDown(0); }
    private static bool shoot() { return Input.GetKey(keyShoot); }
    private static bool goUp() { return Input.GetKey(keyUp); }
    private static bool goDown() { return Input.GetKey(keyDown); }
    private static bool goRight() { return Input.GetKey(keyRight); }
    private static bool goLeft() { return Input.GetKey(keyLeft); }
    private static bool goQuit() { return Input.GetKey(keyQuit); }
    private static bool goReplay() { return Input.GetKey(keyReplay); }
    private static bool goIncreaseSpeed() { return Input.GetKey(keyIncreaseSpeed); }
    private static bool goDecreaseSpeed() { return Input.GetKey(keyDecreaseSpeed); }

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
    public static bool GoQuit()
    {
        bool b = false;
        if (goQuit())
        {
            b = true;
        }
        return b;
    }
    public static bool GoReplay()
    {
        bool b = false;
        if (goReplay())
        {
            b = true;
        }
        return b;
    }
    public static bool IncreaseSpeed()
    {
        bool b = false;
        if (goIncreaseSpeed())
        {
            b = true;
        }
        return b;
    }
    public static bool DecreaseSpeed()
    {
        bool b = false;
        if (goDecreaseSpeed())
        {
            b = true;
        }
        return b;
    }

}
/*
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
    private static string keyquit = "escape";

    private static bool shoot() { return Input.GetMouseButtonDown(0); }
    private static bool goUp() { return Input.GetKey(keyup); }
    private static bool goDown() { return Input.GetKey(keydown); }
    private static bool goRight() { return Input.GetKey(keyright); }
    private static bool goLeft() { return Input.GetKey(keyleft); }
    private static bool goQuit() { return Input.GetKey(keyquit); }

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
    public static bool GoQuit()
    {
        bool b = false;
        if (goQuit())
        {
            b = true;
        }
        return b;
    }

}
*/