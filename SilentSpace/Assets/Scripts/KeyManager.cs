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
    private static string keyreplay = "r";
    private static string keyshoot = "space";
    

    //private static bool shootMouse() { return Input.GetMouseButtonDown(0); }
    //private static bool shoot() { return Input.GetKey(keyshoot); }
    private static bool shoot() { return Input.GetKeyDown("Shoot"); }
    private static bool goUp() { return Input.GetKeyDown("Up"); }
    private static bool goDown() { return Input.GetKeyDown("Down"); }
    private static bool goRight() { return Input.GetKeyDown("Right"); }
    private static bool goLeft() { return Input.GetKeyDown("Left"); }
    private static bool goQuit() { return Input.GetKeyDown("Quit"); }
    private static bool goReplay() { return Input.GetKeyDown("Reload"); }

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

}
