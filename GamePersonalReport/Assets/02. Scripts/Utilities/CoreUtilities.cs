using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoreUtilities
{
    #region Literals

    public const string PLAYER_KEY = "USER_NAME";

    #endregion

    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm:ss"));
    }
}
