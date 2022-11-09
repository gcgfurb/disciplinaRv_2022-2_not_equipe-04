﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HexToColorConverter  {

    /// <summary>
    /// Converts Color to Hex
    /// Note that Color32 and Color implictly convert to each other. You may pass a Color object to this method without first casting it.
    /// </summary>
    public static string ColorToHex(Color32 color)
    {
        string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        return hex;
    }

    /// <summary>
    /// Converts Hex to Color
    /// </summary>
    public static  Color HexToColor(string hex)
    {
        if (hex[0] == '#')
            hex = hex.Substring(1);
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }
}
